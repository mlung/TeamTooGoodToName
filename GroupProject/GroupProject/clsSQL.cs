using System;
using System.Windows.Forms;
using System.Configuration; //Config file
using System.Data.OleDb; //Database connectivity
using System.Collections;
using System.IO; //For saving/loading most recent DB filename

public static class clsSQL //Static: Only one instance of this across the entire application!
{
    public static OleDbConnection mdb = new OleDbConnection();
    private static string dbFilename = "";

    public static ArrayList queryVendor(string sql)
    {
        ArrayList vendor = new ArrayList();
        try
        {
            openDatabaseConnection();
            mdb.Open();
            OleDbCommand cmd;
            cmd = new OleDbCommand(sql, mdb);
            OleDbDataReader rdr;
            rdr = cmd.ExecuteReader();
            while (rdr.Read() == true)
            {
                clsVendor newVendor = new clsVendor((int)rdr["VendorID"], (string)rdr["StoreName"], (string)rdr["StoreCity"], (string)rdr["StoreState"], (string)rdr["StoreWebsite"]);
                vendor.Add(newVendor);
            }
            rdr.Close();
        }
        catch (Exception ex)
        {
            MessageBox.Show("There was an unexpected problem reading from the DB: " +
                 ex.Message);
        }
        finally
        {
            closeDatabaseConnection();
        }
        return vendor;
    }

    public static ArrayList queryPurchase(string sql)
    {
        ArrayList purchases = new ArrayList();
        try
        {
            openDatabaseConnection();
            mdb.Open();
            OleDbCommand cmd;
            cmd = new OleDbCommand(sql, mdb);
            OleDbDataReader rdr;
            rdr = cmd.ExecuteReader();
            while (rdr.Read() == true)
            {
                clsPurchase newPurchases = new clsPurchase((int)rdr["PurchaseID"], (decimal)rdr["Cost"], (string)rdr["PaymentType"], (DateTime)rdr["PaymentDate"]);
                purchases.Add(newPurchases);
            }
            rdr.Close();
        }
        catch (Exception ex)
        {
            MessageBox.Show("There was an unexpected problem reading from the DB: " +
                 ex.Message);
        }
        finally
        {
            closeDatabaseConnection();
        }
        return purchases;
    }

    public static ArrayList queryMedia(string sql)
    {
        ArrayList media = new ArrayList();
        try
        {
            openDatabaseConnection();
            mdb.Open();
            OleDbCommand cmd;
            cmd = new OleDbCommand(sql, mdb);
            OleDbDataReader rdr;
            rdr = cmd.ExecuteReader();
            while (rdr.Read() == true)
            {
                clsMedia newMedia = new clsMedia((int)rdr["MediaID"], 
                    (string)rdr["Title"],
                    (string)rdr["Type"], 
                    (string)rdr["Creator"],
                    (string)rdr["Genre"],
                    (double)rdr["Length"],
                    (int)rdr["ReleaseYear"],
                    (int)rdr["PurchaseID"]);
                media.Add(newMedia);
            }
            rdr.Close();
        }
        catch (Exception ex)
        {
            MessageBox.Show("There was an unexpected problem reading from the DB: " +
                 ex.Message);
        }
        finally
        {
            closeDatabaseConnection();
        }
        return media;
    }

    public static void nonQuery(string sql)
    {
        try
        {
            openDatabaseConnection();
            mdb.Open();
            OleDbCommand cmd;
            cmd = new OleDbCommand(sql, mdb);
            cmd.ExecuteNonQuery();
        }
        catch (Exception ex)
        {
            MessageBox.Show("There was an unexpected problem writing to the DB: " +
                 ex.Message);
        }
        finally
        {
            closeDatabaseConnection();
        }
    }

    private static void openDatabaseConnection()
    {
        string connectionString = ConfigurationManager.AppSettings["DBConnectionString"] + dbFilename;
        mdb = new OleDbConnection(connectionString);
    }

    private static void closeDatabaseConnection()
    {
        if (mdb != null)
        {
            mdb.Close();
        }
    }

    public static string DBFileName
    {
        set { //TODO: Make this more robust in checking for invalid values

            dbFilename = value; 
            try
            {
                if(File.Exists("lastopened.txt"))
                {
                    File.Delete("lastopened.txt");
                }

                File.WriteAllText("lastopened.txt", value); 

            }
            catch (Exception ex)
            {
                File.Delete("lastopened.txt"); //Delete the file just in case it's broken.
                MessageBox.Show(ex.Message + "\n\n\n" + ex.StackTrace);
                return; //Don't let the user know it happened
            }
        }
        get { return dbFilename; }
    }

    //Helper methods by Alka Harriger
    public static string ToSql(bool boolValue)
    {
        return boolValue.ToString();
    }

    public static string ToSql(DateTime dateTimeValue)
    {
        return "'" + dateTimeValue.ToShortDateString() + "'";
    }

    public static string ToSql(decimal decimalValue)
    {
        return decimalValue.ToString();
    }

    public static string ToSql(int intValue)
    {
        return intValue.ToString();
    }

    public static string ToSql(double doubleValue)
    {
        return doubleValue.ToString();
    }

    // For strings, the Replace helps handle the embedded quotes problem
    public static string ToSql(string stringValue)
    {
        return "'" + stringValue.Replace("'", "''") + "'";
    }
}