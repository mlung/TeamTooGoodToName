//Purchase MANAGEMENT
using System;
using System.Windows.Forms;

public partial class frmPurchase : Form
{

    public frmPurchase()
    {
        InitializeComponent();//Initialize - see frmMain.Designer.cs
    }

    private void btnExit_Click(object sender, EventArgs e)
    {
        Close();
    }


    private void btnPurchase_Click(object sender, EventArgs e)
    {
        frmPurchase Purchase = new frmPurchase();
        Purchase.Show();
    }
}