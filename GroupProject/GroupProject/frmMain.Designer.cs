partial class frmMain
{
    #region Windows Form Designer generated code

    private void InitializeComponent()
    {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.btnMedia = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.mnuMain = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.btnPurchase = new System.Windows.Forms.Button();
            this.lblMediaHeader = new System.Windows.Forms.Label();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnMedia
            // 
            this.btnMedia.BackColor = System.Drawing.Color.LimeGreen;
            this.btnMedia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMedia.ForeColor = System.Drawing.Color.White;
            this.btnMedia.Image = ((System.Drawing.Image)(resources.GetObject("btnMedia.Image")));
            this.btnMedia.Location = new System.Drawing.Point(12, 77);
            this.btnMedia.Name = "btnMedia";
            this.btnMedia.Size = new System.Drawing.Size(489, 23);
            this.btnMedia.TabIndex = 0;
            this.btnMedia.Text = " Media Management";
            this.btnMedia.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMedia.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMedia.UseVisualStyleBackColor = false;
            this.btnMedia.Click += new System.EventHandler(this.btnMedia_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.LimeGreen;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(12, 164);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(489, 23);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = " Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // mnuMain
            // 
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.mnuMain.Location = new System.Drawing.Point(0, 0);
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.Size = new System.Drawing.Size(513, 24);
            this.mnuMain.TabIndex = 2;
            this.mnuMain.Text = "Main Menu";
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
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LimeGreen;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(12, 106);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(489, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = " Vendor Management";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btnVendor_Click);
            // 
            // btnPurchase
            // 
            this.btnPurchase.BackColor = System.Drawing.Color.LimeGreen;
            this.btnPurchase.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPurchase.ForeColor = System.Drawing.Color.White;
            this.btnPurchase.Image = ((System.Drawing.Image)(resources.GetObject("btnPurchase.Image")));
            this.btnPurchase.Location = new System.Drawing.Point(12, 135);
            this.btnPurchase.Name = "btnPurchase";
            this.btnPurchase.Size = new System.Drawing.Size(489, 23);
            this.btnPurchase.TabIndex = 2;
            this.btnPurchase.Text = " Purchase Management";
            this.btnPurchase.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPurchase.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPurchase.UseVisualStyleBackColor = false;
            this.btnPurchase.Click += new System.EventHandler(this.btnPurchase_Click);
            // 
            // lblMediaHeader
            // 
            this.lblMediaHeader.AutoSize = true;
            this.lblMediaHeader.BackColor = System.Drawing.Color.Transparent;
            this.lblMediaHeader.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMediaHeader.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblMediaHeader.Location = new System.Drawing.Point(127, 32);
            this.lblMediaHeader.Name = "lblMediaHeader";
            this.lblMediaHeader.Size = new System.Drawing.Size(277, 33);
            this.lblMediaHeader.TabIndex = 11;
            this.lblMediaHeader.Text = "MEDIA DATABASE";
            this.lblMediaHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(513, 199);
            this.Controls.Add(this.lblMediaHeader);
            this.Controls.Add(this.btnPurchase);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnMedia);
            this.Controls.Add(this.mnuMain);
            this.MainMenuStrip = this.mnuMain;
            this.Name = "frmMain";
            this.Text = "MediaDB";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.Resize += new System.EventHandler(this.frmMain_Resize);
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button btnMedia;
    private System.Windows.Forms.Button btnExit;
    private System.Windows.Forms.MenuStrip mnuMain;
    private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Button btnPurchase;
    private System.Windows.Forms.Label lblMediaHeader;
    private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
}