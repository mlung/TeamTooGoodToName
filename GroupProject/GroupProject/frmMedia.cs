//MEDIA MANAGEMENT
//Miranda Lung

using System;
using System.Windows.Forms;
using System.IO; //File prompts
using System.Collections;
using System.Drawing;
using System.Drawing.Drawing2D;



public partial class frmMedia : Form
{
    string searchEngine = "google"; //The default search engine is Google.

    public frmMedia()
    {
        InitializeComponent();//Initialize - see frmMain.Designer.cs
    }

    private void btnExit_Click(object sender, EventArgs e)
    {
        Close();
    }


    private void openToolStripMenuItem_Click(object sender, EventArgs e)
    {
        OpenFileDialog ofd; //Create an OpenFileDialog for the user to select their DB
        try
        {
            ofd = new OpenFileDialog();
            ofd.Filter = "Client DB files (*.accdb)|*.accdb|All files (*.*)|*.*";
            ofd.InitialDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Database");
            ofd.InitialDirectory = AppDomain.CurrentDomain.BaseDirectory;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                clsSQL.DBFileName = ofd.FileName; //Using clsSQL.DBFileName, a static member, so the same file is open across all forms.
            }
        }

        catch (Exception ex)
        {
            MessageBox.Show("An unexpected error has occurred while attempting to open this file." + Environment.NewLine + Environment.NewLine
            + "Error Message:" + Environment.NewLine
            + ex.Message);
        }

        if (File.Exists(clsSQL.DBFileName))
        { refreshMedia(); } //Make sure the DB file exists before refreshing the media.
    }
    
    private void btnMediaAdd_Click(object sender, EventArgs e)
    {
        //Temporary variables
        string mediaName;
        string mediaType;
        string mediaCreator;
        string mediaGenre;
        double mediaLength;
        int mediaYear;
        int purchaseId;

        //Validation below. Using OR arguments to simplify and abbreviate the code.
        if(!clsValidate.validateInput(txtMediaName, out mediaName)
            || !clsValidate.validateInput(cboMediaType)
            || !clsValidate.validateInput(txtMediaCreator, out mediaCreator)
            || !clsValidate.validateInput(txtMediaGenre, out mediaGenre)
            || !clsValidate.validateInput(txtMediaLength, 0, 5000, out mediaLength) 
            || !clsValidate.validateInput(txtMediaYear, 1500, 2200, out mediaYear)
            || !clsValidate.validateInput(cboPurchase))
        {
            return;
        }

        //Set the values that are contained in combo boxes.
        mediaType = cboMediaType.Text; 
        clsComboBoxItem item = (clsComboBoxItem)cboPurchase.SelectedItem;
        purchaseId = item.ID;

        string sql = "INSERT INTO Media (Title, Type, Creator, Genre, Length, ReleaseYear, PurchaseID) VALUES ("
            + clsSQL.ToSql(mediaName) + ", "
            + clsSQL.ToSql(mediaType) + ", " 
            + clsSQL.ToSql(mediaCreator) + ", "
            + clsSQL.ToSql(mediaGenre) + ", "
            + clsSQL.ToSql(mediaLength) + ", "
            + clsSQL.ToSql(mediaYear) + ", "
            + clsSQL.ToSql(purchaseId)
            + ");";

        clsSQL.nonQuery(sql); //Use clsSQL.nonQuery, a static function, to run our non-query statement.
        MessageBox.Show("Added record.");
        refreshMedia();
    }

    private void lstMedia_SelectedIndexChanged(object sender, EventArgs e)
    {
        if(!isValid(lstMedia.SelectedIndex))
        {
            return; //If it isn't a valid record, ignore the input and return to the user
        }

        //Copy the information from the selected media to each input box.
        clsMedia selectedMedia =  (clsMedia)clsLists.media[lstMedia.SelectedIndex - 1];
        txtMediaName.Text = selectedMedia.Title;
        cboMediaType.Text = selectedMedia.Type;
        txtMediaCreator.Text = selectedMedia.Creator;
        txtMediaGenre.Text = selectedMedia.Genre;
        txtMediaLength.Text = selectedMedia.Length.ToString();
        txtMediaYear.Text = selectedMedia.Release.ToString();
        cboPurchase.SelectedIndex = findPurchase(selectedMedia.PurchaseID);
        
        //Give the user information.
        MessageBox.Show("For more information on this media, click 'More Info.'\n\nTo update this record, change the details and click 'Update'.\n\nTo delete this record, click 'Delete'.");
        
        //Change the search engine based on the media's type.
        if(selectedMedia.Type.Equals("DVD") ||
            selectedMedia.Type.Equals("Blu-Ray") ||
            selectedMedia.Type.Equals("Video")
            )
        {
            searchEngine = "imdb";
        }

        else if(selectedMedia.Type.Equals("Book"))
        {
            searchEngine = "amazon";
        }

        else if (selectedMedia.Type.Equals("Music") ||
            selectedMedia.Type.Equals("CD") ||
            selectedMedia.Type.Equals("Album"))
        {
            searchEngine = "allmusic";
        }

        else if(selectedMedia.Type.Equals("Game"))
        {
            searchEngine = "mobygames";
        }

        else //Especially handy if the user manually entered a different type of media.
        {
            searchEngine = "google";
        }
    }

    private void btnMediaUpdate_Click(object sender, EventArgs e)
    {
        //See btnMediaAdd_Click for comments.

        string mediaName;
        string mediaType;
        string mediaCreator;
        string mediaGenre;
        double mediaLength;
        int mediaYear;
        int purchaseId;

        //Validation below. Using OR arguments to simplify and abbreviate the code.
        if (!clsValidate.validateInput(txtMediaName, out mediaName)
            || !clsValidate.validateInput(cboMediaType)
            || !clsValidate.validateInput(txtMediaCreator, out mediaCreator)
            || !clsValidate.validateInput(txtMediaGenre, out mediaGenre)
            || !clsValidate.validateInput(txtMediaLength, 0, 5000, out mediaLength)
            || !clsValidate.validateInput(txtMediaYear, 1500, 2200, out mediaYear)
            || !clsValidate.validateInput(cboPurchase))
        {
            return;
        }

        if (!isValid(lstMedia.SelectedIndex))
        {
            return; //If it isn't a valid record, ignore the input and return to the user
        }
        
        mediaType = cboMediaType.Text;
        clsComboBoxItem item = (clsComboBoxItem)cboPurchase.SelectedItem;
        purchaseId = item.ID;

        clsMedia selectedMedia = (clsMedia)clsLists.media[lstMedia.SelectedIndex - 1];
        
        string sql = "UPDATE Media SET "
            + "Title = " + clsSQL.ToSql(mediaName) + ", "
            + "Type = " + clsSQL.ToSql(mediaType) + ", "
            + "Creator = " + clsSQL.ToSql(mediaCreator) + ", "
            + "Genre = " + clsSQL.ToSql(mediaGenre) + ", "
            + "Length = " + clsSQL.ToSql(mediaLength) + ", "
            + "ReleaseYear = " + clsSQL.ToSql(mediaYear) + ", "
            + "PurchaseID = " + clsSQL.ToSql(purchaseId) + " "
            + "WHERE MediaID = " + selectedMedia.ID;
        
        clsSQL.nonQuery(sql);
        MessageBox.Show("Updated record.");
        refreshMedia();
    }

    private void btnMediaDelete_Click(object sender, EventArgs e)
    {
        if (!isValid(lstMedia.SelectedIndex))
        {
            return; //If it isn't a valid record, ignore the input and return to the user
        }

        clsMedia selectedMedia = (clsMedia)clsLists.media[lstMedia.SelectedIndex - 1];

        string sql = "DELETE FROM Media WHERE MediaID = " + selectedMedia.ID + ";";
        clsSQL.nonQuery(sql);
        MessageBox.Show("Deleted record.");
        refreshMedia();
    }

    //Form helper methods
    private void refreshMedia()
    {
        clsLists.media = clsSQL.queryMedia("SELECT * FROM Media;");
        displayArrays();
    }

    private void selectMedia(string sql)
    {
        clsLists.media = clsSQL.queryMedia(sql);
        displayArrays();
    }

    private void displayArrays()
    {
        lstMedia.Items.Clear();

        lstMedia.Items.Add("Title".PadRight(30) + "Creator".PadRight(22) + "Genre".PadRight(14) + "Type".PadLeft(8));

        foreach (clsMedia m in clsLists.media)
        {
            lstMedia.Items.Add(m);
        }

        populatePurchases();
    }

    //isValid is a quick way to find out if a location selected in lstMedia exists in the arraylist clsLists.media
    private bool isValid(int loc)
    {
        if (loc < 1 || loc > clsLists.media.Count)
        {
            return false;
        }
        else { return true; }
    }

    //Clears all boxes on the form, and the clsLists.media arraylist.
    private void btnMediaClear_Click(object sender, EventArgs e)
    {
        clsLists.media.Clear();
        lstMedia.Items.Clear();
        txtMediaName.Clear();
        cboMediaType.SelectedIndex = -1;
        txtMediaCreator.Clear();
        txtMediaGenre.Clear();
        txtMediaLength.Clear();
        txtMediaYear.Clear();
        cboPurchase.Items.Clear();        
    }

    //Opens the user's default browser to a search engine page relevant to their selected media.
    private void btnMediaMoreInfo_Click(object sender, EventArgs e)
    {
        if (!isValid(lstMedia.SelectedIndex)) //Check the selected item's validity.
        {
            MessageBox.Show("Please select media from the list box in order to retrieve information.");
            return;
        }

        clsMedia media = (clsMedia)clsLists.media[lstMedia.SelectedIndex - 1];
        string search = media.Title.Replace(' ','+');
  
        if(searchEngine.Equals("amazon"))
        {
            System.Diagnostics.Process.Start("http://www.amazon.com/s/url=search-alias%3Daps&field-keywords=" + search);
        }

        else if(searchEngine.Equals("imdb"))
        {
            System.Diagnostics.Process.Start("http://www.imdb.com/find?ref_=nv_sr_fn&q=" + search);
        }

        else if(searchEngine.Equals("allmusic"))
        {
            System.Diagnostics.Process.Start("http://www.allmusic.com/search/all/" + search);
        }

        else if(searchEngine.Equals("mobygames"))
        {
            System.Diagnostics.Process.Start("http://www.mobygames.com/search/quick?q=" + search);
        }
        
        else
        {
            System.Diagnostics.Process.Start("https://www.google.com/?q=" + search);
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

    private void frmMedia_Resize(object sender, EventArgs e)
    {
        this.Invalidate();
    }

    //Sorts based on the selected item in the cboSortType combo box - or if there is nothing selected in the box, does nothing.
    private void btnMediaSort_Click(object sender, EventArgs e)
    {
        if(clsLists.media.Count < 1)
        {
            MessageBox.Show("Please add or load media to sort.");
            return;
        }

        if(cboSortType.Text.Equals("Default"))
        {
            refreshMedia();
        }

        else if(cboSortType.Text.Equals("Title"))
        {
            selectMedia("SELECT * FROM Media ORDER BY Title;");
        }

        else if(cboSortType.Text.Equals("Type"))
        {
            selectMedia("SELECT * FROM Media ORDER BY Type;");
        }
    }

    //Called on the form's load
    private void frmMedia_Load(object sender, EventArgs e)
    {
        if(File.Exists(clsSQL.DBFileName)) //If we've loaded a filename and it exists on the form's load, let's load the data automatically
        {
            refreshMedia();
        }
    }

    //Provides help for this form.
    private void lblSearchHelp_Click(object sender, EventArgs e)
    {
        MessageBox.Show("Enter the title of the media you wish to search for in the box next to the 'Search' label, then click the 'Search' button to find your title.\n\n% acts as a wildcard in all searches.",
            "MediaDB Help: Search", MessageBoxButtons.OK, MessageBoxIcon.Question);
    }

    //Information about the program.
    private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
    {
        MessageBox.Show("MediaDB - Developed for the Spring 2015 CNIT 252 course.\n\nCreated by:\nIshmael Charles (Purchase Information)\nMiranda Lung (Media Information)\nKyle Precht (Vendor Information)", "About MediaDB", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    //Runs a search based on the user's input when clicked.
    private void btnMediaSearch_Click(object sender, EventArgs e)
    {
        if(!File.Exists(clsSQL.DBFileName))
        {
            MessageBox.Show("Please open a valid database before searching.");
            return;
        }
        if(txtMediaSearch.Text.Trim().Length < 1) //Use Text.Trim to make sure the user doesn't search for an empty space.
        {
            MessageBox.Show("Please enter a title to search for.");
            return;
        }

        //Run the search with this SQL query.
        string search = "SELECT * FROM Media " +
            "AND Title LIKE " + clsSQL.ToSql("%" + txtMediaSearch.Text + "%") + ";";

        selectMedia(search); //selectMedia will update the listing. We're done.
    }

    //Provides contextual help on user input (clicking)
    private void lbHelpLength_Click(object sender, EventArgs e)
    {
        MessageBox.Show("Length should be in pages for books, minutes for movies and music, and estimated hours of playtime for a video game.",
            "MediaDB: Help on Length", MessageBoxButtons.OK, MessageBoxIcon.Question);
    }

    //Provides contextual help on user input (clicking)

    private void howToUseToolStripMenuItem_Click(object sender, EventArgs e)
    {
        MessageBox.Show("Open your media database using File > Open.\n\nSelect a piece of media in your library to update or delete that media's information.\n\nEnter your media information and click 'Add' to add a piece of media to your database.\n\nSelect media from the list and click 'More Info' to search the Internet for more information on your selected media.","MediaDB: How to Use",MessageBoxButtons.OK, MessageBoxIcon.Question);
    }

    private void exitToolStripMenuItem_Click(object sender, EventArgs e)
    {
        Close();
    }

    private void populatePurchases()
    {
        //Refresh the list of purchases...
        cboPurchase.Items.Clear();
        clsLists.mPurchase = clsSQL.queryPurchase("SELECT * FROM Purchase;");
        foreach(clsPurchase purchase in clsLists.mPurchase)
        {
            clsPurchase p = (clsPurchase)purchase;
            clsComboBoxItem item = new clsComboBoxItem(p.ID, "#" + p.ID.ToString() + "( " + p.PaymentDate.ToString());
            cboPurchase.Items.Add(item);
        }
    }

    //Finds a specific purchase record within the cboPurchase combo box.
    private int findPurchase(int checkID)
    {
        int i = 0;
        int found = -1; //Loop through and set found to the combo box index
        while (i < cboPurchase.Items.Count && found == -1)
        {
            clsComboBoxItem item = (clsComboBoxItem)cboPurchase.Items[i];
            if(item.ID == checkID)
            {
                found = i;
            }
            i++;
        }

        if(found == -1)
        {
            MessageBox.Show("Could not find a purchase that corresponds to your selected media. Please select a valid purchase for your media and update your information.");
            cboPurchase.Focus();
            found = 0; 
        }

        return found;
    }
}