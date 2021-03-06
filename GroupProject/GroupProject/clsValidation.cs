﻿using System;
using System.Windows.Forms;

public class clsValidate //Validation helper methods by Alka Harriger
{
    public static void ShowMessage(string msg)
    {
        MessageBox.Show(msg, "Message from Application", MessageBoxButtons.OK);
    }

    // The overloaded validateInput helper method handles just the existence check for any data item.
    public static bool validateInput(TextBox txtInput)
    {
        string fieldName;
        fieldName = txtInput.Name.Substring(3);
        if (txtInput.Text == "")
        {
            ShowMessage("Please enter a value for " + fieldName);
            txtInput.Focus();
            return false;
        }
        return true;
    }

    // The overloaded validateInput helper method handles the existence check for a given string input form object
    // and assigns the equivalent value to its corresponding variable.
    public static bool validateInput(TextBox txtInput, out string userInput)
    {
        string fieldName;
        fieldName = txtInput.Name.Substring(3);
        userInput = "";
        if (txtInput.Text == "")
        {
            ShowMessage("Please enter a value for " + fieldName);
            txtInput.Focus();
            return false;
        }
        userInput = txtInput.Text;
        return true;
    }

    // The overloaded validateInput helper methods handle the existence check for a given Boolean input form object
    // and assigns the equivalent value to its corresponding variable.
    public static bool validateInput(TextBox txtInput, out bool userInput)
    {
        string fieldName;
        fieldName = txtInput.Name.Substring(3);
        userInput = false;
        if (txtInput.Text == "")
        {
            ShowMessage("Please enter a value for " + fieldName);
            txtInput.Focus();
            return false;
        }
        userInput = bool.Parse(txtInput.Text);
        return true;
    }

    // The overloaded validateInput helper methods handle the existence check, type check, and range check for a given
    // input form object and assigns the equivalent value to its corresponding variable. (This one handles int data.)
    public static bool validateInput(TextBox txtInput, int min, int max, out int userInput)
    {
        string fieldName;
        fieldName = txtInput.Name.Substring(3);
        userInput = 0;
        if (txtInput.Text == "")
        {
            ShowMessage("Please enter a value for " + fieldName);
            txtInput.Focus();
            return false;
        }
        if (int.TryParse(txtInput.Text, out userInput) == false)
        {
            ShowMessage("Only numbers are allowed for " + fieldName + ". Please re-enter:");
            txtInput.Focus();
            return false;
        }
        if (userInput < min || userInput > max)
        {
            ShowMessage(fieldName + " must be between " + min.ToString() + " and " + max.ToString());
            txtInput.Focus();
            return false;
        }
        return true;
    }

    // The overloaded validateInput helper methods handle the existence check, type check, and range check for a given
    // input form object and assigns the equivalent value to its corresponding variable. (This one handles double data.)
    public static bool validateInput(TextBox txtInput, double min, double max, out double userInput)
    {
        string fieldName;
        fieldName = txtInput.Name.Substring(3);
        userInput = 0D;
        if (txtInput.Text == "")
        {
            ShowMessage("Please enter a value for " + fieldName);
            txtInput.Focus();
            return false;
        }
        if (double.TryParse(txtInput.Text, out userInput) == false)
        {
            ShowMessage("Only numbers are allowed for " + fieldName + ". Please re-enter:");
            txtInput.Focus();
            return false;
        }
        if (userInput < min || userInput > max)
        {
            ShowMessage(fieldName + " must be between " + min.ToString() + " and " + max.ToString());
            txtInput.Focus();
            return false;
        }
        return true;
    }

    // The overloaded validateInput helper methods handle the existence check, type check, and range check for a given
    // input form object and assigns the equivalent value to its corresponding variable. (This one handles decimal data.)
    public static bool validateInput(TextBox txtInput, decimal min, decimal max, out decimal userInput)
    {
        string fieldName;
        fieldName = txtInput.Name.Substring(3);
        userInput = 0M;
        if (txtInput.Text == "")
        {
            ShowMessage("Please enter a value for " + fieldName);
            txtInput.Focus();
            return false;
        }
        if (decimal.TryParse(txtInput.Text, out userInput) == false)
        {
            ShowMessage("Only numbers are allowed for " + fieldName + ". Please re-enter:");
            txtInput.Focus();
            return false;
        }
        if (userInput < min || userInput > max)
        {
            ShowMessage(fieldName + " must be between " + min.ToString() + " and " + max.ToString());
            txtInput.Focus();
            return false;
        }
        return true;
    }

    // The overloaded validateInput helper methods handle the existence check, type check, and range check for a given
    // input form object and assigns the equivalent value to its corresponding variable. (This one handles DateTime data.)
    public static bool validateInput(TextBox txtInput, DateTime min, DateTime max, out DateTime userInput)
    {
        string fieldName;
        fieldName = txtInput.Name.Substring(3);
        userInput = DateTime.Parse("01/01/1900");
        if (txtInput.Text == "")
        {
            ShowMessage("Please enter a date in the format mm/dd/yyyy for " + fieldName);
            txtInput.Focus();
            return false;
        }
        if (DateTime.TryParse(txtInput.Text, out userInput) == false)
        {
            ShowMessage("Only dates are allowed for " + fieldName + ". Please re-enter:");
            txtInput.Focus();
            return false;
        }
        if (userInput < min || userInput > max)
        {
            ShowMessage(fieldName + " must be between " + min.ToShortDateString() + " and " + max.ToShortDateString());
            txtInput.Focus();
            return false;
        }
        return true;
    }



    //ComboBox validation by Miranda Lung
    public static bool validateInput(ComboBox cboInput)
    {
        string fieldName;
        fieldName = cboInput.Name.Substring(3);
        if (cboInput.SelectedIndex < 0)
        {
            ShowMessage("Please select a valid item for " + fieldName + ".");
            cboInput.Focus();
            return false;
        }

        return true;
    }

    public static bool validateInput(ComboBox cboInput, string toFind)
    {
        string fieldName;
        fieldName = cboInput.Name.Substring(3);
        if (cboInput.SelectedIndex < 0)
        {
            int i = 0; //If it isn't a selected index, then see if the entered text matches a value in the combo box.
            bool found = false;
            while (i < cboInput.Items.Count && found == false)
            {
                cboInput.SelectedIndex = i;
                clsComboBoxItem compare = (clsComboBoxItem)cboInput.SelectedItem;
                if (compare.Text.CompareTo(toFind) == 0)
                {
                    found = true;
                }

                else
                {
                    i++;
                }
            }

            if (found == true)
            {
                return true;
            }

            ShowMessage("Please select a valid item for " + fieldName + ".");
            cboInput.Focus();
            return false;
        }

        return true;
    }

}