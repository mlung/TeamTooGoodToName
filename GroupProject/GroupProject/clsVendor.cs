public class clsVendor
{
    // class data members.

    private int aVendorID;
    private string aStoreName;
    private string aStoreCity;
    private string aStoreState;
    private string aStoreWebsite;

    // ----------- Class constructors ----------------

    public clsVendor()
    {
        aVendorID = 0;
        aStoreName = "";
        aStoreCity = "";
        aStoreState = "";
        aStoreWebsite = "";

    }

    public clsVendor(int vendorID, string storeName, string storeState, string storeCity, string storeWebsite)
    {
        aVendorID = vendorID;
        aStoreName = storeName;
        aStoreCity = storeState;
        aStoreState = storeCity;
        aStoreWebsite = storeWebsite;


    }
    // Purpose: Reads or writes the data members.

    public int VendorID
    {
        get
        {
            return aVendorID;
        }

        set
        {
            aVendorID = value;
        }
    }

    public string StoreName
    {
        get
        {
            return aStoreName;
        }

        set
        {
            aStoreName = value;
        }
    }

    public string StoreCity
    {
        get
        {
            return aStoreCity;
        }

        set
        {
            aStoreCity = value;
        }
    }

    public string StoreState
    {
        get
        {
            return aStoreState;
        }

        set
        {
            aStoreState = value;
        }
    }

    public string StoreWebsite
    {
        get
        {
            return aStoreWebsite;
        }

        set
        {
            aStoreWebsite = value;
        }
    }


}