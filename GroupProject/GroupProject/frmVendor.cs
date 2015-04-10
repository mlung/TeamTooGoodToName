//VENDOR MANAGEMENT
using System;
using System.Windows.Forms;

public partial class frmVendor : Form
{

    public frmVendor()
    {
        InitializeComponent();//Initialize - see frmMain.Designer.cs
    }

    private void btnExit_Click(object sender, EventArgs e)
    {
        Close();
    }


    private void btnVendor_Click(object sender, EventArgs e)
    {
        frmVendor Vendor = new frmVendor();
        Vendor.Show();
    }
}