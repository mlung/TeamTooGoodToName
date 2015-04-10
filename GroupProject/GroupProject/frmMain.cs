//MAIN FORM
using System;
using System.Windows.Forms;

public partial class frmMain : Form
{
    public static void Main()
    {
        frmMain main = new frmMain();
        Application.Run(main);
    }

    public frmMain()
    {
        InitializeComponent();//Initialize - see frmMain.Designer.cs
    }

    private void btnExit_Click(object sender, EventArgs e)
    {
        Close();
    }

    private void btnOk_Click(object sender, EventArgs e)
    {
        MessageBox.Show("Welcome to " + DateTime.Today.ToString("y") + "! Let's make it count.");
    }

    private void btnMedia_Click(object sender, EventArgs e)
    {
        frmMedia media = new frmMedia();
        media.Show();
    }

    private void btnVendor_Click(object sender, EventArgs e)
    {
        frmVendor vendor = new frmVendor();
        vendor.Show();
    }

    private void btnPurchase_Click(object sender, EventArgs e)
    {
        frmPurchase purchase = new frmPurchase();
        purchase.Show();
    }


}