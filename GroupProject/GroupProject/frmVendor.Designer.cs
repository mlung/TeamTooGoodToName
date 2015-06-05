partial class frmVendor
{
    #region Windows Form Designer generated code

    private void InitializeComponent()
    {
            this.mnuVendors = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileOpenVendor = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileExitVendor = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.howToUseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lstVendor = new System.Windows.Forms.ListBox();
            this.btnVendorExit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClearVendor = new System.Windows.Forms.Button();
            this.btnDeleteVendor = new System.Windows.Forms.Button();
            this.btnUpdateVendor = new System.Windows.Forms.Button();
            this.btnAddVendor = new System.Windows.Forms.Button();
            this.txtStoreCity = new System.Windows.Forms.TextBox();
            this.txtStoreName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtStoreState = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnWebsite = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtStoreWebsite = new System.Windows.Forms.TextBox();
            this.btnSort = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnUndoSearch = new System.Windows.Forms.Button();
            this.mnuVendors.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuVendors
            // 
            this.mnuVendors.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.mnuVendors.Location = new System.Drawing.Point(0, 0);
            this.mnuVendors.Name = "mnuVendors";
            this.mnuVendors.Size = new System.Drawing.Size(716, 24);
            this.mnuVendors.TabIndex = 2;
            this.mnuVendors.Text = "Vendors Menu";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFileOpenVendor,
            this.mnuFileExitVendor});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // mnuFileOpenVendor
            // 
            this.mnuFileOpenVendor.Name = "mnuFileOpenVendor";
            this.mnuFileOpenVendor.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.mnuFileOpenVendor.Size = new System.Drawing.Size(146, 22);
            this.mnuFileOpenVendor.Text = "Open";
            this.mnuFileOpenVendor.Click += new System.EventHandler(this.mnuFileOpenVendor_Click);
            // 
            // mnuFileExitVendor
            // 
            this.mnuFileExitVendor.Name = "mnuFileExitVendor";
            this.mnuFileExitVendor.Size = new System.Drawing.Size(146, 22);
            this.mnuFileExitVendor.Text = "Exit";
            this.mnuFileExitVendor.Click += new System.EventHandler(this.mnuFileExitVendor_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.howToUseToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // howToUseToolStripMenuItem
            // 
            this.howToUseToolStripMenuItem.Name = "howToUseToolStripMenuItem";
            this.howToUseToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.howToUseToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.howToUseToolStripMenuItem.Text = "How to Use";
            this.howToUseToolStripMenuItem.Click += new System.EventHandler(this.howToUseToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // lstVendor
            // 
            this.lstVendor.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstVendor.FormattingEnabled = true;
            this.lstVendor.Location = new System.Drawing.Point(12, 37);
            this.lstVendor.Name = "lstVendor";
            this.lstVendor.Size = new System.Drawing.Size(421, 238);
            this.lstVendor.TabIndex = 0;
            this.lstVendor.SelectedIndexChanged += new System.EventHandler(this.lstVendor_SelectedIndexChanged_1);
            // 
            // btnVendorExit
            // 
            this.btnVendorExit.BackColor = System.Drawing.Color.LimeGreen;
            this.btnVendorExit.ForeColor = System.Drawing.Color.White;
            this.btnVendorExit.Location = new System.Drawing.Point(582, 282);
            this.btnVendorExit.Name = "btnVendorExit";
            this.btnVendorExit.Size = new System.Drawing.Size(75, 23);
            this.btnVendorExit.TabIndex = 37;
            this.btnVendorExit.Text = "&Exit";
            this.btnVendorExit.UseVisualStyleBackColor = false;
            this.btnVendorExit.Click += new System.EventHandler(this.btnVendorExit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LimeGreen;
            this.label2.Location = new System.Drawing.Point(442, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 37;
            this.label2.Text = "Store City:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LimeGreen;
            this.label1.Location = new System.Drawing.Point(442, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 36;
            this.label1.Text = "Store Name:";
            // 
            // btnClearVendor
            // 
            this.btnClearVendor.BackColor = System.Drawing.Color.LimeGreen;
            this.btnClearVendor.ForeColor = System.Drawing.Color.White;
            this.btnClearVendor.Location = new System.Drawing.Point(627, 253);
            this.btnClearVendor.Name = "btnClearVendor";
            this.btnClearVendor.Size = new System.Drawing.Size(75, 23);
            this.btnClearVendor.TabIndex = 36;
            this.btnClearVendor.Text = "&Clear";
            this.btnClearVendor.UseVisualStyleBackColor = false;
            this.btnClearVendor.Click += new System.EventHandler(this.btnClearVendor_Click);
            // 
            // btnDeleteVendor
            // 
            this.btnDeleteVendor.BackColor = System.Drawing.Color.LimeGreen;
            this.btnDeleteVendor.ForeColor = System.Drawing.Color.White;
            this.btnDeleteVendor.Location = new System.Drawing.Point(627, 224);
            this.btnDeleteVendor.Name = "btnDeleteVendor";
            this.btnDeleteVendor.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteVendor.TabIndex = 35;
            this.btnDeleteVendor.Text = "&Delete";
            this.btnDeleteVendor.UseVisualStyleBackColor = false;
            this.btnDeleteVendor.Click += new System.EventHandler(this.btnDeleteVendor_Click);
            // 
            // btnUpdateVendor
            // 
            this.btnUpdateVendor.BackColor = System.Drawing.Color.LimeGreen;
            this.btnUpdateVendor.ForeColor = System.Drawing.Color.White;
            this.btnUpdateVendor.Location = new System.Drawing.Point(627, 196);
            this.btnUpdateVendor.Name = "btnUpdateVendor";
            this.btnUpdateVendor.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateVendor.TabIndex = 34;
            this.btnUpdateVendor.Text = "&Update";
            this.btnUpdateVendor.UseVisualStyleBackColor = false;
            this.btnUpdateVendor.Click += new System.EventHandler(this.btnUpdateVendor_Click);
            // 
            // btnAddVendor
            // 
            this.btnAddVendor.BackColor = System.Drawing.Color.LimeGreen;
            this.btnAddVendor.ForeColor = System.Drawing.Color.White;
            this.btnAddVendor.Location = new System.Drawing.Point(539, 196);
            this.btnAddVendor.Name = "btnAddVendor";
            this.btnAddVendor.Size = new System.Drawing.Size(75, 23);
            this.btnAddVendor.TabIndex = 33;
            this.btnAddVendor.Text = "&Add";
            this.btnAddVendor.UseVisualStyleBackColor = false;
            this.btnAddVendor.Click += new System.EventHandler(this.btnAddVendor_Click);
            // 
            // txtStoreCity
            // 
            this.txtStoreCity.Location = new System.Drawing.Point(539, 108);
            this.txtStoreCity.Name = "txtStoreCity";
            this.txtStoreCity.Size = new System.Drawing.Size(163, 20);
            this.txtStoreCity.TabIndex = 31;
            this.txtStoreCity.UseWaitCursor = true;
            // 
            // txtStoreName
            // 
            this.txtStoreName.Location = new System.Drawing.Point(539, 82);
            this.txtStoreName.Name = "txtStoreName";
            this.txtStoreName.Size = new System.Drawing.Size(163, 20);
            this.txtStoreName.TabIndex = 30;
            this.txtStoreName.UseWaitCursor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.LimeGreen;
            this.label3.Location = new System.Drawing.Point(516, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 33);
            this.label3.TabIndex = 39;
            this.label3.Text = "VENDOR";
            // 
            // txtStoreState
            // 
            this.txtStoreState.Location = new System.Drawing.Point(539, 135);
            this.txtStoreState.Name = "txtStoreState";
            this.txtStoreState.Size = new System.Drawing.Size(163, 20);
            this.txtStoreState.TabIndex = 32;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.LimeGreen;
            this.label4.Location = new System.Drawing.Point(442, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 41;
            this.label4.Text = "Store State:";
            // 
            // btnWebsite
            // 
            this.btnWebsite.BackColor = System.Drawing.Color.LimeGreen;
            this.btnWebsite.ForeColor = System.Drawing.Color.White;
            this.btnWebsite.Location = new System.Drawing.Point(539, 253);
            this.btnWebsite.Name = "btnWebsite";
            this.btnWebsite.Size = new System.Drawing.Size(75, 23);
            this.btnWebsite.TabIndex = 42;
            this.btnWebsite.Text = "&Website";
            this.btnWebsite.UseVisualStyleBackColor = false;
            this.btnWebsite.Click += new System.EventHandler(this.btnWebsite_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.LimeGreen;
            this.label5.Location = new System.Drawing.Point(442, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 43;
            this.label5.Text = "Store Website:";
            // 
            // txtStoreWebsite
            // 
            this.txtStoreWebsite.Location = new System.Drawing.Point(539, 162);
            this.txtStoreWebsite.Name = "txtStoreWebsite";
            this.txtStoreWebsite.Size = new System.Drawing.Size(163, 20);
            this.txtStoreWebsite.TabIndex = 44;
            // 
            // btnSort
            // 
            this.btnSort.BackColor = System.Drawing.Color.LimeGreen;
            this.btnSort.ForeColor = System.Drawing.Color.White;
            this.btnSort.Location = new System.Drawing.Point(539, 224);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(75, 23);
            this.btnSort.TabIndex = 45;
            this.btnSort.Text = "Sort &Name";
            this.btnSort.UseVisualStyleBackColor = false;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.LimeGreen;
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(12, 285);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(83, 23);
            this.btnSearch.TabIndex = 46;
            this.btnSearch.Text = "&Search Name";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(101, 287);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(242, 20);
            this.txtSearch.TabIndex = 47;
            // 
            // btnUndoSearch
            // 
            this.btnUndoSearch.BackColor = System.Drawing.Color.LimeGreen;
            this.btnUndoSearch.Enabled = false;
            this.btnUndoSearch.ForeColor = System.Drawing.Color.White;
            this.btnUndoSearch.Location = new System.Drawing.Point(349, 285);
            this.btnUndoSearch.Name = "btnUndoSearch";
            this.btnUndoSearch.Size = new System.Drawing.Size(84, 23);
            this.btnUndoSearch.TabIndex = 48;
            this.btnUndoSearch.Text = "Undo Search";
            this.btnUndoSearch.UseVisualStyleBackColor = false;
            this.btnUndoSearch.Click += new System.EventHandler(this.btnUndoSearch_Click);
            // 
            // frmVendor
            // 
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(716, 318);
            this.Controls.Add(this.btnUndoSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.txtStoreWebsite);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnWebsite);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtStoreState);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnVendorExit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClearVendor);
            this.Controls.Add(this.btnDeleteVendor);
            this.Controls.Add(this.btnUpdateVendor);
            this.Controls.Add(this.btnAddVendor);
            this.Controls.Add(this.txtStoreCity);
            this.Controls.Add(this.txtStoreName);
            this.Controls.Add(this.lstVendor);
            this.Controls.Add(this.mnuVendors);
            this.MainMenuStrip = this.mnuVendors;
            this.Name = "frmVendor";
            this.Text = "MediaDB: Vendor Management";
            this.Load += new System.EventHandler(this.frmVendor_Load);
            this.Resize += new System.EventHandler(this.frmVendor_Resize);
            this.mnuVendors.ResumeLayout(false);
            this.mnuVendors.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.MenuStrip mnuVendors;
    private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem mnuFileExitVendor;
    private System.Windows.Forms.ListBox lstVendor;
    private System.Windows.Forms.ToolStripMenuItem mnuFileOpenVendor;
    private System.Windows.Forms.Button btnVendorExit;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button btnClearVendor;
    private System.Windows.Forms.Button btnDeleteVendor;
    private System.Windows.Forms.Button btnUpdateVendor;
    private System.Windows.Forms.Button btnAddVendor;
    private System.Windows.Forms.TextBox txtStoreCity;
    private System.Windows.Forms.TextBox txtStoreName;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox txtStoreState;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Button btnWebsite;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.TextBox txtStoreWebsite;
    private System.Windows.Forms.Button btnSort;
    private System.Windows.Forms.Button btnSearch;
    private System.Windows.Forms.TextBox txtSearch;
    private System.Windows.Forms.Button btnUndoSearch;
    private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem howToUseToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
}