namespace BEXU
{
    partial class frmMain
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
            this.tabs = new System.Windows.Forms.TabControl();
            this.tabLogin = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLogIn = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtURL = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.tabSearch = new System.Windows.Forms.TabPage();
            this.btnSelect = new System.Windows.Forms.Button();
            this.lblFilterLabelSearch = new System.Windows.Forms.Label();
            this.txtSearchOverResult = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.colIsSelected = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colFolderName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnClearList = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtFileLike = new System.Windows.Forms.TextBox();
            this.txtFolderLike = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabProcess = new System.Windows.Forms.TabPage();
            this.listProcessesToPerform = new System.Windows.Forms.ListBox();
            this.listAvailableProcesses = new System.Windows.Forms.ListBox();
            this.btnProcess = new System.Windows.Forms.Button();
            this.lblFilterLabelSelection = new System.Windows.Forms.Label();
            this.txtSearchOverResultSelection = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridSelection = new System.Windows.Forms.DataGridView();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnRemoveProcessToPerform = new System.Windows.Forms.Button();
            this.btnAddProcessToPerform = new System.Windows.Forms.Button();
            this.btnClearListSelection = new System.Windows.Forms.Button();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.tabs.SuspendLayout();
            this.tabLogin.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabSearch.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.tabProcess.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSelection)).BeginInit();
            this.SuspendLayout();
            // 
            // tabs
            // 
            this.tabs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabs.Controls.Add(this.tabLogin);
            this.tabs.Controls.Add(this.tabSearch);
            this.tabs.Controls.Add(this.tabProcess);
            this.tabs.Location = new System.Drawing.Point(12, 12);
            this.tabs.Name = "tabs";
            this.tabs.SelectedIndex = 0;
            this.tabs.Size = new System.Drawing.Size(782, 427);
            this.tabs.TabIndex = 0;
            // 
            // tabLogin
            // 
            this.tabLogin.Controls.Add(this.panel1);
            this.tabLogin.Location = new System.Drawing.Point(4, 22);
            this.tabLogin.Name = "tabLogin";
            this.tabLogin.Padding = new System.Windows.Forms.Padding(3);
            this.tabLogin.Size = new System.Drawing.Size(774, 401);
            this.tabLogin.TabIndex = 0;
            this.tabLogin.Text = "1. Login";
            this.tabLogin.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnLogIn);
            this.panel1.Controls.Add(this.txtPassword);
            this.panel1.Controls.Add(this.txtURL);
            this.panel1.Controls.Add(this.txtUserName);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblName);
            this.panel1.Location = new System.Drawing.Point(6, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(585, 194);
            this.panel1.TabIndex = 4;
            // 
            // btnLogIn
            // 
            this.btnLogIn.Location = new System.Drawing.Point(21, 159);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(81, 23);
            this.btnLogIn.TabIndex = 10;
            this.btnLogIn.Text = "Log In";
            this.btnLogIn.UseVisualStyleBackColor = true;
            this.btnLogIn.Click += new System.EventHandler(this.btnLogIn_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(21, 133);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(160, 20);
            this.txtPassword.TabIndex = 7;
            this.txtPassword.Text = "Alfa0210";
            // 
            // txtURL
            // 
            this.txtURL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtURL.Location = new System.Drawing.Point(21, 36);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(546, 20);
            this.txtURL.TabIndex = 8;
            this.txtURL.Text = "http://sharepoint.capsonic.com/ISIT/IQST";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(21, 94);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(160, 20);
            this.txtUserName.TabIndex = 9;
            this.txtUserName.Text = "apacheco";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Site URL";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Password";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(18, 78);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(60, 13);
            this.lblName.TabIndex = 5;
            this.lblName.Text = "User Name";
            // 
            // tabSearch
            // 
            this.tabSearch.Controls.Add(this.btnSelect);
            this.tabSearch.Controls.Add(this.lblFilterLabelSearch);
            this.tabSearch.Controls.Add(this.txtSearchOverResult);
            this.tabSearch.Controls.Add(this.label5);
            this.tabSearch.Controls.Add(this.panel2);
            this.tabSearch.Controls.Add(this.btnClearList);
            this.tabSearch.Controls.Add(this.progressBar);
            this.tabSearch.Controls.Add(this.btnSearch);
            this.tabSearch.Controls.Add(this.txtFileLike);
            this.tabSearch.Controls.Add(this.txtFolderLike);
            this.tabSearch.Controls.Add(this.label3);
            this.tabSearch.Controls.Add(this.label4);
            this.tabSearch.Location = new System.Drawing.Point(4, 22);
            this.tabSearch.Name = "tabSearch";
            this.tabSearch.Padding = new System.Windows.Forms.Padding(3);
            this.tabSearch.Size = new System.Drawing.Size(774, 401);
            this.tabSearch.TabIndex = 1;
            this.tabSearch.Text = "2. Search";
            this.tabSearch.UseVisualStyleBackColor = true;
            // 
            // btnSelect
            // 
            this.btnSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelect.Location = new System.Drawing.Point(687, 372);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(81, 23);
            this.btnSelect.TabIndex = 30;
            this.btnSelect.Text = "Select";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // lblFilterLabelSearch
            // 
            this.lblFilterLabelSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFilterLabelSearch.Location = new System.Drawing.Point(484, 96);
            this.lblFilterLabelSearch.Name = "lblFilterLabelSearch";
            this.lblFilterLabelSearch.Size = new System.Drawing.Size(197, 18);
            this.lblFilterLabelSearch.TabIndex = 28;
            this.lblFilterLabelSearch.Text = "Showing 0 entries from 0";
            this.lblFilterLabelSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtSearchOverResult
            // 
            this.txtSearchOverResult.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearchOverResult.Location = new System.Drawing.Point(523, 68);
            this.txtSearchOverResult.Name = "txtSearchOverResult";
            this.txtSearchOverResult.Size = new System.Drawing.Size(245, 20);
            this.txtSearchOverResult.TabIndex = 27;
            this.txtSearchOverResult.TextChanged += new System.EventHandler(this.txtSearchOverResult_TextChanged);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(520, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Search over result";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.dataGrid);
            this.panel2.Location = new System.Drawing.Point(9, 123);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(759, 243);
            this.panel2.TabIndex = 25;
            // 
            // dataGrid
            // 
            this.dataGrid.AllowUserToAddRows = false;
            this.dataGrid.AllowUserToDeleteRows = false;
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIsSelected,
            this.colFolderName,
            this.colFileName,
            this.colStatus});
            this.dataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGrid.Location = new System.Drawing.Point(0, 0);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.RowHeadersVisible = false;
            this.dataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGrid.Size = new System.Drawing.Size(759, 243);
            this.dataGrid.TabIndex = 0;
            // 
            // colIsSelected
            // 
            this.colIsSelected.DataPropertyName = "IsSelected";
            this.colIsSelected.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colIsSelected.HeaderText = "Select";
            this.colIsSelected.Name = "colIsSelected";
            // 
            // colFolderName
            // 
            this.colFolderName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colFolderName.DataPropertyName = "FolderName";
            this.colFolderName.HeaderText = "Folder Name";
            this.colFolderName.Name = "colFolderName";
            this.colFolderName.ReadOnly = true;
            // 
            // colFileName
            // 
            this.colFileName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colFileName.DataPropertyName = "FileName";
            this.colFileName.HeaderText = "File Name";
            this.colFileName.Name = "colFileName";
            this.colFileName.ReadOnly = true;
            // 
            // colStatus
            // 
            this.colStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colStatus.DataPropertyName = "Status";
            this.colStatus.HeaderText = "Status";
            this.colStatus.Name = "colStatus";
            this.colStatus.ReadOnly = true;
            // 
            // btnClearList
            // 
            this.btnClearList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClearList.Location = new System.Drawing.Point(687, 93);
            this.btnClearList.Name = "btnClearList";
            this.btnClearList.Size = new System.Drawing.Size(81, 23);
            this.btnClearList.TabIndex = 24;
            this.btnClearList.Text = "Clear";
            this.btnClearList.UseVisualStyleBackColor = true;
            this.btnClearList.Click += new System.EventHandler(this.btnClearListSearch_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(96, 94);
            this.progressBar.MarqueeAnimationSpeed = 1;
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(86, 23);
            this.progressBar.TabIndex = 23;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(9, 94);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(81, 23);
            this.btnSearch.TabIndex = 22;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtFileLike
            // 
            this.txtFileLike.Location = new System.Drawing.Point(9, 68);
            this.txtFileLike.Name = "txtFileLike";
            this.txtFileLike.Size = new System.Drawing.Size(245, 20);
            this.txtFileLike.TabIndex = 20;
            // 
            // txtFolderLike
            // 
            this.txtFolderLike.Location = new System.Drawing.Point(9, 29);
            this.txtFolderLike.Name = "txtFolderLike";
            this.txtFolderLike.Size = new System.Drawing.Size(245, 20);
            this.txtFolderLike.TabIndex = 21;
            this.txtFolderLike.Text = "Traveler";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "File Like";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Folder Like";
            // 
            // tabProcess
            // 
            this.tabProcess.Controls.Add(this.listProcessesToPerform);
            this.tabProcess.Controls.Add(this.listAvailableProcesses);
            this.tabProcess.Controls.Add(this.btnProcess);
            this.tabProcess.Controls.Add(this.lblFilterLabelSelection);
            this.tabProcess.Controls.Add(this.txtSearchOverResultSelection);
            this.tabProcess.Controls.Add(this.label8);
            this.tabProcess.Controls.Add(this.label6);
            this.tabProcess.Controls.Add(this.label7);
            this.tabProcess.Controls.Add(this.panel3);
            this.tabProcess.Controls.Add(this.btnRemoveProcessToPerform);
            this.tabProcess.Controls.Add(this.btnAddProcessToPerform);
            this.tabProcess.Controls.Add(this.btnClearListSelection);
            this.tabProcess.Location = new System.Drawing.Point(4, 22);
            this.tabProcess.Name = "tabProcess";
            this.tabProcess.Padding = new System.Windows.Forms.Padding(3);
            this.tabProcess.Size = new System.Drawing.Size(774, 401);
            this.tabProcess.TabIndex = 2;
            this.tabProcess.Text = "3. Process";
            this.tabProcess.UseVisualStyleBackColor = true;
            // 
            // listProcessesToPerform
            // 
            this.listProcessesToPerform.DisplayMember = "Title";
            this.listProcessesToPerform.FormattingEnabled = true;
            this.listProcessesToPerform.Location = new System.Drawing.Point(261, 19);
            this.listProcessesToPerform.MultiColumn = true;
            this.listProcessesToPerform.Name = "listProcessesToPerform";
            this.listProcessesToPerform.Size = new System.Drawing.Size(203, 95);
            this.listProcessesToPerform.TabIndex = 41;
            this.listProcessesToPerform.DoubleClick += new System.EventHandler(this.listProcessesToPerform_DoubleClick);
            // 
            // listAvailableProcesses
            // 
            this.listAvailableProcesses.DisplayMember = "Title";
            this.listAvailableProcesses.FormattingEnabled = true;
            this.listAvailableProcesses.Location = new System.Drawing.Point(9, 19);
            this.listAvailableProcesses.Name = "listAvailableProcesses";
            this.listAvailableProcesses.Size = new System.Drawing.Size(203, 95);
            this.listAvailableProcesses.TabIndex = 41;
            // 
            // btnProcess
            // 
            this.btnProcess.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnProcess.Location = new System.Drawing.Point(9, 372);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(81, 23);
            this.btnProcess.TabIndex = 40;
            this.btnProcess.Text = "Process";
            this.btnProcess.UseVisualStyleBackColor = true;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // lblFilterLabelSelection
            // 
            this.lblFilterLabelSelection.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFilterLabelSelection.Location = new System.Drawing.Point(463, 96);
            this.lblFilterLabelSelection.Name = "lblFilterLabelSelection";
            this.lblFilterLabelSelection.Size = new System.Drawing.Size(218, 18);
            this.lblFilterLabelSelection.TabIndex = 39;
            this.lblFilterLabelSelection.Text = "Showing 0 entries from 0";
            this.lblFilterLabelSelection.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtSearchOverResultSelection
            // 
            this.txtSearchOverResultSelection.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearchOverResultSelection.Location = new System.Drawing.Point(523, 68);
            this.txtSearchOverResultSelection.Name = "txtSearchOverResultSelection";
            this.txtSearchOverResultSelection.Size = new System.Drawing.Size(245, 20);
            this.txtSearchOverResultSelection.TabIndex = 38;
            this.txtSearchOverResultSelection.TextChanged += new System.EventHandler(this.txtSearchOverResultSelection_TextChanged);
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(258, 3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 13);
            this.label8.TabIndex = 37;
            this.label8.Text = "Processes To Perform";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 13);
            this.label6.TabIndex = 37;
            this.label6.Text = "Available Processes";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(520, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 13);
            this.label7.TabIndex = 37;
            this.label7.Text = "Search over result";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.dataGridSelection);
            this.panel3.Location = new System.Drawing.Point(9, 123);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(759, 243);
            this.panel3.TabIndex = 36;
            // 
            // dataGridSelection
            // 
            this.dataGridSelection.AllowUserToAddRows = false;
            this.dataGridSelection.AllowUserToDeleteRows = false;
            this.dataGridSelection.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridSelection.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.dataGridSelection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridSelection.Location = new System.Drawing.Point(0, 0);
            this.dataGridSelection.Name = "dataGridSelection";
            this.dataGridSelection.RowHeadersVisible = false;
            this.dataGridSelection.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridSelection.Size = new System.Drawing.Size(759, 243);
            this.dataGridSelection.TabIndex = 0;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "IsSelected";
            this.dataGridViewCheckBoxColumn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dataGridViewCheckBoxColumn1.HeaderText = "Select";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "FolderName";
            this.dataGridViewTextBoxColumn1.HeaderText = "Folder Name";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "FileName";
            this.dataGridViewTextBoxColumn2.HeaderText = "File Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Status";
            this.dataGridViewTextBoxColumn3.HeaderText = "Status";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // btnRemoveProcessToPerform
            // 
            this.btnRemoveProcessToPerform.Location = new System.Drawing.Point(218, 71);
            this.btnRemoveProcessToPerform.Name = "btnRemoveProcessToPerform";
            this.btnRemoveProcessToPerform.Size = new System.Drawing.Size(37, 23);
            this.btnRemoveProcessToPerform.TabIndex = 35;
            this.btnRemoveProcessToPerform.Text = "<";
            this.btnRemoveProcessToPerform.UseVisualStyleBackColor = true;
            this.btnRemoveProcessToPerform.Click += new System.EventHandler(this.btnRemoveProcessToPerform_Click);
            // 
            // btnAddProcessToPerform
            // 
            this.btnAddProcessToPerform.Location = new System.Drawing.Point(218, 42);
            this.btnAddProcessToPerform.Name = "btnAddProcessToPerform";
            this.btnAddProcessToPerform.Size = new System.Drawing.Size(37, 23);
            this.btnAddProcessToPerform.TabIndex = 35;
            this.btnAddProcessToPerform.Text = ">";
            this.btnAddProcessToPerform.UseVisualStyleBackColor = true;
            this.btnAddProcessToPerform.Click += new System.EventHandler(this.btnAddProcessToPerform_Click);
            // 
            // btnClearListSelection
            // 
            this.btnClearListSelection.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClearListSelection.Location = new System.Drawing.Point(687, 94);
            this.btnClearListSelection.Name = "btnClearListSelection";
            this.btnClearListSelection.Size = new System.Drawing.Size(81, 23);
            this.btnClearListSelection.TabIndex = 35;
            this.btnClearListSelection.Text = "Reset";
            this.btnClearListSelection.UseVisualStyleBackColor = true;
            this.btnClearListSelection.Click += new System.EventHandler(this.btnClearListSelection_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 451);
            this.Controls.Add(this.tabs);
            this.Name = "frmMain";
            this.Text = "Bulk Excel Updates";
            this.tabs.ResumeLayout(false);
            this.tabLogin.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabSearch.ResumeLayout(false);
            this.tabSearch.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.tabProcess.ResumeLayout(false);
            this.tabProcess.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSelection)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabs;
        private System.Windows.Forms.TabPage tabLogin;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLogIn;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtURL;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TabPage tabSearch;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.Button btnClearList;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtFileLike;
        private System.Windows.Forms.TextBox txtFolderLike;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSearchOverResult;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.Label lblFilterLabelSearch;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colIsSelected;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFolderName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFileName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
        private System.Windows.Forms.TabPage tabProcess;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Label lblFilterLabelSelection;
        private System.Windows.Forms.TextBox txtSearchOverResultSelection;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGridSelection;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Button btnClearListSelection;
        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.ListBox listProcessesToPerform;
        private System.Windows.Forms.ListBox listAvailableProcesses;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnRemoveProcessToPerform;
        private System.Windows.Forms.Button btnAddProcessToPerform;
    }
}

