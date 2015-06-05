//VENDOR MANAGEMENT
using System;
using System.Windows.Forms;
using System.IO; //File prompts
using System.Collections;
using System.Threading;
using System.Data.OleDb;                  // For OLE DB
using System.Configuration;               // To access app.config data
using System.Drawing;
using System.Drawing.Drawing2D;

public partial class frmVendor : Form
{

    
    private OleDbConnection mDB;                    // To access the DB data

    string StoreName;
    string StoreCity;
    string StoreState;
    string StoreWebsite;
    string search;
    int countSort = 1;

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

    }

    //Used to open database and display the elements of database.

    private void mnuFileOpenVendor_Click(object sender, EventArgs e)
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
            else
            {
                return;
            }
        }

        catch (Exception ex)
        {
            MessageBox.Show("An unexpected error has occurred while attempting to open this file." + Environment.NewLine + Environment.NewLine
            + "Error Message:" + Environment.NewLine
            + ex.Message);
        }

        restoreVendor("SELECT * FROM Vendor");

        displayElements();
        txtStoreName.Focus();
    }

    //Used to exit the vendor form.

    private void mnuFileExitVendor_Click(object sender, EventArgs e)
    {
        Close();
    }

    // Add vendor information to vendor database.

    private void btnAddVendor_Click(object sender, EventArgs e)
    {

        string sql;

        if (!clsValidate.validateInput(txtStoreName, out StoreName))
            return;
        if (!clsValidate.validateInput(txtStoreCity, out StoreCity))
            return;
        if (!clsValidate.validateInput(txtStoreState, out StoreState))
            return;
        if (!clsValidate.validateInput(txtStoreWebsite, out StoreWebsite))
            return;

        //Open database connection and insert sql with values inside of text boxes.

        try
        {

            openDatabaseConnection();
            mDB.Open();
            OleDbCommand cmd;
            sql = "INSERT INTO Vendor (StoreName, StoreCity, StoreState, StoreWebsite) VALUES ("
                + clsSQL.ToSql(txtStoreName.Text) + ", "
                + clsSQL.ToSql(txtStoreCity.Text) + ", "
                + clsSQL.ToSql(txtStoreState.Text) + ", "
                + clsSQL.ToSql(txtStoreWebsite.Text)
                + " );";
            cmd = new OleDbCommand(sql, mDB);
            cmd.ExecuteNonQuery();
        }
        catch (Exception ex)
        {
            clsValidate.ShowMessage("There was an unexpected error: " + ex.Message);
        }
        finally
        {
            closeDatabaseConnection();
        }
        restoreVendor("SELECT * FROM Vendor");

        displayElements();

        clsValidate.ShowMessage("The vendor was added to the database");

        txtStoreName.Clear();
        txtStoreCity.Clear();
        txtStoreState.Clear();
        txtStoreWebsite.Clear();
        txtStoreName.Focus();
        txtSearch.Clear();
    }

    private void btnUpdateVendor_Click(object sender, EventArgs e)
    {
        //Code to update Selected record

        string sql;
        int locUpdate = lstVendor.SelectedIndex - 2; // account for two-line header

        // Make sure a valid client was selected
        if (locUpdate < 0 || locUpdate > (clsLists.vendor.Count - 1))
        {
            clsValidate.ShowMessage("Please select a valid vendor in the list to modify.");
            lstVendor.SelectedIndex = -1;
            return;
        }
        if (!clsValidate.validateInput(txtStoreName, out StoreName))
            return;
        if (!clsValidate.validateInput(txtStoreCity, out StoreCity))
            return;
        if (!clsValidate.validateInput(txtStoreState, out StoreState))
            return;
        if (!clsValidate.validateInput(txtStoreWebsite, out StoreWebsite))
            return;

        // Confirm the record update 
        if (MessageBox.Show("Please confirm that you wish to update the record for " + txtStoreName.Text, "Confirm Update",
            MessageBoxButtons.YesNo) == DialogResult.No)
        {
            MessageBox.Show("Update request ignored.");
            lstVendor.SelectedIndex = -1;
            return;
        }

        // Update the record with sql code.
        try
        {
            clsVendor vendor = (clsVendor)clsLists.vendor[locUpdate];
            openDatabaseConnection();
            mDB.Open();
            OleDbCommand cmd;
            sql = "UPDATE Vendor SET "
               + "StoreName = " + clsSQL.ToSql(txtStoreName.Text) + ", "
                + "StoreCity = " + clsSQL.ToSql(txtStoreCity.Text) + ", "
                + "StoreState = " + clsSQL.ToSql(txtStoreState.Text) + ", "
                + "StoreWebsite = " + clsSQL.ToSql(txtStoreWebsite.Text)
                + "WHERE [VendorID] = " + vendor.VendorID;

            cmd = new OleDbCommand(sql, mDB);
            cmd.ExecuteNonQuery();
        }
        catch (Exception ex)
        {
            clsValidate.ShowMessage("There was an unexpected error: " + ex.Message);
        }
        finally
        {
            closeDatabaseConnection();
        }

        restoreVendor("SELECT * FROM Vendor");

        displayElements();

        clsValidate.ShowMessage("The record was updated");

        txtStoreName.Clear();
        txtStoreCity.Clear();
        txtStoreState.Clear();
        txtStoreWebsite.Clear();
        txtStoreName.Focus();
        txtSearch.Clear();
        
    }

    private void btnDeleteVendor_Click(object sender, EventArgs e)
    {
        //Code to Delete the selected record      
        string sql;
        int locDelete = lstVendor.SelectedIndex - 2; // account for two-line header

        // Make sure a valid client was selected
        if (locDelete < 0 || locDelete > (clsLists.vendor.Count - 1))
        {
            clsValidate.ShowMessage("Please select a valid vendor in the list to remove.");
            lstVendor.SelectedIndex = -1;
            return;
        }
        if (MessageBox.Show("Please confirm that you wish to delete the record for " + txtStoreName.Text, "Confirm Delete",
           MessageBoxButtons.YesNo) == DialogResult.No)
        {
            MessageBox.Show("Delete request ignored.");
            lstVendor.SelectedIndex = -1;
            return;
        }

        clsVendor vendor = (clsVendor)clsLists.vendor[locDelete];
        // Remove the vendor from the DB
        try
        {
            openDatabaseConnection();
            mDB.Open();
            sql = "DELETE FROM Vendor WHERE [VendorID] =" + vendor.VendorID;

            OleDbCommand cmd = new OleDbCommand(sql, mDB);
            cmd.ExecuteNonQuery();
        }
        catch (Exception ex)
        {
            clsValidate.ShowMessage("There was an unexpected problem removing the vendor from the DB" + ex.Message);
        }
        finally
        {
            closeDatabaseConnection();
        }

        restoreVendor("SELECT * FROM Vendor");

        displayElements();

        clsValidate.ShowMessage("The vendor was removed from the database");
        txtStoreName.Clear();
        txtStoreCity.Clear();
        txtStoreState.Clear();
        txtStoreWebsite.Clear();
        txtStoreName.Focus();
        txtSearch.Clear();
    }

    // Clear user input as well as vendor list box and array list
    private void btnClearVendor_Click(object sender, EventArgs e)
    {
        clsLists.vendor.Clear();
        lstVendor.Items.Clear();
        txtStoreName.Clear();
        txtStoreCity.Clear();
        txtStoreState.Clear();
        txtStoreWebsite.Clear();
        txtStoreName.Focus();
        txtSearch.Clear();
    }

    private void btnVendorExit_Click(object sender, EventArgs e)
    {
        Close();
    }

    private void restoreVendor(string sql)
    {
        clsLists.vendor.Clear();              //Start with an empty ArrayList

        // Restore information from vendor database using a data reader.
        try
        {
            openDatabaseConnection();
            mDB.Open();
            OleDbCommand cmd;
            cmd = new OleDbCommand(sql, mDB);
            OleDbDataReader rdr;
            rdr = cmd.ExecuteReader();
            while (rdr.Read() == true)
            {
                clsVendor ven = new clsVendor((int)rdr["VendorID"],
                    (string)rdr["StoreName"], (string)rdr["StoreCity"], (string)rdr["StoreState"], (string)rdr["StoreWebsite"]);
                clsLists.vendor.Add(ven);
            }
            rdr.Close();
        }
        catch (Exception ex)
        {
            clsValidate.ShowMessage("There was an unexpected problem reading from the DB: " + ex.Message);
        }
        finally
        {
            closeDatabaseConnection();
        }
    }

    // Display the elements of the vendor database in the list box.

    private void displayElements()
    {
        string currentRow;

        if (clsLists.vendor.Count == 0)
        {
            MessageBox.Show("There are no vendors to display. Please add some vendors.");
            txtStoreName.Focus();
            return;
        }

        lstVendor.Items.Clear();


        // Two lines added to top of list box.
        lstVendor.Items.Add("Store Name" + "               " + "Store City" + "           " + "Store State");
        lstVendor.Items.Add("===========================================================");

        foreach (clsVendor vendors in clsLists.vendor)
        {
            currentRow = vendors.StoreName.ToString().PadRight(25)
            + vendors.StoreCity.PadRight(25)
            + vendors.StoreState.PadRight(25);
            lstVendor.Items.Add(currentRow);
        }
    }

    // This helper method is used to open a connection to the database.
    private void openDatabaseConnection()
    {
        string connectionString = ConfigurationManager.AppSettings["DBConnectionString"] + clsSQL.DBFileName;
        mDB = new OleDbConnection(connectionString);
    }

    // This helper method releases the DB connection.
    private void closeDatabaseConnection()
    {
        if (mDB != null)
        {
            mDB.Close();
        }
    }

    // Set the selected index of the list box to populate data in the appropriate textboxes.

    private void lstVendor_SelectedIndexChanged_1(object sender, EventArgs e)
    {
        int locSelected = lstVendor.SelectedIndex - 2;

        if (locSelected < 0 || locSelected > (clsLists.vendor.Count - 1))
        {
            clsValidate.ShowMessage("Please select a valid Vendor.");
            lstVendor.SelectedIndex = -1;
            return;
        }

        clsVendor vendor = (clsVendor)clsLists.vendor[locSelected];

        txtStoreName.Text = vendor.StoreName;
        txtSearch.Text = vendor.StoreName;
        txtStoreCity.Text = vendor.StoreCity;
        txtStoreState.Text = vendor.StoreState;
        txtStoreWebsite.Text = vendor.StoreWebsite;
        txtStoreName.Focus();
    }

    private void mnuFileSaveVendor_Click(object sender, EventArgs e)
    {

    }


    // Open a browser and go to the website of the selected index.
    private void btnWebsite_Click(object sender, EventArgs e)
    {
        int locSelected = lstVendor.SelectedIndex - 2;

        if (locSelected < 0 || locSelected > (clsLists.vendor.Count - 1))
        {
            clsValidate.ShowMessage("Please select a valid Vendor.");
            lstVendor.SelectedIndex = -1;
            return;
        }

        clsVendor vendor = (clsVendor)clsLists.vendor[locSelected];

        System.Diagnostics.Process.Start("http://" + vendor.StoreWebsite);


    }

    private void frmVendor_Load(object sender, EventArgs e)
    {
        if(File.Exists(clsSQL.DBFileName))
        {
            restoreVendor("SELECT * FROM Vendor;");
            displayElements();
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

    private void frmVendor_Resize(object sender, EventArgs e)
    {
        this.Invalidate(); 
    }


    // Search vendor names located within the database.
    private void btnSearch_Click(object sender, EventArgs e)
    {
        string sql;

        if (!clsValidate.validateInput(txtSearch, out search))
        {
            clsValidate.ShowMessage("Please enter name of the vendor to search.");
            return;
        }


        // Write the SQL to do search with provided names

        sql = "SELECT * FROM Vendor WHERE StoreName LIKE " + clsSQL.ToSql("%" + search + "%");

        restoreVendor(sql);

        displayElements();

        btnUndoSearch.Enabled = true;

    }


    // Sort vendor names using 1 click to sort ascending and 2 clicks to sort descending.
    private void btnSort_Click(object sender, EventArgs e)
    {
        if (countSort == 1)
        {
            clsSortVendorName sortByName = new clsSortVendorName();
            clsLists.vendor.Sort(sortByName);

            displayElements();
            countSort = 2;
        }

        else if (countSort == 2)
        {
            clsSortVendorNameDesc sortByName = new clsSortVendorNameDesc();
            clsLists.vendor.Sort(sortByName);

            displayElements();
            countSort = 1;
        }
    }

    // Undo the search done with the search button.  Disables use after pressing.
    private void btnUndoSearch_Click(object sender, EventArgs e)
    {
        string sql = "SELECT * FROM Vendor";

        restoreVendor(sql);

        displayElements();

        txtSearch.Clear();
        txtSearch.Focus();

        btnUndoSearch.Enabled = false;
    }

    private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
    {
        MessageBox.Show("MediaDB - Developed for the Spring 2015 CNIT 252 course.\n\nCreated by:\nIshmael Charles (Purchase Information)\nMiranda Lung (Media Information)\nKyle Precht (Vendor Information)", "About MediaDB", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void howToUseToolStripMenuItem_Click(object sender, EventArgs e)
    {
        MessageBox.Show("Select a vendor from the list in order to maintain information on that vendor or to visit that vendor's website by clicking 'Website'.", "MediaDB: How to Use", MessageBoxButtons.OK, MessageBoxIcon.Question);
    }

}