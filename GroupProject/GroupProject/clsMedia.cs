//Miranda Lung, CNIT 255 Group Project
//Last edited 4/29/2015
using System;

public class clsMedia
//Class for media objects: DVDs, books, movies, etc.
{
    private int myID;
    private string myTitle;
    private string myType;
    private string myCreator;
    private string myGenre;
    private double myLength;
    private int myRelease;
    private int myPurchaseID;
    

    public clsMedia()
    {
        myID = -1;
        myTitle = "";
        myType = "";
        myCreator = "";
        myGenre = "";
        myLength = 0;
        myRelease = 1900;
        myPurchaseID = 0;
        
    }

    public clsMedia(int id, string title, string type)
    {
        myID = id;
        myTitle = title;
        myType = type;
    }


    public clsMedia(int id, string title, string type, string creator, string genre, double length, int release, int purchaseID)
    {
        myID = id;
        myTitle = title;
        myType = type;
        myCreator = creator;
        myGenre = genre;
        myLength = length;
        myRelease = release;
        myPurchaseID = purchaseID;
    }

    public int ID
    {
        get { return myID; }
        set { myID = value; }
    }

    public string Title
    {
        get { return myTitle; }
        set { myTitle = value; }
    }

    public string Type
    {
        get { return myType; }
        set { myType = value; }
    }

    public string Creator
    {
        get { return myCreator; }
        set { myCreator = value; }
    }

    public string Genre
    {
        get { return myGenre; }
        set { myGenre = value; }
    }

    public double Length
    {
        get { return myLength; }
        set { myLength = value; }
    }


    public int Release
    {
        get { return myRelease; }
        set { myRelease = value; }
    }

    public int PurchaseID
    {
        get { return myPurchaseID; }
        set { myPurchaseID = value; }
    }


    public override string ToString()
    {
        return myTitle.PadRight(30) + myCreator.PadRight(22) + myGenre.PadRight(14) + myType.PadLeft(8);
    }
}