//MEDIA MANAGEMENT

using System;
using System.Windows.Forms;

public partial class frmMedia : Form
{

    public frmMedia()
    {
        InitializeComponent();//Initialize - see frmMain.Designer.cs
    }

    private void btnExit_Click(object sender, EventArgs e)
    {
        Close();
    }


    private void btnMedia_Click(object sender, EventArgs e)
    {
        frmMedia media = new frmMedia();
        media.Show();
    }
}