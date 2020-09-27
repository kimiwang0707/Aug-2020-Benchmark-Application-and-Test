namespace D201BenchmarkApp
{
    partial class Form
    {
        /// <summary>
        /// Neccesssary designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clear all using resources.
        /// </summary>
        /// <param name="disposing">If should release the managed resources, then "true", or "false".</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows codes produced by windows designer

        /// <summary>
        /// Designer support the methods needed - no change.
        /// Use code editor to change the contents of methods.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form));
            this.gbxLoadSort = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.SortZA = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.SortAZ = new System.Windows.Forms.Button();
            this.gbxSearchSave = new System.Windows.Forms.GroupBox();
            this.lblSalary = new System.Windows.Forms.Label();
            this.tbxSalary = new System.Windows.Forms.TextBox();
            this.tbxId = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.tbxBirthday = new System.Windows.Forms.TextBox();
            this.tbxEmail = new System.Windows.Forms.TextBox();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lbxSearchResults = new System.Windows.Forms.ListBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tbxSearch = new System.Windows.Forms.TextBox();
            this.mnsMenu = new System.Windows.Forms.MenuStrip();
            this.inputStaffInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadAndSortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sortAZToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sortZAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchAndSaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stsStatus = new System.Windows.Forms.StatusStrip();
            this.tslStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.ttpToolTips = new System.Windows.Forms.ToolTip(this.components);
            this.tbxSalaryInput = new System.Windows.Forms.TextBox();
            this.tbxIdInput = new System.Windows.Forms.TextBox();
            this.btnSaveInput = new System.Windows.Forms.Button();
            this.tbxEmailInput = new System.Windows.Forms.TextBox();
            this.tbxNameInput = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.gbxInput = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblSalaryInput = new System.Windows.Forms.Label();
            this.lblIdInput = new System.Windows.Forms.Label();
            this.lblEmailInput = new System.Windows.Forms.Label();
            this.lblBirthdayInput = new System.Windows.Forms.Label();
            this.lblNameInput = new System.Windows.Forms.Label();
            this.gbxLoadSort.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gbxSearchSave.SuspendLayout();
            this.mnsMenu.SuspendLayout();
            this.stsStatus.SuspendLayout();
            this.gbxInput.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxLoadSort
            // 
            this.gbxLoadSort.Controls.Add(this.dataGridView1);
            this.gbxLoadSort.Controls.Add(this.btnDelete);
            this.gbxLoadSort.Controls.Add(this.SortZA);
            this.gbxLoadSort.Controls.Add(this.btnLoad);
            this.gbxLoadSort.Controls.Add(this.SortAZ);
            this.gbxLoadSort.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxLoadSort.Location = new System.Drawing.Point(12, 272);
            this.gbxLoadSort.Name = "gbxLoadSort";
            this.gbxLoadSort.Size = new System.Drawing.Size(578, 367);
            this.gbxLoadSort.TabIndex = 0;
            this.gbxLoadSort.TabStop = false;
            this.gbxLoadSort.Text = "Load and Sort";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.Location = new System.Drawing.Point(10, 68);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(549, 293);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(113, 36);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(62, 23);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete";
            this.ttpToolTips.SetToolTip(this.btnDelete, "Delete selected creature");
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // SortZA
            // 
            this.SortZA.Location = new System.Drawing.Point(428, 36);
            this.SortZA.Name = "SortZA";
            this.SortZA.Size = new System.Drawing.Size(131, 23);
            this.SortZA.TabIndex = 3;
            this.SortZA.Text = "Descending by Name";
            this.ttpToolTips.SetToolTip(this.SortZA, "Sort creatures ZA");
            this.SortZA.UseVisualStyleBackColor = true;
            this.SortZA.Click += new System.EventHandler(this.SortZA_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(10, 36);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(62, 23);
            this.btnLoad.TabIndex = 1;
            this.btnLoad.Text = "Load";
            this.ttpToolTips.SetToolTip(this.btnLoad, "Loads a list of Creatures");
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // SortAZ
            // 
            this.SortAZ.Location = new System.Drawing.Point(237, 36);
            this.SortAZ.Name = "SortAZ";
            this.SortAZ.Size = new System.Drawing.Size(124, 23);
            this.SortAZ.TabIndex = 2;
            this.SortAZ.Text = "Ascending by Name";
            this.ttpToolTips.SetToolTip(this.SortAZ, "Sort creatures AZ");
            this.SortAZ.UseVisualStyleBackColor = true;
            this.SortAZ.Click += new System.EventHandler(this.SortAZ_Click);
            // 
            // gbxSearchSave
            // 
            this.gbxSearchSave.Controls.Add(this.lblSalary);
            this.gbxSearchSave.Controls.Add(this.tbxSalary);
            this.gbxSearchSave.Controls.Add(this.tbxId);
            this.gbxSearchSave.Controls.Add(this.lblId);
            this.gbxSearchSave.Controls.Add(this.btnSave);
            this.gbxSearchSave.Controls.Add(this.tbxBirthday);
            this.gbxSearchSave.Controls.Add(this.tbxEmail);
            this.gbxSearchSave.Controls.Add(this.tbxName);
            this.gbxSearchSave.Controls.Add(this.lblEmail);
            this.gbxSearchSave.Controls.Add(this.lblAge);
            this.gbxSearchSave.Controls.Add(this.lblName);
            this.gbxSearchSave.Controls.Add(this.lbxSearchResults);
            this.gbxSearchSave.Controls.Add(this.btnSearch);
            this.gbxSearchSave.Controls.Add(this.tbxSearch);
            this.gbxSearchSave.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxSearchSave.Location = new System.Drawing.Point(613, 38);
            this.gbxSearchSave.Name = "gbxSearchSave";
            this.gbxSearchSave.Size = new System.Drawing.Size(456, 601);
            this.gbxSearchSave.TabIndex = 1;
            this.gbxSearchSave.TabStop = false;
            this.gbxSearchSave.Text = "Search and Save";
            // 
            // lblSalary
            // 
            this.lblSalary.AutoSize = true;
            this.lblSalary.Location = new System.Drawing.Point(28, 539);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(42, 14);
            this.lblSalary.TabIndex = 13;
            this.lblSalary.Text = "Salary:";
            // 
            // tbxSalary
            // 
            this.tbxSalary.Location = new System.Drawing.Point(75, 534);
            this.tbxSalary.Name = "tbxSalary";
            this.tbxSalary.ReadOnly = true;
            this.tbxSalary.Size = new System.Drawing.Size(186, 22);
            this.tbxSalary.TabIndex = 12;
            this.ttpToolTips.SetToolTip(this.tbxSalary, "Salary of selected creature");
            // 
            // tbxId
            // 
            this.tbxId.Location = new System.Drawing.Point(74, 376);
            this.tbxId.Name = "tbxId";
            this.tbxId.ReadOnly = true;
            this.tbxId.Size = new System.Drawing.Size(187, 22);
            this.tbxId.TabIndex = 11;
            this.ttpToolTips.SetToolTip(this.tbxId, "Id of selected creature");
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(28, 379);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(22, 14);
            this.lblId.TabIndex = 10;
            this.lblId.Text = "ID:";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(356, 431);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(79, 70);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Save";
            this.ttpToolTips.SetToolTip(this.btnSave, "Save selected creature");
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tbxBirthday
            // 
            this.tbxBirthday.Location = new System.Drawing.Point(74, 456);
            this.tbxBirthday.Name = "tbxBirthday";
            this.tbxBirthday.ReadOnly = true;
            this.tbxBirthday.Size = new System.Drawing.Size(187, 22);
            this.tbxBirthday.TabIndex = 8;
            this.ttpToolTips.SetToolTip(this.tbxBirthday, "Age of selected creature");
            // 
            // tbxEmail
            // 
            this.tbxEmail.Location = new System.Drawing.Point(74, 494);
            this.tbxEmail.Name = "tbxEmail";
            this.tbxEmail.ReadOnly = true;
            this.tbxEmail.Size = new System.Drawing.Size(187, 22);
            this.tbxEmail.TabIndex = 7;
            this.ttpToolTips.SetToolTip(this.tbxEmail, "Email of selected creature");
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(74, 416);
            this.tbxName.Name = "tbxName";
            this.tbxName.ReadOnly = true;
            this.tbxName.Size = new System.Drawing.Size(187, 22);
            this.tbxName.TabIndex = 6;
            this.ttpToolTips.SetToolTip(this.tbxName, "Name of selected creature");
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(28, 497);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(39, 14);
            this.lblEmail.TabIndex = 5;
            this.lblEmail.Text = "Email:";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(28, 460);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(37, 14);
            this.lblAge.TabIndex = 4;
            this.lblAge.Text = "D.O.B:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(27, 419);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(40, 14);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Name:";
            // 
            // lbxSearchResults
            // 
            this.lbxSearchResults.FormattingEnabled = true;
            this.lbxSearchResults.ItemHeight = 14;
            this.lbxSearchResults.Location = new System.Drawing.Point(26, 61);
            this.lbxSearchResults.Name = "lbxSearchResults";
            this.lbxSearchResults.Size = new System.Drawing.Size(409, 270);
            this.lbxSearchResults.TabIndex = 2;
            this.ttpToolTips.SetToolTip(this.lbxSearchResults, "Displays a list of creatures");
            this.lbxSearchResults.SelectedIndexChanged += new System.EventHandler(this.lbxSearchResults_SelectedIndexChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(306, 20);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(86, 24);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search";
            this.ttpToolTips.SetToolTip(this.btnSearch, "Search creatures list");
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // tbxSearch
            // 
            this.tbxSearch.Location = new System.Drawing.Point(26, 22);
            this.tbxSearch.Name = "tbxSearch";
            this.tbxSearch.Size = new System.Drawing.Size(212, 22);
            this.tbxSearch.TabIndex = 0;
            this.ttpToolTips.SetToolTip(this.tbxSearch, "Enter a search term");
            // 
            // mnsMenu
            // 
            this.mnsMenu.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inputStaffInformationToolStripMenuItem,
            this.loadAndSortToolStripMenuItem,
            this.searchAndSaveToolStripMenuItem});
            this.mnsMenu.Location = new System.Drawing.Point(0, 0);
            this.mnsMenu.Name = "mnsMenu";
            this.mnsMenu.Size = new System.Drawing.Size(1091, 24);
            this.mnsMenu.TabIndex = 2;
            this.mnsMenu.Text = "menuStrip1";
            // 
            // inputStaffInformationToolStripMenuItem
            // 
            this.inputStaffInformationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.clearToolStripMenuItem});
            this.inputStaffInformationToolStripMenuItem.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputStaffInformationToolStripMenuItem.Name = "inputStaffInformationToolStripMenuItem";
            this.inputStaffInformationToolStripMenuItem.Size = new System.Drawing.Size(172, 20);
            this.inputStaffInformationToolStripMenuItem.Text = "Input Staff Information";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.addToolStripMenuItem.Text = "Add";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.btnSaveInput_Click);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.clearToolStripMenuItem.Text = "Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // loadAndSortToolStripMenuItem
            // 
            this.loadAndSortToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.sortAZToolStripMenuItem,
            this.sortZAToolStripMenuItem});
            this.loadAndSortToolStripMenuItem.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadAndSortToolStripMenuItem.Name = "loadAndSortToolStripMenuItem";
            this.loadAndSortToolStripMenuItem.Size = new System.Drawing.Size(111, 20);
            this.loadAndSortToolStripMenuItem.Text = "Load and Sort";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // sortAZToolStripMenuItem
            // 
            this.sortAZToolStripMenuItem.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sortAZToolStripMenuItem.Name = "sortAZToolStripMenuItem";
            this.sortAZToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.sortAZToolStripMenuItem.Text = "Ascending by Name";
            this.sortAZToolStripMenuItem.Click += new System.EventHandler(this.SortAZ_Click);
            // 
            // sortZAToolStripMenuItem
            // 
            this.sortZAToolStripMenuItem.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sortZAToolStripMenuItem.Name = "sortZAToolStripMenuItem";
            this.sortZAToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.sortZAToolStripMenuItem.Text = "Descending by Name";
            this.sortZAToolStripMenuItem.Click += new System.EventHandler(this.SortZA_Click);
            // 
            // searchAndSaveToolStripMenuItem
            // 
            this.searchAndSaveToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.searchAndSaveToolStripMenuItem.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchAndSaveToolStripMenuItem.Name = "searchAndSaveToolStripMenuItem";
            this.searchAndSaveToolStripMenuItem.Size = new System.Drawing.Size(130, 20);
            this.searchAndSaveToolStripMenuItem.Text = "Search and Save";
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.searchToolStripMenuItem.Text = "Search";
            this.searchToolStripMenuItem.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // stsStatus
            // 
            this.stsStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslStatus});
            this.stsStatus.Location = new System.Drawing.Point(0, 654);
            this.stsStatus.Name = "stsStatus";
            this.stsStatus.Size = new System.Drawing.Size(1091, 22);
            this.stsStatus.TabIndex = 3;
            this.stsStatus.Text = "statusStrip1";
            // 
            // tslStatus
            // 
            this.tslStatus.Name = "tslStatus";
            this.tslStatus.Size = new System.Drawing.Size(44, 17);
            this.tslStatus.Text = "Ready";
            // 
            // tbxSalaryInput
            // 
            this.tbxSalaryInput.Location = new System.Drawing.Point(83, 175);
            this.tbxSalaryInput.Name = "tbxSalaryInput";
            this.tbxSalaryInput.Size = new System.Drawing.Size(239, 22);
            this.tbxSalaryInput.TabIndex = 12;
            this.ttpToolTips.SetToolTip(this.tbxSalaryInput, "Input Salary");
            // 
            // tbxIdInput
            // 
            this.tbxIdInput.Location = new System.Drawing.Point(83, 30);
            this.tbxIdInput.Name = "tbxIdInput";
            this.tbxIdInput.Size = new System.Drawing.Size(239, 22);
            this.tbxIdInput.TabIndex = 11;
            this.ttpToolTips.SetToolTip(this.tbxIdInput, "Input Id");
            // 
            // btnSaveInput
            // 
            this.btnSaveInput.Location = new System.Drawing.Point(407, 70);
            this.btnSaveInput.Name = "btnSaveInput";
            this.btnSaveInput.Size = new System.Drawing.Size(112, 35);
            this.btnSaveInput.TabIndex = 9;
            this.btnSaveInput.Text = "Add";
            this.ttpToolTips.SetToolTip(this.btnSaveInput, "Add a new staff");
            this.btnSaveInput.UseVisualStyleBackColor = true;
            this.btnSaveInput.Click += new System.EventHandler(this.btnSaveInput_Click);
            // 
            // tbxEmailInput
            // 
            this.tbxEmailInput.Location = new System.Drawing.Point(83, 142);
            this.tbxEmailInput.Name = "tbxEmailInput";
            this.tbxEmailInput.Size = new System.Drawing.Size(239, 22);
            this.tbxEmailInput.TabIndex = 7;
            this.ttpToolTips.SetToolTip(this.tbxEmailInput, "Input Email");
            // 
            // tbxNameInput
            // 
            this.tbxNameInput.Location = new System.Drawing.Point(83, 67);
            this.tbxNameInput.Name = "tbxNameInput";
            this.tbxNameInput.Size = new System.Drawing.Size(239, 22);
            this.tbxNameInput.TabIndex = 6;
            this.ttpToolTips.SetToolTip(this.tbxNameInput, "Input Name");
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(407, 129);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(112, 34);
            this.btnClear.TabIndex = 15;
            this.btnClear.Text = "Clear";
            this.ttpToolTips.SetToolTip(this.btnClear, "Clear the screen");
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // gbxInput
            // 
            this.gbxInput.Controls.Add(this.btnClear);
            this.gbxInput.Controls.Add(this.dateTimePicker1);
            this.gbxInput.Controls.Add(this.lblSalaryInput);
            this.gbxInput.Controls.Add(this.tbxSalaryInput);
            this.gbxInput.Controls.Add(this.tbxIdInput);
            this.gbxInput.Controls.Add(this.lblIdInput);
            this.gbxInput.Controls.Add(this.btnSaveInput);
            this.gbxInput.Controls.Add(this.tbxEmailInput);
            this.gbxInput.Controls.Add(this.tbxNameInput);
            this.gbxInput.Controls.Add(this.lblEmailInput);
            this.gbxInput.Controls.Add(this.lblBirthdayInput);
            this.gbxInput.Controls.Add(this.lblNameInput);
            this.gbxInput.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxInput.Location = new System.Drawing.Point(12, 38);
            this.gbxInput.Name = "gbxInput";
            this.gbxInput.Size = new System.Drawing.Size(578, 216);
            this.gbxInput.TabIndex = 4;
            this.gbxInput.TabStop = false;
            this.gbxInput.Text = "Input Staff Information";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd-MM-yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(83, 103);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(239, 22);
            this.dateTimePicker1.TabIndex = 14;
            // 
            // lblSalaryInput
            // 
            this.lblSalaryInput.AutoSize = true;
            this.lblSalaryInput.Location = new System.Drawing.Point(15, 178);
            this.lblSalaryInput.Name = "lblSalaryInput";
            this.lblSalaryInput.Size = new System.Drawing.Size(42, 14);
            this.lblSalaryInput.TabIndex = 13;
            this.lblSalaryInput.Text = "Salary:";
            // 
            // lblIdInput
            // 
            this.lblIdInput.AutoSize = true;
            this.lblIdInput.Location = new System.Drawing.Point(16, 33);
            this.lblIdInput.Name = "lblIdInput";
            this.lblIdInput.Size = new System.Drawing.Size(22, 14);
            this.lblIdInput.TabIndex = 10;
            this.lblIdInput.Text = "ID:";
            // 
            // lblEmailInput
            // 
            this.lblEmailInput.AutoSize = true;
            this.lblEmailInput.Location = new System.Drawing.Point(16, 145);
            this.lblEmailInput.Name = "lblEmailInput";
            this.lblEmailInput.Size = new System.Drawing.Size(39, 14);
            this.lblEmailInput.TabIndex = 5;
            this.lblEmailInput.Text = "Email:";
            // 
            // lblBirthdayInput
            // 
            this.lblBirthdayInput.AutoSize = true;
            this.lblBirthdayInput.Location = new System.Drawing.Point(16, 109);
            this.lblBirthdayInput.Name = "lblBirthdayInput";
            this.lblBirthdayInput.Size = new System.Drawing.Size(37, 14);
            this.lblBirthdayInput.TabIndex = 4;
            this.lblBirthdayInput.Text = "D.O.B:";
            // 
            // lblNameInput
            // 
            this.lblNameInput.AutoSize = true;
            this.lblNameInput.Location = new System.Drawing.Point(15, 70);
            this.lblNameInput.Name = "lblNameInput";
            this.lblNameInput.Size = new System.Drawing.Size(40, 14);
            this.lblNameInput.TabIndex = 3;
            this.lblNameInput.Text = "Name:";
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1091, 676);
            this.Controls.Add(this.gbxInput);
            this.Controls.Add(this.stsStatus);
            this.Controls.Add(this.gbxSearchSave);
            this.Controls.Add(this.gbxLoadSort);
            this.Controls.Add(this.mnsMenu);
            this.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mnsMenu;
            this.Name = "Form";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Whitireia Staff Management System";
            this.Load += new System.EventHandler(this.Form_Load);
            this.gbxLoadSort.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gbxSearchSave.ResumeLayout(false);
            this.gbxSearchSave.PerformLayout();
            this.mnsMenu.ResumeLayout(false);
            this.mnsMenu.PerformLayout();
            this.stsStatus.ResumeLayout(false);
            this.stsStatus.PerformLayout();
            this.gbxInput.ResumeLayout(false);
            this.gbxInput.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
   

        #endregion

        private System.Windows.Forms.GroupBox gbxLoadSort;
        private System.Windows.Forms.Button SortZA;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button SortAZ;
        private System.Windows.Forms.GroupBox gbxSearchSave;
        private System.Windows.Forms.ListBox lbxSearchResults;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox tbxSearch;
        private System.Windows.Forms.ToolTip ttpToolTips;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox tbxBirthday;
        private System.Windows.Forms.TextBox tbxEmail;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.MenuStrip mnsMenu;
        private System.Windows.Forms.ToolStripMenuItem loadAndSortToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sortAZToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sortZAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchAndSaveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.StatusStrip stsStatus;
        private System.Windows.Forms.ToolStripStatusLabel tslStatus;
        private System.Windows.Forms.TextBox tbxId;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblSalary;
        private System.Windows.Forms.TextBox tbxSalary;
        private System.Windows.Forms.GroupBox gbxInput;
        private System.Windows.Forms.Label lblSalaryInput;
        private System.Windows.Forms.TextBox tbxSalaryInput;
        private System.Windows.Forms.TextBox tbxIdInput;
        private System.Windows.Forms.Label lblIdInput;
        private System.Windows.Forms.Button btnSaveInput;
        private System.Windows.Forms.TextBox tbxEmailInput;
        private System.Windows.Forms.TextBox tbxNameInput;
        private System.Windows.Forms.Label lblEmailInput;
        private System.Windows.Forms.Label lblBirthdayInput;
        private System.Windows.Forms.Label lblNameInput;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ToolStripMenuItem inputStaffInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
    }
}

