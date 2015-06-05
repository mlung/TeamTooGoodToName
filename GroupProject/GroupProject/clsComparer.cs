//By Ishmael Charles
using System;
using System.Collections;

// Add The classes to perform sorting by various fields
// of a client record in either ascending or descending order

public class clsSortVendorName : IComparer
{
    int IComparer.Compare(object object1, object object2)
    {
        clsVendor name1 = (clsVendor)object1;
        clsVendor name2 = (clsVendor)object2;
        return name1.StoreName.CompareTo(name2.StoreName);
    }
}

public class clsSortVendorNameDesc : IComparer
{
    int IComparer.Compare(object object1, object object2)
    {
        clsVendor name1 = (clsVendor)object1;
        clsVendor name2 = (clsVendor)object2;
        return -(name1.StoreName.CompareTo(name2.StoreName));
    }
}