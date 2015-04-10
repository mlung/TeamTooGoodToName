using System;

public class clsComboBoxItem
{
    private int aID;
    private string aText;

    public int ID
    {
        get { return aID; }
        set { aID = value; }
    }

    public string Text
    {
        get { return aText; }
        set { aText = value; }
    }

    public override string ToString()
    {
        return aText;
    }
}