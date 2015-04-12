using System;
using System.Configuration; //Config file
using System.Data.OleDb; //Database connectivity
using System.Collections;

public class clsSQL
{
    public static ArrayList queryVendor (string sql)
    {
        ArrayList vendors = new ArrayList();
        return vendors;
    }

    private void openDatabaseConnection(OleDbConnection db)
    {
        //string connectionString = ConfigurationManager.AppSettings["DBConnectionString"] + gFilename;
        //db = new OleDbConnection(connectionString);
    }
}