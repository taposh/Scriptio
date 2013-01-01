///////////////////////////////////////////////////////////////////////////////////////////////
//  SQL-Scripter - Script SQL Server 2005 objects
//  Copyright (C) 2007 Taposh Dutta-Roy

//  This program is free software; you can redistribute it and/or modify
//  it under the terms of the GNU General Public License as published by
//  the Free Software Foundation; either version 2 of the License, or
//  (at your option) any later version.

//  This program is distributed in the hope that it will be useful,
//  but WITHOUT ANY WARRANTY; without even the implied warranty of
//  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//  GNU General Public License for more details.

//  You should have received a copy of the GNU General Public License
//  along with this program; if not, write to the Free Software
//  Foundation, Inc., 51 Franklin St, Fifth Floor, Boston, MA  02110-1301  USA
///////////////////////////////////////////////////////////////////////////////////////////////


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using Microsoft.SqlServer.Management.Smo;
using Microsoft.SqlServer.Management.Common;
using System.Collections.Specialized;
using System.IO;
using System.Text.RegularExpressions;

namespace Scriptio
{
    
    public partial class Scriptio : Form
    {
        private StringBuilder result;

        public Scriptio()
        {
            InitializeComponent();

            aboutToolStripMenuItem.Click += new EventHandler(aboutToolStripMenuItem_Click);
            exitToolStripMenuItem.Click += new EventHandler(exitToolStripMenuItem_Click);
        }


        #region Menu Stuff
        void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm f = new AboutForm();
            f.Show();
        }
        #endregion

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {


            //if (ddlDatabases.Items.Count == 0)
            PopulateDatabases(txtServerName.Text);


            if (ddlDatabases.Items.Count > 0)
                ddlDatabases.SelectedIndex = 0;

        }

        private void PopulateDatabases(string serverName)
        {
            ddlDatabases.Items.Clear();
            try
            {
                SqlConnection conn = GetConnection("tempdb");
                Server srv = new Server(new ServerConnection(conn));

                // Check if we're using 2005 or higher
                if (srv.Information.Version.Major >= 9)
                {

                    ddlDatabases.Items.Add("(Select a database)");
            
                    foreach (Database db in srv.Databases)
                    {
                        if (db.IsSystemObject == false && db.IsAccessible)
                        {
                            ddlDatabases.Items.Add(db.Name);
                        }

                    }

                    if (ddlDatabases.Items.Count > 0)
                        ddlDatabases.SelectedIndex = 0;
                }
                else
                {
                    MessageBox.Show("SMO Scripting is only available for SQL Server 2005 and higher",
                        "Incorrect Server Version", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    dgAvailableObjects.Rows.Clear();
                    chkScriptAll.Checked = false;
                    ddlDatabases.ResetText();
                }
            }
            catch (ConnectionFailureException)
            {
                MessageBox.Show("Unable to connect to server",
                        "Invalid Server", MessageBoxButtons.OK, MessageBoxIcon.Error);
               
            }

            

        }

        private void PopulateObjects(string serverName, string databaseName)
        {
            // lstAvailableObjects.Items.Clear();


                            string sql = @"SELECT	
	                s.[name] AS [SchemaName],
	                ao.[name] AS [ObjectName],
	                type_desc AS [TypeDescription]
                FROM
	                " + databaseName + @".sys.all_objects AS ao
                JOIN
	                sys.schemas AS s ON s.schema_id = ao.schema_id
                WHERE
	                ao.is_ms_shipped = 0
                AND
	                ao.type_desc IN ('USER_TABLE', 'VIEW', 
			                'SQL_STORED_PROCEDURE','SQL_TRIGGER',
			                'CLR_STORED_PROCEDURE', 'CLR_SCALAR_FUNCTION', 'CLR_TABLE_VALUED_FUNCTION', /* 'CLR_TRIGGER', */
			                'SQL_INLINE_TABLE_VALUED_FUNCTION', 'SQL_TABLE_VALUED_FUNCTION', 'SQL_SCALAR_FUNCTION' )
                AND
                    ao.[name] NOT LIKE 'dt%'

                UNION ALL

                SELECT
	                '' AS [SchemaName],
	                [name] AS [ObjectName],
	                'ASSEMBLY' AS [TypeDescription]
                FROM
	                sys.assemblies
                ORDER BY 
                    1";


            SqlConnection conn = GetConnection(databaseName);
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = sql;
            SqlDataReader rdr = cmd.ExecuteReader();

            dgAvailableObjects.Rows.Clear();

            while (rdr.Read())
            {
                // lstAvailableObjects.Items.Add(rdr.GetString(0) + "." + rdr.GetString(1) /* + " (" + rdr.GetString(2) + ")" */);
                // lstAvailableObjects.Items.Add("A");
                dgAvailableObjects.Rows.Add(new string[] { "False", rdr.GetString(0), rdr.GetString(1), rdr.GetString(2) });
            }
            rdr.Close();
            conn.Close();

        }

        
        private SqlConnection GetConnection(string databaseName)
        {
            SqlConnectionStringBuilder csb = new SqlConnectionStringBuilder();
            csb.DataSource = txtServerName.Text;
            if (chkUseWindowsAuthentication.Checked )
            {
                csb.IntegratedSecurity = true;
            }
            else
            {
                csb.IntegratedSecurity = false;
                csb.UserID = txtUsername.Text;
                csb.Password = txtPassword.Text;
            }
            csb.InitialCatalog = databaseName;
            csb.ApplicationName = "SQl-Scripter";
            SqlConnection c = new SqlConnection(csb.ConnectionString);
            return c;

        }

        private string GetConnectionString(string databaseName)
        {
            SqlConnectionStringBuilder csb = new SqlConnectionStringBuilder();
            csb.DataSource = txtServerName.Text;
            if (chkUseWindowsAuthentication.Checked)
            {
                csb.IntegratedSecurity = true;
            }
            else
            {
                csb.IntegratedSecurity = false;
                csb.UserID = txtUsername.Text;
                csb.Password = txtPassword.Text;
            }
            csb.InitialCatalog = databaseName;
            csb.ApplicationName = "SQL-Scripter";
            return csb.ConnectionString;

        }


        private void ddlDatabases_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox c = (ComboBox)sender;
            chkScriptAll.Checked = false;
            if (c.SelectedIndex > 0 )
                PopulateObjects(txtServerName.Text, c.SelectedItem.ToString());
            else
            {
                dgAvailableObjects.Rows.Clear();
            }
        }

        
        private void btnScript_Click(object sender, EventArgs e)
        {
            // Server srv = new Server(txtServerName.Text);
            Server srv;
            if (chkUseWindowsAuthentication.Checked)
                srv = new Server(txtServerName.Text);
            else
                srv = new Server(new ServerConnection(txtServerName.Text, txtUsername.Text, txtPassword.Text));

  
            Database db = srv.Databases[ddlDatabases.SelectedItem.ToString()];

            string objectType = "";
            string objectName = "";
            string schema = "";
            txtResult.Text = "";

            result = new StringBuilder();

            dgAvailableObjects.EndEdit();
            int count = 0;
            int totalObjects = CountChecks();
            toolStripProgressBar1.Maximum = totalObjects;
            result.EnsureCapacity(totalObjects * 4000);

            // Delete the file if it already exists
            if (File.Exists(txtSaveLocation.Text))
                File.Delete(txtSaveLocation.Text);

            ScriptingOptions baseOptions = new ScriptingOptions();
            baseOptions.IncludeHeaders = chkIncludeHeaders.Checked;
            baseOptions.Indexes = chkIndexes.Checked;
            baseOptions.DriAllKeys = chkKeys.Checked;
            baseOptions.NoCollation = !chkCollation.Checked;
            baseOptions.SchemaQualify = chkSchemaQualifyCreates.Checked;
            baseOptions.SchemaQualifyForeignKeysReferences = chkSchemaQualifyFK.Checked;
            baseOptions.Permissions = chkPermissions.Checked;
            
           
            if (rdoOneFile.Checked || rdoOnePerObject.Checked)
            {
                baseOptions.FileName = txtSaveLocation.Text;
                baseOptions.AppendToFile = true;
            }

            
            ScriptingOptions dropOptions = new ScriptingOptions();
            dropOptions.ScriptDrops = true;
            dropOptions.IncludeIfNotExists = chkExistance.Checked;
            dropOptions.SchemaQualify = chkSchemaQualifyDrops.Checked;

            if (rdoOneFile.Checked || rdoOnePerObject.Checked)
            {
                dropOptions.FileName = txtSaveLocation.Text;
                dropOptions.AppendToFile = true;
            }


            // process each checked object
            foreach (DataGridViewRow r in dgAvailableObjects.Rows)
            {
                if (r.Cells[0].Value.ToString() == "True")
                {
                    count++;
                    toolStripProgressBar1.Value = count;

                    objectType = r.Cells[3].Value.ToString();
                    objectName = r.Cells[2].Value.ToString();
                    schema = r.Cells[1].Value.ToString();
                    string fileName = "";

                    if (rdoOnePerObject.Checked)
                    {
                        if (schema.Length > 0)
                        {
                            if (objectType == "ASSEMBLY")
                            {
                                fileName = Path.Combine(txtSaveLocation.Text, schema + "." + objectName + ".ASL");

                            }
                            if (objectType == "SQL_TRIGGER")
                            {
                                fileName = Path.Combine(txtSaveLocation.Text, schema + "." + objectName + ".trg");

                            }
                            if (objectType == "USER_TABLE")
                            {
                                fileName = Path.Combine(txtSaveLocation.Text, schema + "." + objectName + ".tbl");

                            }
                            if (objectType == "SQL_STORED_PROCEDURE")
                            {
                                fileName = Path.Combine(txtSaveLocation.Text, schema + "." + objectName + ".prc");

                            }


                            if (objectType == "CLR_STORED_PROCEDURE")
                            {
                                fileName = Path.Combine(txtSaveLocation.Text, schema + "." + objectName + ".clrprc");

                            }


                            if (objectType == "VIEW")
                            {
                                fileName = Path.Combine(txtSaveLocation.Text, schema + "." + objectName + ".vwv");
                            }

                           if (objectType == "CLR_SCALAR_FUNCTION" || objectType == "CLR_SCALAR_FUNCTION"
                            || objectType == "CLR_TABLE_VALUED_FUNCTION" || objectType == "SQL_INLINE_TABLE_VALUED_FUNCTION"
                            || objectType == "SQL_TABLE_VALUED_FUNCTION" || objectType == "SQL_SCALAR_FUNCTION" )
                           {
                              fileName = Path.Combine(txtSaveLocation.Text, schema + "." + objectName + ".fnc");

                           }


                        
                        }


                        if (!rdoOnePerObject.Checked)
                        {
                            fileName = Path.Combine(txtSaveLocation.Text, objectName + ".sql");
                        }
                            if (File.Exists(fileName))
                            File.Delete(fileName);

                        baseOptions.FileName = fileName;
                        dropOptions.FileName = fileName;
                    }

                    if (schema.Length > 0)
                        toolStripStatusLabel1.Text = schema + "." + objectName + "...";
                    else
                        toolStripStatusLabel1.Text = objectName + "...";

                    if (objectType == "ASSEMBLY")
                    {
                        SqlAssembly a = db.Assemblies[objectName];

                        if (chkDrop.Checked)
                        {
                            AddLines(a.Script(dropOptions));
                            AddGo();
                        }

                        if (chkCreate.Checked)
                        {
                            AddLines(a.Script(baseOptions));
                            AddGo();
                        }

                        a = null;
                    }

                    //Change

                    if (objectType == "SQL_TRIGGER")
                    {
                        
                        foreach (Table t in db.Tables)
                            if ( t.Triggers.Contains(objectName))
                            {
                                  if (chkDrop.Checked)
                                    {
                                AddLines(t.Triggers[objectName].Script(dropOptions));
                                AddGo();
                                    }

                            if (chkCreate.Checked)
                                    {
                                AddLines(t.Triggers[objectName].Script(baseOptions));
                                AddGo();
                                    }
                            }

                       
                    }

                    if (objectType == "USER_TABLE" )
                    {
                        Table t = db.Tables[objectName, schema];

                        if (chkDrop.Checked)
                        {
                            AddLines(t.Script(dropOptions));
                            AddGo();
                        }

                        if (chkCreate.Checked)
                        {
                            AddLines(t.Script(baseOptions));
                            AddGo();
                        }
                        
                        t = null;
                    }
                    
                    
                    if (objectType == "SQL_STORED_PROCEDURE"  || objectType == "CLR_STORED_PROCEDURE")
                    {
                        StoredProcedure sp = db.StoredProcedures[objectName, schema];

                        if (chkDrop.Checked)
                        {
                            AddLines(sp.Script(dropOptions));
                            AddGo();
                        }

                        if (chkCreate.Checked)
                        {
                            AddLines(sp.Script(baseOptions));
                            AddGo();
                        }

                        sp = null;
                    }

                    if (objectType == "VIEW")
                    {
                        Microsoft.SqlServer.Management.Smo.View v = db.Views[objectName, schema];

                        if (chkDrop.Checked)
                        {
                            AddLines(v.Script(dropOptions));
                            AddGo();
                        }

                        if (chkCreate.Checked)
                        {
                            AddLines(v.Script(baseOptions));
                            AddGo();
                        }

                        v = null;
                    }



                    if (objectType == "CLR_SCALAR_FUNCTION" || objectType == "CLR_SCALAR_FUNCTION"
                            || objectType == "CLR_TABLE_VALUED_FUNCTION" || objectType == "SQL_INLINE_TABLE_VALUED_FUNCTION"
                            || objectType == "SQL_TABLE_VALUED_FUNCTION" || objectType == "SQL_SCALAR_FUNCTION" )
                    {
                        UserDefinedFunction udf = db.UserDefinedFunctions[objectName, schema];

                        if (chkDrop.Checked)
                        {
                            AddLines(udf.Script(dropOptions));
                            AddGo();
                        }

                        if (chkCreate.Checked)
                        {
                            AddLines(udf.Script(baseOptions));
                            AddGo();
                        }

                        udf = null;
                    }

                    Application.DoEvents();

                }
            }

            txtResult.MaxLength = result.Length + 100;
            txtResult.Text = result.ToString();
            toolStripStatusLabel1.Text = "Completed";
            tabControl1.SelectedTab = tabResult;
            Application.DoEvents();
        }


        void AddLines(StringCollection strings)
        {
            foreach(string s in strings)
            {
                result.Append(System.Environment.NewLine + s);

                if (s.StartsWith("SET QUOTED_IDENTIFIER") || s.StartsWith("SET ANSI_NULLS"))
                    result.Append(System.Environment.NewLine + "GO");
            }

            
        }

        void AddGo()
        {

            result.Append(System.Environment.NewLine + "GO" + System.Environment.NewLine + System.Environment.NewLine);
        }

        private void chkScriptAll_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox c = (CheckBox)sender;
            foreach (DataGridViewRow r in dgAvailableObjects.Rows)
            {
                r.Cells[0].Value = c.Checked;
            }

        }

        private int CountChecks()
        {
            int count = 0;
            foreach (DataGridViewRow r in dgAvailableObjects.Rows)
            {
                if (r.Cells[0].Value.ToString() == "True")
                    count++;
            }

            return count;
        }



        private void btnPickDirectory_Click(object sender, EventArgs e)
        {
            if (rdoOneFile.Checked)
            {
                saveFileDialog1.ShowDialog();
                txtSaveLocation.Text = saveFileDialog1.FileName.ToString();
            }

            if (rdoOnePerObject.Checked)
            {
                folderBrowserDialog1.ShowDialog();
                txtSaveLocation.Text = folderBrowserDialog1.SelectedPath.ToString();
            }

        }

        private void rdoOneFile_CheckedChanged(object sender, EventArgs e)
        {
            txtSaveLocation.Text = "";
        }

        private void rdoNoFiles_CheckedChanged(object sender, EventArgs e)
        {
            txtSaveLocation.Text = "";
        }

        private void rdoOnePerObject_CheckedChanged(object sender, EventArgs e)
        {
            txtSaveLocation.Text = "";
        }

        private void btnCopyClipboard_Click(object sender, EventArgs e)
        {
            txtResult.SelectAll();
            txtResult.Copy();
            
        }

        private void chkUseWindowsAuthentication_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox c = (CheckBox)sender;
            if (c.Checked)
            {
                txtUsername.Enabled = false;
                txtPassword.Enabled = false;
            }
            else
            {
                txtUsername.Enabled = true;
                txtPassword.Enabled = true;
            }
        }

        private void btnSaveAs_Click(object sender, EventArgs e)
        {

        }

        private void Scriptio_Load(object sender, EventArgs e)
        {
        #if (DEBUG)
                    txtServerName.Text = @"SMTAROYNC6400\SQL_TAPOSH";
        #endif
                    this.reportViewer1.RefreshReport();
                    this.reportViewer2.RefreshReport();
        }

        private void tabObjects_Click(object sender, EventArgs e)
        {

        }

        private void ddlSchema_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ddlType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



        

    }
}
