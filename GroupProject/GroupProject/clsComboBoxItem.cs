using System;

public class clsComboBoxItem
{
    private int aID;
    private string aText;

    public clsComboBoxItem(int id, string text)
    {
        aID = id;
        aText = text;
    }

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