using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class clsPurchase
{
    private int mID;
    private decimal mCost;
    private string mPaymentType;
    private DateTime mPaymentDate;
    public clsPurchase()
    {
        mID = 0;
        mCost = 0.00M;
        mPaymentType = "";
        mPaymentDate = Convert.ToDateTime("");
    }

    public clsPurchase(int ID, decimal cost, string PaymentType, DateTime PaymentDate)
    {
        mID = ID;
        mCost = cost;
        mPaymentType = PaymentType;
        mPaymentDate = PaymentDate;
    }

    public int ID
    {
        get
        {
            return mID;
        }
        set
        {
            mID = value;
        }
    }

    public decimal cost
    {
        get
        {
            return mCost;
        }
        set
        {
            mCost = value;
        }
    }

    public string PaymentType
    {
        get
        {
            return mPaymentType;
        }
        set
        {
            mPaymentType = value;
        }
    }

    public DateTime PaymentDate
    {
        get
        {
            return mPaymentDate;
        }
        set
        {
            mPaymentDate = value;
        }
    }

    public override string ToString()
    {
        return ID.ToString().PadRight(8) + cost.ToString("C").PadRight(8) + PaymentType.PadRight(10) + PaymentDate.ToString("d").PadLeft(15);
    }
}

