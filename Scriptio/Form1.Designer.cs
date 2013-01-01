namespace Scriptio
{
    partial class Scriptio
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabObjects = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ddlType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.chkScriptAll = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ddlSchema = new System.Windows.Forms.ComboBox();
            this.dgAvailableObjects = new System.Windows.Forms.DataGridView();
            this.Script = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Schema = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Object = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkPermissions = new System.Windows.Forms.CheckBox();
            this.chkIndexes = new System.Windows.Forms.CheckBox();
            this.chkKeys = new System.Windows.Forms.CheckBox();
            this.chkExistance = new System.Windows.Forms.CheckBox();
            this.chkDrop = new System.Windows.Forms.CheckBox();
            this.chkCreate = new System.Windows.Forms.CheckBox();
            this.chkIncludeHeaders = new System.Windows.Forms.CheckBox();
            this.ddlDatabases = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.chkUseWindowsAuthentication = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtServerName = new System.Windows.Forms.TextBox();
            this.tabOptions = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.chkSchemaQualifyFK = new System.Windows.Forms.CheckBox();
            this.chkSchemaQualifyDrops = new System.Windows.Forms.CheckBox();
            this.chkSchemaQualifyCreates = new System.Windows.Forms.CheckBox();
            this.chkCollation = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rdoOnePerObject = new System.Windows.Forms.RadioButton();
            this.btnPickDirectory = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSaveLocation = new System.Windows.Forms.TextBox();
            this.rdoOneFile = new System.Windows.Forms.RadioButton();
            this.rdoNoFiles = new System.Windows.Forms.RadioButton();
            this.tabResult = new System.Windows.Forms.TabPage();
            this.btnCopyClipboard = new System.Windows.Forms.Button();
            this.btnSaveAs = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnScript = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1.SuspendLayout();
            this.tabObjects.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgAvailableObjects)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabOptions.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tabResult.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabObjects);
            this.tabControl1.Controls.Add(this.tabOptions);
            this.tabControl1.Controls.Add(this.tabResult);
            this.tabControl1.Location = new System.Drawing.Point(0, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(795, 502);
            this.tabControl1.TabIndex = 0;
            // 
            // tabObjects
            // 
            this.tabObjects.Controls.Add(this.groupBox3);
            this.tabObjects.Controls.Add(this.dgAvailableObjects);
            this.tabObjects.Controls.Add(this.groupBox2);
            this.tabObjects.Controls.Add(this.groupBox1);
            this.tabObjects.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabObjects.Location = new System.Drawing.Point(4, 22);
            this.tabObjects.Name = "tabObjects";
            this.tabObjects.Padding = new System.Windows.Forms.Padding(3);
            this.tabObjects.Size = new System.Drawing.Size(787, 476);
            this.tabObjects.TabIndex = 0;
            this.tabObjects.Text = "Database Objects";
            this.tabObjects.UseVisualStyleBackColor = true;
            this.tabObjects.Click += new System.EventHandler(this.tabObjects_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ddlType);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.chkScriptAll);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.ddlSchema);
            this.groupBox3.Location = new System.Drawing.Point(0, 128);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(335, 80);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Filter";
            // 
            // ddlType
            // 
            this.ddlType.Enabled = false;
            this.ddlType.FormattingEnabled = true;
            this.ddlType.Location = new System.Drawing.Point(54, 51);
            this.ddlType.Name = "ddlType";
            this.ddlType.Size = new System.Drawing.Size(244, 21);
            this.ddlType.TabIndex = 14;
            this.ddlType.SelectedIndexChanged += new System.EventHandler(this.ddlType_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Type:";
            // 
            // chkScriptAll
            // 
            this.chkScriptAll.AutoSize = true;
            this.chkScriptAll.Location = new System.Drawing.Point(9, 19);
            this.chkScriptAll.Name = "chkScriptAll";
            this.chkScriptAll.Size = new System.Drawing.Size(67, 17);
            this.chkScriptAll.TabIndex = 9;
            this.chkScriptAll.Text = "Script All";
            this.chkScriptAll.UseVisualStyleBackColor = true;
            this.chkScriptAll.CheckedChanged += new System.EventHandler(this.chkScriptAll_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(90, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Schema:";
            // 
            // ddlSchema
            // 
            this.ddlSchema.Enabled = false;
            this.ddlSchema.FormattingEnabled = true;
            this.ddlSchema.Location = new System.Drawing.Point(145, 17);
            this.ddlSchema.Name = "ddlSchema";
            this.ddlSchema.Size = new System.Drawing.Size(153, 21);
            this.ddlSchema.TabIndex = 11;
            this.ddlSchema.SelectedIndexChanged += new System.EventHandler(this.ddlSchema_SelectedIndexChanged);
            // 
            // dgAvailableObjects
            // 
            this.dgAvailableObjects.AllowUserToAddRows = false;
            this.dgAvailableObjects.AllowUserToDeleteRows = false;
            this.dgAvailableObjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAvailableObjects.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Script,
            this.Schema,
            this.Object,
            this.Type});
            this.dgAvailableObjects.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgAvailableObjects.Location = new System.Drawing.Point(6, 225);
            this.dgAvailableObjects.Name = "dgAvailableObjects";
            this.dgAvailableObjects.RowTemplate.Height = 24;
            this.dgAvailableObjects.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgAvailableObjects.Size = new System.Drawing.Size(596, 300);
            this.dgAvailableObjects.TabIndex = 8;
            // 
            // Script
            // 
            this.Script.HeaderText = "Script";
            this.Script.Name = "Script";
            this.Script.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Schema
            // 
            this.Schema.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Schema.HeaderText = "Schema";
            this.Schema.Name = "Schema";
            this.Schema.Width = 71;
            // 
            // Object
            // 
            this.Object.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Object.HeaderText = "Object";
            this.Object.Name = "Object";
            this.Object.Width = 63;
            // 
            // Type
            // 
            this.Type.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Type.HeaderText = "Type";
            this.Type.Name = "Type";
            this.Type.Width = 56;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkPermissions);
            this.groupBox2.Controls.Add(this.chkIndexes);
            this.groupBox2.Controls.Add(this.chkKeys);
            this.groupBox2.Controls.Add(this.chkExistance);
            this.groupBox2.Controls.Add(this.chkDrop);
            this.groupBox2.Controls.Add(this.chkCreate);
            this.groupBox2.Controls.Add(this.chkIncludeHeaders);
            this.groupBox2.Controls.Add(this.ddlDatabases);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(344, 77);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(259, 131);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Options";
            // 
            // chkPermissions
            // 
            this.chkPermissions.AutoSize = true;
            this.chkPermissions.Location = new System.Drawing.Point(8, 106);
            this.chkPermissions.Name = "chkPermissions";
            this.chkPermissions.Size = new System.Drawing.Size(119, 17);
            this.chkPermissions.TabIndex = 12;
            this.chkPermissions.Text = "Include Permissions";
            this.chkPermissions.UseVisualStyleBackColor = true;
            // 
            // chkIndexes
            // 
            this.chkIndexes.AutoSize = true;
            this.chkIndexes.Checked = true;
            this.chkIndexes.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkIndexes.Location = new System.Drawing.Point(150, 63);
            this.chkIndexes.Name = "chkIndexes";
            this.chkIndexes.Size = new System.Drawing.Size(101, 17);
            this.chkIndexes.TabIndex = 11;
            this.chkIndexes.Text = "Include Indexes";
            this.chkIndexes.UseVisualStyleBackColor = true;
            // 
            // chkKeys
            // 
            this.chkKeys.AutoSize = true;
            this.chkKeys.Checked = true;
            this.chkKeys.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkKeys.Location = new System.Drawing.Point(150, 40);
            this.chkKeys.Name = "chkKeys";
            this.chkKeys.Size = new System.Drawing.Size(87, 17);
            this.chkKeys.TabIndex = 10;
            this.chkKeys.Text = "Include Keys";
            this.chkKeys.UseVisualStyleBackColor = true;
            // 
            // chkExistance
            // 
            this.chkExistance.AutoSize = true;
            this.chkExistance.Checked = true;
            this.chkExistance.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkExistance.Location = new System.Drawing.Point(9, 86);
            this.chkExistance.Name = "chkExistance";
            this.chkExistance.Size = new System.Drawing.Size(121, 17);
            this.chkExistance.TabIndex = 9;
            this.chkExistance.Text = "Check for Existance";
            this.chkExistance.UseVisualStyleBackColor = true;
            // 
            // chkDrop
            // 
            this.chkDrop.AutoSize = true;
            this.chkDrop.Checked = true;
            this.chkDrop.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkDrop.Location = new System.Drawing.Point(9, 63);
            this.chkDrop.Name = "chkDrop";
            this.chkDrop.Size = new System.Drawing.Size(95, 17);
            this.chkDrop.TabIndex = 8;
            this.chkDrop.Text = "Include DROP";
            this.chkDrop.UseVisualStyleBackColor = true;
            // 
            // chkCreate
            // 
            this.chkCreate.AutoSize = true;
            this.chkCreate.Checked = true;
            this.chkCreate.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkCreate.Location = new System.Drawing.Point(9, 40);
            this.chkCreate.Name = "chkCreate";
            this.chkCreate.Size = new System.Drawing.Size(107, 17);
            this.chkCreate.TabIndex = 7;
            this.chkCreate.Text = "Include CREATE";
            this.chkCreate.UseVisualStyleBackColor = true;
            // 
            // chkIncludeHeaders
            // 
            this.chkIncludeHeaders.AutoSize = true;
            this.chkIncludeHeaders.Checked = true;
            this.chkIncludeHeaders.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkIncludeHeaders.Location = new System.Drawing.Point(150, 86);
            this.chkIncludeHeaders.Name = "chkIncludeHeaders";
            this.chkIncludeHeaders.Size = new System.Drawing.Size(104, 17);
            this.chkIncludeHeaders.TabIndex = 6;
            this.chkIncludeHeaders.Text = "Include Headers";
            this.chkIncludeHeaders.UseVisualStyleBackColor = true;
            // 
            // ddlDatabases
            // 
            this.ddlDatabases.FormattingEnabled = true;
            this.ddlDatabases.Location = new System.Drawing.Point(68, 13);
            this.ddlDatabases.Name = "ddlDatabases";
            this.ddlDatabases.Size = new System.Drawing.Size(121, 21);
            this.ddlDatabases.TabIndex = 5;
            this.ddlDatabases.SelectedIndexChanged += new System.EventHandler(this.ddlDatabases_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Database:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtPassword);
            this.groupBox1.Controls.Add(this.txtUsername);
            this.groupBox1.Controls.Add(this.btnConnect);
            this.groupBox1.Controls.Add(this.chkUseWindowsAuthentication);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtServerName);
            this.groupBox1.Location = new System.Drawing.Point(2, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(322, 115);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Server";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 92);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Password:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Username:";
            // 
            // txtPassword
            // 
            this.txtPassword.Enabled = false;
            this.txtPassword.Location = new System.Drawing.Point(73, 89);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(143, 20);
            this.txtPassword.TabIndex = 5;
            // 
            // txtUsername
            // 
            this.txtUsername.Enabled = false;
            this.txtUsername.Location = new System.Drawing.Point(73, 63);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(143, 20);
            this.txtUsername.TabIndex = 4;
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(232, 71);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 3;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // chkUseWindowsAuthentication
            // 
            this.chkUseWindowsAuthentication.AutoSize = true;
            this.chkUseWindowsAuthentication.Checked = true;
            this.chkUseWindowsAuthentication.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkUseWindowsAuthentication.Location = new System.Drawing.Point(73, 40);
            this.chkUseWindowsAuthentication.Name = "chkUseWindowsAuthentication";
            this.chkUseWindowsAuthentication.Size = new System.Drawing.Size(163, 17);
            this.chkUseWindowsAuthentication.TabIndex = 2;
            this.chkUseWindowsAuthentication.Text = "Use Windows Authentication";
            this.chkUseWindowsAuthentication.UseVisualStyleBackColor = true;
            this.chkUseWindowsAuthentication.CheckedChanged += new System.EventHandler(this.chkUseWindowsAuthentication_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Server:";
            // 
            // txtServerName
            // 
            this.txtServerName.Location = new System.Drawing.Point(73, 13);
            this.txtServerName.Name = "txtServerName";
            this.txtServerName.Size = new System.Drawing.Size(169, 20);
            this.txtServerName.TabIndex = 0;
            // 
            // tabOptions
            // 
            this.tabOptions.Controls.Add(this.groupBox5);
            this.tabOptions.Controls.Add(this.groupBox4);
            this.tabOptions.Location = new System.Drawing.Point(4, 22);
            this.tabOptions.Name = "tabOptions";
            this.tabOptions.Size = new System.Drawing.Size(775, 531);
            this.tabOptions.TabIndex = 3;
            this.tabOptions.Text = "More Options";
            this.tabOptions.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.chkSchemaQualifyFK);
            this.groupBox5.Controls.Add(this.chkSchemaQualifyDrops);
            this.groupBox5.Controls.Add(this.chkSchemaQualifyCreates);
            this.groupBox5.Controls.Add(this.chkCollation);
            this.groupBox5.Location = new System.Drawing.Point(3, 141);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(533, 387);
            this.groupBox5.TabIndex = 19;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Additional Scription Options";
            // 
            // chkSchemaQualifyFK
            // 
            this.chkSchemaQualifyFK.AutoSize = true;
            this.chkSchemaQualifyFK.Checked = true;
            this.chkSchemaQualifyFK.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSchemaQualifyFK.Location = new System.Drawing.Point(7, 92);
            this.chkSchemaQualifyFK.Name = "chkSchemaQualifyFK";
            this.chkSchemaQualifyFK.Size = new System.Drawing.Size(186, 17);
            this.chkSchemaQualifyFK.TabIndex = 3;
            this.chkSchemaQualifyFK.Text = "Qualify Foreign Keys with Schema";
            this.chkSchemaQualifyFK.UseVisualStyleBackColor = true;
            // 
            // chkSchemaQualifyDrops
            // 
            this.chkSchemaQualifyDrops.AutoSize = true;
            this.chkSchemaQualifyDrops.Checked = true;
            this.chkSchemaQualifyDrops.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSchemaQualifyDrops.Location = new System.Drawing.Point(7, 68);
            this.chkSchemaQualifyDrops.Name = "chkSchemaQualifyDrops";
            this.chkSchemaQualifyDrops.Size = new System.Drawing.Size(161, 17);
            this.chkSchemaQualifyDrops.TabIndex = 2;
            this.chkSchemaQualifyDrops.Text = "Qualify DROPs with Schema";
            this.chkSchemaQualifyDrops.UseVisualStyleBackColor = true;
            // 
            // chkSchemaQualifyCreates
            // 
            this.chkSchemaQualifyCreates.AutoSize = true;
            this.chkSchemaQualifyCreates.Checked = true;
            this.chkSchemaQualifyCreates.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSchemaQualifyCreates.Location = new System.Drawing.Point(7, 44);
            this.chkSchemaQualifyCreates.Name = "chkSchemaQualifyCreates";
            this.chkSchemaQualifyCreates.Size = new System.Drawing.Size(173, 17);
            this.chkSchemaQualifyCreates.TabIndex = 1;
            this.chkSchemaQualifyCreates.Text = "Qualify CREATEs with Schema";
            this.chkSchemaQualifyCreates.UseVisualStyleBackColor = true;
            // 
            // chkCollation
            // 
            this.chkCollation.AutoSize = true;
            this.chkCollation.Checked = true;
            this.chkCollation.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkCollation.Location = new System.Drawing.Point(7, 20);
            this.chkCollation.Name = "chkCollation";
            this.chkCollation.Size = new System.Drawing.Size(104, 17);
            this.chkCollation.TabIndex = 0;
            this.chkCollation.Text = "Include Collation";
            this.chkCollation.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rdoOnePerObject);
            this.groupBox4.Controls.Add(this.btnPickDirectory);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.txtSaveLocation);
            this.groupBox4.Controls.Add(this.rdoOneFile);
            this.groupBox4.Controls.Add(this.rdoNoFiles);
            this.groupBox4.Location = new System.Drawing.Point(3, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(533, 131);
            this.groupBox4.TabIndex = 18;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Files to Generate";
            // 
            // rdoOnePerObject
            // 
            this.rdoOnePerObject.AutoSize = true;
            this.rdoOnePerObject.Location = new System.Drawing.Point(7, 67);
            this.rdoOnePerObject.Name = "rdoOnePerObject";
            this.rdoOnePerObject.Size = new System.Drawing.Size(116, 17);
            this.rdoOnePerObject.TabIndex = 2;
            this.rdoOnePerObject.Text = "One File per Object";
            this.rdoOnePerObject.UseVisualStyleBackColor = true;
            this.rdoOnePerObject.CheckedChanged += new System.EventHandler(this.rdoOnePerObject_CheckedChanged);
            // 
            // btnPickDirectory
            // 
            this.btnPickDirectory.Location = new System.Drawing.Point(501, 96);
            this.btnPickDirectory.Name = "btnPickDirectory";
            this.btnPickDirectory.Size = new System.Drawing.Size(26, 23);
            this.btnPickDirectory.TabIndex = 16;
            this.btnPickDirectory.Text = "...";
            this.btnPickDirectory.UseVisualStyleBackColor = true;
            this.btnPickDirectory.Click += new System.EventHandler(this.btnPickDirectory_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Location:";
            // 
            // txtSaveLocation
            // 
            this.txtSaveLocation.Location = new System.Drawing.Point(60, 98);
            this.txtSaveLocation.Name = "txtSaveLocation";
            this.txtSaveLocation.Size = new System.Drawing.Size(435, 20);
            this.txtSaveLocation.TabIndex = 15;
            // 
            // rdoOneFile
            // 
            this.rdoOneFile.AutoSize = true;
            this.rdoOneFile.Location = new System.Drawing.Point(7, 43);
            this.rdoOneFile.Name = "rdoOneFile";
            this.rdoOneFile.Size = new System.Drawing.Size(64, 17);
            this.rdoOneFile.TabIndex = 1;
            this.rdoOneFile.Text = "One File";
            this.rdoOneFile.UseVisualStyleBackColor = true;
            this.rdoOneFile.CheckedChanged += new System.EventHandler(this.rdoOneFile_CheckedChanged);
            // 
            // rdoNoFiles
            // 
            this.rdoNoFiles.AutoSize = true;
            this.rdoNoFiles.Checked = true;
            this.rdoNoFiles.Location = new System.Drawing.Point(6, 19);
            this.rdoNoFiles.Name = "rdoNoFiles";
            this.rdoNoFiles.Size = new System.Drawing.Size(63, 17);
            this.rdoNoFiles.TabIndex = 0;
            this.rdoNoFiles.TabStop = true;
            this.rdoNoFiles.Text = "No Files";
            this.rdoNoFiles.UseVisualStyleBackColor = true;
            this.rdoNoFiles.CheckedChanged += new System.EventHandler(this.rdoNoFiles_CheckedChanged);
            // 
            // tabResult
            // 
            this.tabResult.Controls.Add(this.btnCopyClipboard);
            this.tabResult.Controls.Add(this.btnSaveAs);
            this.tabResult.Controls.Add(this.txtResult);
            this.tabResult.Location = new System.Drawing.Point(4, 22);
            this.tabResult.Name = "tabResult";
            this.tabResult.Size = new System.Drawing.Size(775, 531);
            this.tabResult.TabIndex = 2;
            this.tabResult.Text = "Generated Script";
            this.tabResult.UseVisualStyleBackColor = true;
            // 
            // btnCopyClipboard
            // 
            this.btnCopyClipboard.Location = new System.Drawing.Point(3, 505);
            this.btnCopyClipboard.Name = "btnCopyClipboard";
            this.btnCopyClipboard.Size = new System.Drawing.Size(135, 23);
            this.btnCopyClipboard.TabIndex = 2;
            this.btnCopyClipboard.Text = "Copy to Clipboard";
            this.btnCopyClipboard.UseVisualStyleBackColor = true;
            this.btnCopyClipboard.Click += new System.EventHandler(this.btnCopyClipboard_Click);
            // 
            // btnSaveAs
            // 
            this.btnSaveAs.Enabled = false;
            this.btnSaveAs.Location = new System.Drawing.Point(144, 505);
            this.btnSaveAs.Name = "btnSaveAs";
            this.btnSaveAs.Size = new System.Drawing.Size(75, 23);
            this.btnSaveAs.TabIndex = 1;
            this.btnSaveAs.Text = "Save As...";
            this.btnSaveAs.UseVisualStyleBackColor = true;
            this.btnSaveAs.Click += new System.EventHandler(this.btnSaveAs_Click);
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(3, 3);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtResult.Size = new System.Drawing.Size(759, 496);
            this.txtResult.TabIndex = 0;
            this.txtResult.WordWrap = false;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(542, 587);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Exit";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnScript
            // 
            this.btnScript.Location = new System.Drawing.Point(461, 586);
            this.btnScript.Name = "btnScript";
            this.btnScript.Size = new System.Drawing.Size(75, 23);
            this.btnScript.TabIndex = 2;
            this.btnScript.Text = "Script";
            this.btnScript.UseVisualStyleBackColor = true;
            this.btnScript.Click += new System.EventHandler(this.btnScript_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripProgressBar1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 620);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(614, 26);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.AutoSize = false;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(300, 21);
            this.toolStripStatusLabel1.Text = "Ready";
            this.toolStripStatusLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(200, 20);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "sql";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(614, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.ShowShortcutKeys = false;
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(96, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // Scriptio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 646);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnScript);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.tabControl1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Scriptio";
            this.Text = "SQL-Scripter";
            this.Load += new System.EventHandler(this.Scriptio_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabObjects.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgAvailableObjects)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabOptions.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.tabResult.ResumeLayout(false);
            this.tabResult.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabObjects;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtServerName;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnScript;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkUseWindowsAuthentication;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.ComboBox ddlDatabases;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabResult;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.DataGridView dgAvailableObjects;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Script;
        private System.Windows.Forms.DataGridViewTextBoxColumn Schema;
        private System.Windows.Forms.DataGridViewTextBoxColumn Object;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.CheckBox chkIncludeHeaders;
        private System.Windows.Forms.CheckBox chkExistance;
        private System.Windows.Forms.CheckBox chkDrop;
        private System.Windows.Forms.CheckBox chkCreate;
        private System.Windows.Forms.CheckBox chkKeys;
        private System.Windows.Forms.CheckBox chkScriptAll;
        private System.Windows.Forms.CheckBox chkIndexes;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox ddlSchema;
        private System.Windows.Forms.ComboBox ddlType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button btnSaveAs;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TabPage tabOptions;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton rdoOnePerObject;
        private System.Windows.Forms.RadioButton rdoOneFile;
        private System.Windows.Forms.RadioButton rdoNoFiles;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnPickDirectory;
        private System.Windows.Forms.TextBox txtSaveLocation;
        private System.Windows.Forms.Button btnCopyClipboard;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.CheckBox chkCollation;
        private System.Windows.Forms.CheckBox chkSchemaQualifyCreates;
        private System.Windows.Forms.CheckBox chkSchemaQualifyDrops;
        private System.Windows.Forms.CheckBox chkSchemaQualifyFK;
        private System.Windows.Forms.CheckBox chkPermissions;

        
    }
}

