partial class frmMedia
{
    #region Windows Form Designer generated code

    private void InitializeComponent()
    {
            this.mnuMedia = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.howToUseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lstMedia = new System.Windows.Forms.ListBox();
            this.btnMediaAdd = new System.Windows.Forms.Button();
            this.btnMediaUpdate = new System.Windows.Forms.Button();
            this.btnMediaDelete = new System.Windows.Forms.Button();
            this.btnMediaClear = new System.Windows.Forms.Button();
            this.txtMediaName = new System.Windows.Forms.TextBox();
            this.lblMediaName = new System.Windows.Forms.Label();
            this.lblMediaType = new System.Windows.Forms.Label();
            this.cboMediaType = new System.Windows.Forms.ComboBox();
            this.btnMediaMoreInfo = new System.Windows.Forms.Button();
            this.btnMediaInfo = new System.Windows.Forms.Button();
            this.lblMediaHeader = new System.Windows.Forms.Label();
            this.btnMediaSortName = new System.Windows.Forms.Button();
            this.cboSortType = new System.Windows.Forms.ComboBox();
            this.txtMediaSearch = new System.Windows.Forms.TextBox();
            this.btnMediaSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSearchHelp = new System.Windows.Forms.Label();
            this.txtMediaCreator = new System.Windows.Forms.TextBox();
            this.lblMediaCreator = new System.Windows.Forms.Label();
            this.txtMediaGenre = new System.Windows.Forms.TextBox();
            this.lblMediaGenre = new System.Windows.Forms.Label();
            this.txtMediaLength = new System.Windows.Forms.TextBox();
            this.lblLength = new System.Windows.Forms.Label();
            this.txtMediaYear = new System.Windows.Forms.TextBox();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblHelpLength = new System.Windows.Forms.Label();
            this.cboPurchase = new System.Windows.Forms.ComboBox();
            this.lblPurchase = new System.Windows.Forms.Label();
            this.mnuMedia.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuMedia
            // 
            this.mnuMedia.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.mnuMedia.Location = new System.Drawing.Point(0, 0);
            this.mnuMedia.Name = "mnuMedia";
            this.mnuMedia.Size = new System.Drawing.Size(683, 24);
            this.mnuMedia.TabIndex = 2;
            this.mnuMedia.Text = "Media Menu";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
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
            // lstMedia
            // 
            this.lstMedia.Font = new System.Drawing.Font("Consolas", 7.5F);
            this.lstMedia.FormattingEnabled = true;
            this.lstMedia.HorizontalScrollbar = true;
            this.lstMedia.ItemHeight = 12;
            this.lstMedia.Location = new System.Drawing.Point(12, 27);
            this.lstMedia.Name = "lstMedia";
            this.lstMedia.Size = new System.Drawing.Size(321, 232);
            this.lstMedia.TabIndex = 11;
            this.lstMedia.SelectedIndexChanged += new System.EventHandler(this.lstMedia_SelectedIndexChanged);
            // 
            // btnMediaAdd
            // 
            this.btnMediaAdd.BackColor = System.Drawing.Color.LimeGreen;
            this.btnMediaAdd.ForeColor = System.Drawing.Color.White;
            this.btnMediaAdd.Location = new System.Drawing.Point(339, 206);
            this.btnMediaAdd.Name = "btnMediaAdd";
            this.btnMediaAdd.Size = new System.Drawing.Size(75, 23);
            this.btnMediaAdd.TabIndex = 7;
            this.btnMediaAdd.Text = "Add";
            this.btnMediaAdd.UseVisualStyleBackColor = false;
            this.btnMediaAdd.Click += new System.EventHandler(this.btnMediaAdd_Click);
            // 
            // btnMediaUpdate
            // 
            this.btnMediaUpdate.BackColor = System.Drawing.Color.LimeGreen;
            this.btnMediaUpdate.ForeColor = System.Drawing.Color.White;
            this.btnMediaUpdate.Location = new System.Drawing.Point(427, 206);
            this.btnMediaUpdate.Name = "btnMediaUpdate";
            this.btnMediaUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnMediaUpdate.TabIndex = 8;
            this.btnMediaUpdate.Text = "Update";
            this.btnMediaUpdate.UseVisualStyleBackColor = false;
            this.btnMediaUpdate.Click += new System.EventHandler(this.btnMediaUpdate_Click);
            // 
            // btnMediaDelete
            // 
            this.btnMediaDelete.BackColor = System.Drawing.Color.LimeGreen;
            this.btnMediaDelete.ForeColor = System.Drawing.Color.White;
            this.btnMediaDelete.Location = new System.Drawing.Point(512, 206);
            this.btnMediaDelete.Name = "btnMediaDelete";
            this.btnMediaDelete.Size = new System.Drawing.Size(75, 23);
            this.btnMediaDelete.TabIndex = 9;
            this.btnMediaDelete.Text = "Delete";
            this.btnMediaDelete.UseVisualStyleBackColor = false;
            this.btnMediaDelete.Click += new System.EventHandler(this.btnMediaDelete_Click);
            // 
            // btnMediaClear
            // 
            this.btnMediaClear.BackColor = System.Drawing.Color.LimeGreen;
            this.btnMediaClear.ForeColor = System.Drawing.Color.White;
            this.btnMediaClear.Location = new System.Drawing.Point(596, 206);
            this.btnMediaClear.Name = "btnMediaClear";
            this.btnMediaClear.Size = new System.Drawing.Size(75, 23);
            this.btnMediaClear.TabIndex = 10;
            this.btnMediaClear.Text = "Clear";
            this.btnMediaClear.UseVisualStyleBackColor = false;
            this.btnMediaClear.Click += new System.EventHandler(this.btnMediaClear_Click);
            // 
            // txtMediaName
            // 
            this.txtMediaName.Location = new System.Drawing.Point(401, 85);
            this.txtMediaName.Name = "txtMediaName";
            this.txtMediaName.Size = new System.Drawing.Size(100, 20);
            this.txtMediaName.TabIndex = 0;
            // 
            // lblMediaName
            // 
            this.lblMediaName.AutoSize = true;
            this.lblMediaName.BackColor = System.Drawing.Color.Transparent;
            this.lblMediaName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMediaName.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblMediaName.Location = new System.Drawing.Point(336, 88);
            this.lblMediaName.Name = "lblMediaName";
            this.lblMediaName.Size = new System.Drawing.Size(43, 13);
            this.lblMediaName.TabIndex = 7;
            this.lblMediaName.Text = "Name:";
            // 
            // lblMediaType
            // 
            this.lblMediaType.AutoSize = true;
            this.lblMediaType.BackColor = System.Drawing.Color.Transparent;
            this.lblMediaType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMediaType.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblMediaType.Location = new System.Drawing.Point(336, 114);
            this.lblMediaType.Name = "lblMediaType";
            this.lblMediaType.Size = new System.Drawing.Size(39, 13);
            this.lblMediaType.TabIndex = 8;
            this.lblMediaType.Text = "Type:";
            // 
            // cboMediaType
            // 
            this.cboMediaType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMediaType.FormattingEnabled = true;
            this.cboMediaType.Items.AddRange(new object[] {
            "DVD",
            "Blu-Ray",
            "Video",
            "Book",
            "Music",
            "CD",
            "Album",
            "Game",
            "Other"});
            this.cboMediaType.Location = new System.Drawing.Point(401, 111);
            this.cboMediaType.Name = "cboMediaType";
            this.cboMediaType.Size = new System.Drawing.Size(100, 21);
            this.cboMediaType.TabIndex = 1;
            // 
            // btnMediaMoreInfo
            // 
            this.btnMediaMoreInfo.Location = new System.Drawing.Point(0, 0);
            this.btnMediaMoreInfo.Name = "btnMediaMoreInfo";
            this.btnMediaMoreInfo.Size = new System.Drawing.Size(75, 23);
            this.btnMediaMoreInfo.TabIndex = 0;
            // 
            // btnMediaInfo
            // 
            this.btnMediaInfo.BackColor = System.Drawing.Color.LimeGreen;
            this.btnMediaInfo.ForeColor = System.Drawing.Color.White;
            this.btnMediaInfo.Location = new System.Drawing.Point(195, 265);
            this.btnMediaInfo.Name = "btnMediaInfo";
            this.btnMediaInfo.Size = new System.Drawing.Size(138, 21);
            this.btnMediaInfo.TabIndex = 14;
            this.btnMediaInfo.Text = "More Info...";
            this.btnMediaInfo.UseVisualStyleBackColor = false;
            this.btnMediaInfo.Click += new System.EventHandler(this.btnMediaMoreInfo_Click);
            // 
            // lblMediaHeader
            // 
            this.lblMediaHeader.AutoSize = true;
            this.lblMediaHeader.BackColor = System.Drawing.Color.Transparent;
            this.lblMediaHeader.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMediaHeader.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblMediaHeader.Location = new System.Drawing.Point(456, 27);
            this.lblMediaHeader.Name = "lblMediaHeader";
            this.lblMediaHeader.Size = new System.Drawing.Size(109, 33);
            this.lblMediaHeader.TabIndex = 10;
            this.lblMediaHeader.Text = "MEDIA";
            // 
            // btnMediaSortName
            // 
            this.btnMediaSortName.BackColor = System.Drawing.Color.LimeGreen;
            this.btnMediaSortName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMediaSortName.ForeColor = System.Drawing.Color.White;
            this.btnMediaSortName.Location = new System.Drawing.Point(139, 265);
            this.btnMediaSortName.Name = "btnMediaSortName";
            this.btnMediaSortName.Size = new System.Drawing.Size(50, 21);
            this.btnMediaSortName.TabIndex = 13;
            this.btnMediaSortName.Text = "Sort";
            this.btnMediaSortName.UseVisualStyleBackColor = false;
            this.btnMediaSortName.Click += new System.EventHandler(this.btnMediaSort_Click);
            // 
            // cboSortType
            // 
            this.cboSortType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSortType.FormattingEnabled = true;
            this.cboSortType.Items.AddRange(new object[] {
            "Default",
            "Title",
            "Type"});
            this.cboSortType.Location = new System.Drawing.Point(12, 265);
            this.cboSortType.Name = "cboSortType";
            this.cboSortType.Size = new System.Drawing.Size(121, 21);
            this.cboSortType.TabIndex = 12;
            // 
            // txtMediaSearch
            // 
            this.txtMediaSearch.Location = new System.Drawing.Point(453, 265);
            this.txtMediaSearch.Name = "txtMediaSearch";
            this.txtMediaSearch.Size = new System.Drawing.Size(162, 20);
            this.txtMediaSearch.TabIndex = 15;
            // 
            // btnMediaSearch
            // 
            this.btnMediaSearch.BackColor = System.Drawing.Color.LimeGreen;
            this.btnMediaSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMediaSearch.ForeColor = System.Drawing.Color.White;
            this.btnMediaSearch.Location = new System.Drawing.Point(621, 265);
            this.btnMediaSearch.Name = "btnMediaSearch";
            this.btnMediaSearch.Size = new System.Drawing.Size(50, 20);
            this.btnMediaSearch.TabIndex = 16;
            this.btnMediaSearch.Text = "Search";
            this.btnMediaSearch.UseVisualStyleBackColor = false;
            this.btnMediaSearch.Click += new System.EventHandler(this.btnMediaSearch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LimeGreen;
            this.label1.Location = new System.Drawing.Point(387, 269);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Search:";
            // 
            // lblSearchHelp
            // 
            this.lblSearchHelp.AutoSize = true;
            this.lblSearchHelp.BackColor = System.Drawing.Color.Transparent;
            this.lblSearchHelp.CausesValidation = false;
            this.lblSearchHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchHelp.ForeColor = System.Drawing.Color.Blue;
            this.lblSearchHelp.Location = new System.Drawing.Point(437, 263);
            this.lblSearchHelp.Name = "lblSearchHelp";
            this.lblSearchHelp.Size = new System.Drawing.Size(13, 9);
            this.lblSearchHelp.TabIndex = 13;
            this.lblSearchHelp.Text = "[?]";
            this.lblSearchHelp.Click += new System.EventHandler(this.lblSearchHelp_Click);
            // 
            // txtMediaCreator
            // 
            this.txtMediaCreator.Location = new System.Drawing.Point(401, 138);
            this.txtMediaCreator.Name = "txtMediaCreator";
            this.txtMediaCreator.Size = new System.Drawing.Size(100, 20);
            this.txtMediaCreator.TabIndex = 2;
            // 
            // lblMediaCreator
            // 
            this.lblMediaCreator.AutoSize = true;
            this.lblMediaCreator.BackColor = System.Drawing.Color.Transparent;
            this.lblMediaCreator.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMediaCreator.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblMediaCreator.Location = new System.Drawing.Point(336, 141);
            this.lblMediaCreator.Name = "lblMediaCreator";
            this.lblMediaCreator.Size = new System.Drawing.Size(52, 13);
            this.lblMediaCreator.TabIndex = 8;
            this.lblMediaCreator.Text = "Creator:";
            // 
            // txtMediaGenre
            // 
            this.txtMediaGenre.Location = new System.Drawing.Point(401, 164);
            this.txtMediaGenre.Name = "txtMediaGenre";
            this.txtMediaGenre.Size = new System.Drawing.Size(100, 20);
            this.txtMediaGenre.TabIndex = 3;
            // 
            // lblMediaGenre
            // 
            this.lblMediaGenre.AutoSize = true;
            this.lblMediaGenre.BackColor = System.Drawing.Color.Transparent;
            this.lblMediaGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMediaGenre.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblMediaGenre.Location = new System.Drawing.Point(336, 167);
            this.lblMediaGenre.Name = "lblMediaGenre";
            this.lblMediaGenre.Size = new System.Drawing.Size(45, 13);
            this.lblMediaGenre.TabIndex = 8;
            this.lblMediaGenre.Text = "Genre:";
            // 
            // txtMediaLength
            // 
            this.txtMediaLength.Location = new System.Drawing.Point(571, 85);
            this.txtMediaLength.Name = "txtMediaLength";
            this.txtMediaLength.Size = new System.Drawing.Size(100, 20);
            this.txtMediaLength.TabIndex = 4;
            // 
            // lblLength
            // 
            this.lblLength.AutoSize = true;
            this.lblLength.BackColor = System.Drawing.Color.Transparent;
            this.lblLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLength.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblLength.Location = new System.Drawing.Point(509, 88);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(50, 13);
            this.lblLength.TabIndex = 8;
            this.lblLength.Text = "Length:";
            // 
            // txtMediaYear
            // 
            this.txtMediaYear.Location = new System.Drawing.Point(571, 111);
            this.txtMediaYear.Name = "txtMediaYear";
            this.txtMediaYear.Size = new System.Drawing.Size(100, 20);
            this.txtMediaYear.TabIndex = 5;
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.BackColor = System.Drawing.Color.Transparent;
            this.lblYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYear.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblYear.Location = new System.Drawing.Point(509, 114);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(37, 13);
            this.lblYear.TabIndex = 8;
            this.lblYear.Text = "Year:";
            // 
            // lblHelpLength
            // 
            this.lblHelpLength.AutoSize = true;
            this.lblHelpLength.BackColor = System.Drawing.Color.Transparent;
            this.lblHelpLength.CausesValidation = false;
            this.lblHelpLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHelpLength.ForeColor = System.Drawing.Color.Blue;
            this.lblHelpLength.Location = new System.Drawing.Point(555, 84);
            this.lblHelpLength.Name = "lblHelpLength";
            this.lblHelpLength.Size = new System.Drawing.Size(13, 9);
            this.lblHelpLength.TabIndex = 13;
            this.lblHelpLength.Text = "[?]";
            this.lblHelpLength.Click += new System.EventHandler(this.lbHelpLength_Click);
            // 
            // cboPurchase
            // 
            this.cboPurchase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPurchase.FormattingEnabled = true;
            this.cboPurchase.Location = new System.Drawing.Point(571, 137);
            this.cboPurchase.Name = "cboPurchase";
            this.cboPurchase.Size = new System.Drawing.Size(100, 21);
            this.cboPurchase.TabIndex = 6;
            // 
            // lblPurchase
            // 
            this.lblPurchase.AutoSize = true;
            this.lblPurchase.BackColor = System.Drawing.Color.Transparent;
            this.lblPurchase.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPurchase.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblPurchase.Location = new System.Drawing.Point(509, 140);
            this.lblPurchase.Name = "lblPurchase";
            this.lblPurchase.Size = new System.Drawing.Size(64, 13);
            this.lblPurchase.TabIndex = 8;
            this.lblPurchase.Text = "Purchase:";
            // 
            // frmMedia
            // 
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(683, 293);
            this.Controls.Add(this.cboPurchase);
            this.Controls.Add(this.lblHelpLength);
            this.Controls.Add(this.lblSearchHelp);
            this.Controls.Add(this.txtMediaSearch);
            this.Controls.Add(this.cboSortType);
            this.Controls.Add(this.lblMediaHeader);
            this.Controls.Add(this.btnMediaInfo);
            this.Controls.Add(this.lblPurchase);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.lblLength);
            this.Controls.Add(this.lblMediaGenre);
            this.Controls.Add(this.lblMediaCreator);
            this.Controls.Add(this.lblMediaType);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblMediaName);
            this.Controls.Add(this.cboMediaType);
            this.Controls.Add(this.txtMediaYear);
            this.Controls.Add(this.txtMediaLength);
            this.Controls.Add(this.txtMediaGenre);
            this.Controls.Add(this.txtMediaCreator);
            this.Controls.Add(this.txtMediaName);
            this.Controls.Add(this.btnMediaClear);
            this.Controls.Add(this.btnMediaDelete);
            this.Controls.Add(this.btnMediaUpdate);
            this.Controls.Add(this.btnMediaSearch);
            this.Controls.Add(this.btnMediaSortName);
            this.Controls.Add(this.btnMediaAdd);
            this.Controls.Add(this.lstMedia);
            this.Controls.Add(this.mnuMedia);
            this.MainMenuStrip = this.mnuMedia;
            this.Name = "frmMedia";
            this.Text = "MediaDB: Media Management";
            this.Load += new System.EventHandler(this.frmMedia_Load);
            this.Resize += new System.EventHandler(this.frmMedia_Resize);
            this.mnuMedia.ResumeLayout(false);
            this.mnuMedia.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.MenuStrip mnuMedia;
    private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    private System.Windows.Forms.ListBox lstMedia;
    private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
    private System.Windows.Forms.Button btnMediaAdd;
    private System.Windows.Forms.Button btnMediaUpdate;
    private System.Windows.Forms.Button btnMediaDelete;
    private System.Windows.Forms.Button btnMediaClear;
    private System.Windows.Forms.TextBox txtMediaName;
    private System.Windows.Forms.Label lblMediaName;
    private System.Windows.Forms.Label lblMediaType;
    private System.Windows.Forms.ComboBox cboMediaType;
    private System.Windows.Forms.Button btnMediaMoreInfo;
    private System.Windows.Forms.Button btnMediaInfo;
    private System.Windows.Forms.Label lblMediaHeader;
    private System.Windows.Forms.Button btnMediaSortName;
    private System.Windows.Forms.ComboBox cboSortType;
    private System.Windows.Forms.TextBox txtMediaSearch;
    private System.Windows.Forms.Button btnMediaSearch;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label lblSearchHelp;
    private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem howToUseToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    private System.Windows.Forms.TextBox txtMediaCreator;
    private System.Windows.Forms.Label lblMediaCreator;
    private System.Windows.Forms.TextBox txtMediaGenre;
    private System.Windows.Forms.Label lblMediaGenre;
    private System.Windows.Forms.TextBox txtMediaLength;
    private System.Windows.Forms.Label lblLength;
    private System.Windows.Forms.TextBox txtMediaYear;
    private System.Windows.Forms.Label lblYear;
    private System.Windows.Forms.Label lblHelpLength;
    private System.Windows.Forms.ComboBox cboPurchase;
    private System.Windows.Forms.Label lblPurchase;
}