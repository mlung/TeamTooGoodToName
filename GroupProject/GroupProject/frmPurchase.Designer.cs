partial class frmPurchase
{
    #region Windows Form Designer generated code

    private void InitializeComponent()
    {
            this.mnuPurchase = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.howToUseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cboPurchase = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblMediaType = new System.Windows.Forms.Label();
            this.btnMediaClear = new System.Windows.Forms.Button();
            this.btnMediaDelete = new System.Windows.Forms.Button();
            this.btnMediaUpdate = new System.Windows.Forms.Button();
            this.btnMediaAdd = new System.Windows.Forms.Button();
            this.lstPurchase = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPurchaseDate = new System.Windows.Forms.TextBox();
            this.btnSort = new System.Windows.Forms.Button();
            this.btnLookup = new System.Windows.Forms.Button();
            this.txtLookup = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.mnuPurchase.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuPurchase
            // 
            this.mnuPurchase.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.mnuPurchase.Location = new System.Drawing.Point(0, 0);
            this.mnuPurchase.Name = "mnuPurchase";
            this.mnuPurchase.Size = new System.Drawing.Size(540, 24);
            this.mnuPurchase.TabIndex = 2;
            this.mnuPurchase.Text = "Purchase Menu";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFileOpen,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // mnuFileOpen
            // 
            this.mnuFileOpen.Name = "mnuFileOpen";
            this.mnuFileOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.mnuFileOpen.Size = new System.Drawing.Size(146, 22);
            this.mnuFileOpen.Text = "Open";
            this.mnuFileOpen.Click += new System.EventHandler(this.mnuFileOpen_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
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
            // cboPurchase
            // 
            this.cboPurchase.FormattingEnabled = true;
            this.cboPurchase.Items.AddRange(new object[] {
            "Cash",
            "Credit"});
            this.cboPurchase.Location = new System.Drawing.Point(410, 125);
            this.cboPurchase.Name = "cboPurchase";
            this.cboPurchase.Size = new System.Drawing.Size(109, 21);
            this.cboPurchase.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LimeGreen;
            this.label1.Location = new System.Drawing.Point(355, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 33;
            this.label1.Text = "Cost:";
            // 
            // txtCost
            // 
            this.txtCost.Location = new System.Drawing.Point(410, 91);
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(109, 20);
            this.txtCost.TabIndex = 32;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.LimeGreen;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(444, 256);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 31;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click_1);
            // 
            // lblMediaType
            // 
            this.lblMediaType.AutoSize = true;
            this.lblMediaType.BackColor = System.Drawing.Color.Transparent;
            this.lblMediaType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMediaType.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblMediaType.Location = new System.Drawing.Point(355, 128);
            this.lblMediaType.Name = "lblMediaType";
            this.lblMediaType.Size = new System.Drawing.Size(39, 13);
            this.lblMediaType.TabIndex = 30;
            this.lblMediaType.Text = "Type:";
            // 
            // btnMediaClear
            // 
            this.btnMediaClear.BackColor = System.Drawing.Color.LimeGreen;
            this.btnMediaClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMediaClear.ForeColor = System.Drawing.Color.White;
            this.btnMediaClear.Location = new System.Drawing.Point(444, 227);
            this.btnMediaClear.Name = "btnMediaClear";
            this.btnMediaClear.Size = new System.Drawing.Size(75, 23);
            this.btnMediaClear.TabIndex = 26;
            this.btnMediaClear.Text = "Clear";
            this.btnMediaClear.UseVisualStyleBackColor = false;
            this.btnMediaClear.Click += new System.EventHandler(this.btnMediaClear_Click);
            // 
            // btnMediaDelete
            // 
            this.btnMediaDelete.BackColor = System.Drawing.Color.LimeGreen;
            this.btnMediaDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMediaDelete.ForeColor = System.Drawing.Color.White;
            this.btnMediaDelete.Location = new System.Drawing.Point(357, 227);
            this.btnMediaDelete.Name = "btnMediaDelete";
            this.btnMediaDelete.Size = new System.Drawing.Size(75, 23);
            this.btnMediaDelete.TabIndex = 27;
            this.btnMediaDelete.Text = "Delete";
            this.btnMediaDelete.UseVisualStyleBackColor = false;
            this.btnMediaDelete.Click += new System.EventHandler(this.btnMediaDelete_Click);
            // 
            // btnMediaUpdate
            // 
            this.btnMediaUpdate.BackColor = System.Drawing.Color.LimeGreen;
            this.btnMediaUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMediaUpdate.ForeColor = System.Drawing.Color.White;
            this.btnMediaUpdate.Location = new System.Drawing.Point(444, 198);
            this.btnMediaUpdate.Name = "btnMediaUpdate";
            this.btnMediaUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnMediaUpdate.TabIndex = 28;
            this.btnMediaUpdate.Text = "Update";
            this.btnMediaUpdate.UseVisualStyleBackColor = false;
            this.btnMediaUpdate.Click += new System.EventHandler(this.btnMediaUpdate_Click);
            // 
            // btnMediaAdd
            // 
            this.btnMediaAdd.BackColor = System.Drawing.Color.LimeGreen;
            this.btnMediaAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMediaAdd.ForeColor = System.Drawing.Color.White;
            this.btnMediaAdd.Location = new System.Drawing.Point(357, 198);
            this.btnMediaAdd.Name = "btnMediaAdd";
            this.btnMediaAdd.Size = new System.Drawing.Size(75, 23);
            this.btnMediaAdd.TabIndex = 29;
            this.btnMediaAdd.Text = "Add";
            this.btnMediaAdd.UseVisualStyleBackColor = false;
            this.btnMediaAdd.Click += new System.EventHandler(this.btnMediaAdd_Click_1);
            // 
            // lstPurchase
            // 
            this.lstPurchase.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstPurchase.FormattingEnabled = true;
            this.lstPurchase.Location = new System.Drawing.Point(12, 40);
            this.lstPurchase.Name = "lstPurchase";
            this.lstPurchase.Size = new System.Drawing.Size(321, 238);
            this.lstPurchase.TabIndex = 24;
            this.lstPurchase.SelectedIndexChanged += new System.EventHandler(this.lstPurchase_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LimeGreen;
            this.label2.Location = new System.Drawing.Point(355, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 35;
            this.label2.Text = "Date:";
            // 
            // txtPurchaseDate
            // 
            this.txtPurchaseDate.Location = new System.Drawing.Point(410, 160);
            this.txtPurchaseDate.Name = "txtPurchaseDate";
            this.txtPurchaseDate.Size = new System.Drawing.Size(109, 20);
            this.txtPurchaseDate.TabIndex = 36;
            // 
            // btnSort
            // 
            this.btnSort.BackColor = System.Drawing.Color.LimeGreen;
            this.btnSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSort.ForeColor = System.Drawing.Color.White;
            this.btnSort.Location = new System.Drawing.Point(357, 256);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(75, 23);
            this.btnSort.TabIndex = 37;
            this.btnSort.Text = "Sort Date";
            this.btnSort.UseVisualStyleBackColor = false;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // btnLookup
            // 
            this.btnLookup.BackColor = System.Drawing.Color.LimeGreen;
            this.btnLookup.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLookup.ForeColor = System.Drawing.Color.Cornsilk;
            this.btnLookup.Location = new System.Drawing.Point(247, 286);
            this.btnLookup.Name = "btnLookup";
            this.btnLookup.Size = new System.Drawing.Size(86, 23);
            this.btnLookup.TabIndex = 38;
            this.btnLookup.Text = "Look Up";
            this.btnLookup.UseVisualStyleBackColor = false;
            this.btnLookup.Click += new System.EventHandler(this.btnLookup_Click);
            // 
            // txtLookup
            // 
            this.txtLookup.Location = new System.Drawing.Point(90, 288);
            this.txtLookup.Name = "txtLookup";
            this.txtLookup.Size = new System.Drawing.Size(151, 20);
            this.txtLookup.TabIndex = 39;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.LimeGreen;
            this.label3.Location = new System.Drawing.Point(9, 291);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 40;
            this.label3.Text = "Date Lookup:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.LimeGreen;
            this.label4.Location = new System.Drawing.Point(353, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(179, 33);
            this.label4.TabIndex = 41;
            this.label4.Text = "PURCHASE";
            // 
            // frmPurchase
            // 
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(540, 322);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtLookup);
            this.Controls.Add(this.btnLookup);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.txtPurchaseDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboPurchase);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCost);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblMediaType);
            this.Controls.Add(this.btnMediaClear);
            this.Controls.Add(this.btnMediaDelete);
            this.Controls.Add(this.btnMediaUpdate);
            this.Controls.Add(this.btnMediaAdd);
            this.Controls.Add(this.lstPurchase);
            this.Controls.Add(this.mnuPurchase);
            this.MainMenuStrip = this.mnuPurchase;
            this.Name = "frmPurchase";
            this.Text = "MediaDB: Purchase Management";
            this.Load += new System.EventHandler(this.frmPurchase_Load);
            this.Resize += new System.EventHandler(this.frmPurchase_Resize);
            this.mnuPurchase.ResumeLayout(false);
            this.mnuPurchase.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.MenuStrip mnuPurchase;
    private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    private System.Windows.Forms.ComboBox cboPurchase;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox txtCost;
    private System.Windows.Forms.Button btnExit;
    private System.Windows.Forms.Label lblMediaType;
    private System.Windows.Forms.Button btnMediaClear;
    private System.Windows.Forms.Button btnMediaDelete;
    private System.Windows.Forms.Button btnMediaUpdate;
    private System.Windows.Forms.Button btnMediaAdd;
    private System.Windows.Forms.ListBox lstPurchase;
    private System.Windows.Forms.ToolStripMenuItem mnuFileOpen;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox txtPurchaseDate;
    private System.Windows.Forms.Button btnSort;
    private System.Windows.Forms.Button btnLookup;
    private System.Windows.Forms.TextBox txtLookup;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem howToUseToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
}