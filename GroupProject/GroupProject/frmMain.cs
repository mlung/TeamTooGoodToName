//MAIN FORM
using System;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;

public partial class frmMain : Form
{
    
    [STAThread]
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
        if (!Application.OpenForms.OfType<frmMedia>().Any()) //Only one form of each type should be open at once
        {
            frmMedia media = new frmMedia();
            media.Show();
        }
     }

    private void btnVendor_Click(object sender, EventArgs e)
    {
        if (!Application.OpenForms.OfType<frmVendor>().Any())
        {
            frmVendor vendor = new frmVendor();
            vendor.Show();
        }
    }

    private void btnPurchase_Click(object sender, EventArgs e)
    {
        if (!Application.OpenForms.OfType<frmPurchase>().Any())
        {
            frmPurchase purchase = new frmPurchase();
            purchase.Show();
        }
    }

    protected override void OnPaintBackground(PaintEventArgs e)
    {
        try
        {
            using (LinearGradientBrush brush = new LinearGradientBrush(this.ClientRectangle, Color.FromArgb(128, 128, 128), Color.FromArgb(32, 32, 32), 90F))
            {
                e.Graphics.FillRectangle(brush, this.ClientRectangle);
            }
        }

        catch
        {
            base.OnPaintBackground(e); //If there's an error while drawing the gradient, just draw a normal background.
        }
    }

    private void frmMain_Resize(object sender, EventArgs e)
    {
        this.Invalidate(); //To make sure the gradient resizes with the window.
    }

    private void frmMain_Load(object sender, EventArgs e)
    {
        if (File.Exists("lastopened.txt"))
        {
            //Let's find out if its contents are an actual file or not. If so, we can quietly load it.
            try
            {
                StreamReader reader = new StreamReader("lastopened.txt");
                string fName = reader.ReadLine(); //Read only the first line, just in case the user tampered with lastopened.txt and added more text.
                reader.Close();
                if (File.Exists(fName))
                {
                    clsSQL.DBFileName = fName;
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while attempting to automatically load the last opened database:\n\n" + ex.Message);
            }
        }
    }

    private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
    {
        Application.Exit(); //Exit the application when the main form is closed.
    }

    private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
    {
        MessageBox.Show("MediaDB - Developed for the Spring 2015 CNIT 252 course.\n\nCreated by:\nIshmael Charles (Purchase Information)\nMiranda Lung (Media Information)\nKyle Precht (Vendor Information)", "About MediaDB", MessageBoxButtons.OK, MessageBoxIcon.Information);

    }

    private void exitToolStripMenuItem_Click(object sender, EventArgs e)
    {
        Close();
    }

    private void openToolStripMenuItem_Click(object sender, EventArgs e)
    {
        OpenFileDialog ofd;
        try
        {
            ofd = new OpenFileDialog();
            ofd.Filter = "Client DB files (*.accdb)|*.accdb|All files (*.*)|*.*";
            ofd.InitialDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Database");
            ofd.InitialDirectory = AppDomain.CurrentDomain.BaseDirectory;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                clsSQL.DBFileName = ofd.FileName;
            }
        }

        catch (Exception ex)
        {
            MessageBox.Show("An unexpected error has occurred while attempting to open this file." + Environment.NewLine + Environment.NewLine
            + "Error Message:" + Environment.NewLine
            + ex.Message);
        }
    }
}