//Purchase MANAGEMENT
using System;
using System.Windows.Forms;
using System.IO;
using System.Collections;
using System.Data.OleDb;
using System.Configuration;
using System.Drawing;
using System.Drawing.Drawing2D;

public partial class frmPurchase : Form
{
    private OleDbConnection mDB;
    public frmPurchase()
    {
        InitializeComponent();//Initialize - see frmMain.Designer.cs
    }

    //This is the button used to open the Purchase application.
    //=========================================================
    private void btnPurchase_Click(object sender, EventArgs e)
    {
        frmPurchase Purchase = new frmPurchase();
        Purchase.Show();
    }
    //This helper method opens the database connection.
    //=================================================
    private void openDatabaseConnection()
    {
        string connectionString = ConfigurationManager.AppSettings["DBConnectionString"] + clsSQL.DBFileName;
        mDB = new OleDbConnection(connectionString);
    }

    //This helper method closes the Database Connection.
    //=================================================
    private void closeDatabaseConnection()
    {
        if (mDB != null)
        {
            mDB.Close();
        }
    }

    //This helper method shows the messages in the application for Purchase.
    //======================================================================
    private void ShowMessage(string msg)
    {
        MessageBox.Show(msg, "Message from Application", MessageBoxButtons.OK);
    }

    //This helper method selects the data in the Purchase applcation
    //==============================================================
    private void lstPurchase_SelectedIndexChanged(object sender, EventArgs e)
    {
        int loc = lstPurchase.SelectedIndex - 1;
        if(loc < 0 || loc >= clsLists.mPurchase.Count)
        {
            return;
        }
        clsPurchase selectedPurchase =  (clsPurchase)clsLists.mPurchase[loc];
        txtCost.Text = selectedPurchase.cost.ToString();
        cboPurchase.Text = selectedPurchase.PaymentType;
        txtPurchaseDate.Text = selectedPurchase.PaymentDate.ToString("d");
        MessageBox.Show("If you want to update this record, change the details and click 'Update'.\n\nIf you want to delete this record, click 'Delete'.");
    
    }

    //This button closes the Purchase form application. 
    //================================================
    private void btnExit_Click_1(object sender, EventArgs e)
    {
        Close();
    }

   
    //This helper method is used to display and read the data in the Purchases application.
    //=====================================================================================
    private void readPurchases(string sql)
    {
        clsLists.mPurchase = clsSQL.queryPurchase(sql);
        lstPurchase.Items.Clear();

        lstPurchase.Items.Add("ID".PadRight(8) + "Cost".PadRight(8) + "PaymentType".PadRight(10) + "PaymentDate".PadLeft(15));

        foreach (clsPurchase purchase in clsLists.mPurchase)
        {
            lstPurchase.Items.Add(purchase);
        }
    }

    //This is the Delete Button Method used to delete the Purchase data in the application.
    //=====================================================================================
    private void btnMediaDelete_Click(object sender, EventArgs e)
    {
        
            int index = lstPurchase.SelectedIndex - 2;
            if (index < 0 || index >= clsLists.mPurchase.Count)
            {
                ShowMessage("Please select a valid client in the list to DELETE that client.");
            }
            else
            {
                clsPurchase clsPurchase = (clsPurchase)clsLists.mPurchase[index];    
                string sql = "DELETE FROM Purchase WHERE PurchaseID = " + clsPurchase.ID + ";";
                clsSQL.nonQuery(sql);
                ShowMessage("Purchase has been removed");
                readPurchases("SELECT * FROM Purchase");
            }
        }

    //This is the Helper Method used to clear the Purchases data in the application.
    //==============================================================================
    private void clearPurchases()
    {
        lstPurchase.Items.Clear();
        cboPurchase.Text = "";
        txtCost.Text = "";
        txtLookup.Clear();
        txtPurchaseDate.Clear();
        txtCost.Focus();
    }

    //This is the Clear button method to clear the purchases application.
    //===================================================================
    private void btnMediaClear_Click(object sender, EventArgs e)
    {
        clearPurchases();
    }

    //This is the code needed to update the Purchases info.
    //=====================================================
    private void btnMediaUpdate_Click(object sender, EventArgs e)
    {
        {
            int index = lstPurchase.SelectedIndex - 2;
            if (index < 0 || index >= clsLists.mPurchase.Count)
            {
                ShowMessage("Please select a valid client in the list to UPDATE that client.");
            }
            else
            {
                decimal cost;
                string sql;
                int locUpdate = lstPurchase.SelectedIndex - 1;


                if (validateInput(txtCost, new decimal(1L), new decimal(100000L), out cost) == false || validateInput(txtPurchaseDate) == false)
                    return;
                if (cboPurchase.Text == "")
                {
                    ShowMessage("Please select an investor");
                }
                if (MessageBox.Show("Please confirm that you wish to update this record." + txtCost.Text, "Confirm update", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    MessageBox.Show("Request Ignored");
                    lstPurchase.SelectedIndex = -1;
                    return;
                }
                else
                {

                    //clsComboBoxItem item = (clsComboBoxItem)cboPurchase.SelectedItem;
                    string mediaPurchase = cboPurchase.Text;
                    clsPurchase file = (clsPurchase)clsLists.mPurchase[locUpdate];


                    sql = "UPDATE Purchase SET "
                    + "Cost = " + clsSQL.ToSql(cost) + ", "
                    + "PaymentType = " + clsSQL.ToSql(mediaPurchase) + ", "
                    + "PaymentDate = " + clsSQL.ToSql(txtPurchaseDate.Text)
                    + "WHERE PurchaseID = " + file.ID;
                    clsSQL.nonQuery(sql);
                    clearPurchases();
                    //review the data
                    readPurchases("SELECT * FROM Purchase");

                }
            }
        }
    }
        
    //******************* Validation Helper Methods *********************

    // The overloaded validateInput helper method handles just the existence check for any data item.
    private bool validateInput(TextBox txtInput)
    {
        string fieldName;
        fieldName = txtInput.Name.Substring(3);
        if (txtInput.Text == "")
        {
            ShowMessage("Please enter a value for " + fieldName);
            txtInput.Focus();
            return false;
        }
        return true;
    }

    // The overloaded validateInput helper methods handle the existence check, type check, and range check for a given 
    // input form object and assigns the equivalent value to its corresponding variable. (This one handles int data.)
    private bool validateInput(TextBox txtInput, int min, int max, out int userInput)
    {
        string fieldName;
        fieldName = txtInput.Name.Substring(3);
        userInput = 0;
        if (txtInput.Text == "")
        {
            ShowMessage("Please enter a value for " + fieldName);
            txtInput.Focus();
            return false;
        }
        if (int.TryParse(txtInput.Text, out userInput) == false)
        {
            ShowMessage("Only numbers are allowed for " + fieldName + ". Please re-enter:");
            txtInput.Focus();
            return false;
        }
        if (userInput < min || userInput > max)
        {
            ShowMessage(fieldName + " must be between " + min.ToString() + " and " + max.ToString());
            txtInput.Focus();
            return false;
        }
        return true;
    }

    // The overloaded validateInput helper methods handle the existence check, type check, and range check for a given 
    // input form object and assigns the equivalent value to its corresponding variable. (This one handles double data.)
    private bool validateInput(TextBox txtInput, double min, double max, out double userInput)
    {
        string fieldName;
        fieldName = txtInput.Name.Substring(3);
        userInput = 0D;
        if (txtInput.Text == "")
        {
            ShowMessage("Please enter a value for " + fieldName);
            txtInput.Focus();
            return false;
        }
        if (double.TryParse(txtInput.Text, out userInput) == false)
        {
            ShowMessage("Only numbers are allowed for " + fieldName + ". Please re-enter:");
            txtInput.Focus();
            return false;
        }
        if (userInput < min || userInput > max)
        {
            ShowMessage(fieldName + " must be between " + min.ToString() + " and " + max.ToString());
            txtInput.Focus();
            return false;
        }
        return true;
    }

    // The overloaded validateInput helper methods handle the existence check, type check, and range check for a given 
    // input form object and assigns the equivalent value to its corresponding variable. (This one handles decimal data.)
    private bool validateInput(TextBox txtInput, decimal min, decimal max, out decimal userInput)
    {
        string fieldName;
        fieldName = txtInput.Name.Substring(3);
        userInput = 0M;
        if (txtInput.Text == "")
        {
            ShowMessage("Please enter a value for " + fieldName);
            txtInput.Focus();
            return false;
        }
        if (decimal.TryParse(txtInput.Text, out userInput) == false)
        {
            ShowMessage("Only numbers are allowed for " + fieldName + ". Please re-enter:");
            txtInput.Focus();
            return false;
        }
        if (userInput < min || userInput > max)
        {
            ShowMessage(fieldName + " must be between " + min.ToString() + " and " + max.ToString());
            txtInput.Focus();
            return false;
        }
        return true;
    }

    // The overloaded validateInput helper methods handle the existence check, type check, and range check for a given 
    // input form object and assigns the equivalent value to its corresponding variable. (This one handles DateTime data.)
    private bool validateInput(TextBox txtInput, DateTime min, DateTime max, out DateTime userInput)
    {
        string fieldName;
        fieldName = txtInput.Name.Substring(3);
        userInput = DateTime.Parse("01/01/1900");
        if (txtInput.Text == "")
        {
            ShowMessage("Please enter a date in the format mm/dd/yyyy for " + fieldName);
            txtInput.Focus();
            return false;
        }
        if (DateTime.TryParse(txtInput.Text, out userInput) == false)
        {
            ShowMessage("Only dates are allowed for " + fieldName + ". Please re-enter:");
            txtInput.Focus();
            return false;
        }
        if (userInput < min || userInput > max)
        {
            ShowMessage(fieldName + " must be between " + min.ToShortDateString() + " and " + max.ToShortDateString());
            txtInput.Focus();
            return false;
        }
        return true;
    }

    // The overloaded validateInput helper methods handle the existence check for a given Boolean input form object 
    // and assigns the equivalent value to its corresponding variable. 
    private bool validateInput(TextBox txtInput, out bool userInput)
    {
        string fieldName;
        fieldName = txtInput.Name.Substring(3);
        userInput = false;
        if (txtInput.Text == "")
        {
            ShowMessage("Please enter a value for " + fieldName);
            txtInput.Focus();
            return false;
        }
        userInput = bool.Parse(txtInput.Text);
        return true;
    }

    // The overloaded validateInput helper method handles the existence check for a given string input form object 
    // and assigns the equivalent value to its corresponding variable. 
    private bool validateInput(TextBox txtInput, out string userInput)
    {
        string fieldName;
        fieldName = txtInput.Name.Substring(3);
        userInput = "";
        if (txtInput.Text == "")
        {
            ShowMessage("Please enter a value for " + fieldName);
            txtInput.Focus();
            return false;
        }
        userInput = txtInput.Text;
        return true;
    }

    //This button opens the file for the Purchase Application.
    //========================================================
    private void mnuFileOpen_Click(object sender, EventArgs e)
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

        readPurchases("SELECT * FROM Purchase");
    }
    
    //This button opens the Database for Purchase.
    //===========================================
    private void btnReadDB_Click(object sender, EventArgs e)
    {

    }

    //This button adds data to the Purchase application.
    //==================================================
    private void btnMediaAdd_Click_1(object sender, EventArgs e)
    {

        string purchaseType = cboPurchase.Text;

        string sql = "INSERT INTO Purchase (Cost, PaymentType, VendorID, PaymentDate) VALUES ("
            + clsSQL.ToSql(txtCost.Text) + ", "
            + clsSQL.ToSql(purchaseType) 
            + " , 1, "
            + clsSQL.ToSql(txtPurchaseDate.Text)
            + ");";

        clsSQL.nonQuery(sql);
        MessageBox.Show("Added record.");
        readPurchases("SELECT * FROM Purchase");
    }

    //This loads the Purchase form.
    //=============================
    private void frmPurchase_Load(object sender, EventArgs e)
    {
        if(File.Exists(clsSQL.DBFileName))
        {
            readPurchases("SELECT * FROM Purchase");
        }
    }

    //This adds color to the form.
    //============================
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

    //This is called when the form is resized.
    //=======================================
    private void frmPurchase_Resize(object sender, EventArgs e)
    {
        this.Invalidate();
    }

    //This button sorts the PaymentDate from Purchase.
    //================================================
    private void btnSort_Click(object sender, EventArgs e)
    {
        readPurchases("SELECT * FROM Purchase ORDER BY PaymentDate");
    }

    //This button looks up the PaymentDate data from Purchase.
    //========================================================
    private void btnLookup_Click(object sender, EventArgs e)
    {
        
        if (txtLookup.Text == "")
        {
            txtLookup.Text = "%";
        }
        else
        {
            readPurchases("SELECT * FROM Purchase WHERE PaymentDate LIKE " + clsSQL.ToSql(txtLookup.Text + "%"));
        }

    }

    private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
    {
        MessageBox.Show("MediaDB - Developed for the Spring 2015 CNIT 252 course.\n\nCreated by:\nIshmael Charles (Purchase Information)\nMiranda Lung (Media Information)\nKyle Precht (Vendor Information)", "About MediaDB", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void howToUseToolStripMenuItem_Click(object sender, EventArgs e)
    {
        MessageBox.Show("Use the Purchase form to update information on your purchases, including the amount spent, the date of the purchase, and the payment method used.", "MediaDB: How to Use", MessageBoxButtons.OK, MessageBoxIcon.Question);
    }

    private void exitToolStripMenuItem_Click(object sender, EventArgs e)
    {
        Close();
    }

}