/*
 * @Author: Rohitashav Aggarwal
 * @Date: 26 December 2019
 * @Purpose: Calculating 3 Customer type Electricity Bills and storing customer data
 * @Class: CPRG-200 lab 2 - OOSD Program - SAIT
*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Customer_Bill
{
    // validation methods
    public static class Validator // bill must be calculated before adding the customer to the list
    {
        public static bool labelPresent(Label tb)
        {
            bool valid = true;
            if(tb.Text == "")
            {
                valid = false;
                
                MessageBox.Show("Billing must be done.","Billing Error");
                
                tb.Focus();
            }
            return valid;
        }

        public static bool IsPresent(TextBox tb) // fields must be present before calculating or adding
        {
            bool valid = true; // initially true
            if (tb.Text == "") // if input field empty
            {
                valid = false; // if field is empty
                // depending on input type, message changes
                if (tb.Name == "txtInput")
                {
                    MessageBox.Show("Input is required", "Input Error");
                }
                else if (tb.Name == "txtName")
                {
                    MessageBox.Show("Name is required","Input Error");
                }
                else if (tb.Name == "txtAccNo")
                {
                    MessageBox.Show("Account No is required", "Input Error");
                }
                else {
                    MessageBox.Show("Off Peak Input is required", "Input Error");
                }

               tb.Focus();
            }
            return valid;
        }

        public static bool NonNegativeInt32(TextBox tb) // inputs must be positive whole number
        {
            bool valid = true;
            int val;
            if (!Int32.TryParse(tb.Text, out val)) // not an int
            {
                valid = false;
                // depending on input type, message changes
                if (tb.Name == "txtInput") {
                    MessageBox.Show("Input must be  a whole number", "Input Error"); }
                else if (tb.Name == "txtAccNo")
                {
                    MessageBox.Show("Account No must be a whole number", "Input Error");
                }
                else
                {
                    MessageBox.Show("Off Peak Input must be  a whole number", "Input Error");
                }
                tb.SelectAll();
                tb.Focus();
            }
            
            else if (val < 0) // negative value validation
            {
                valid = false;
                if (tb.Name == "txtInput") {
                    MessageBox.Show("Input must be positive or zero", "Input Error"); 
                }
                else if (tb.Name == "txtAccNo")
                {
                    MessageBox.Show("Account No must be positive or zero", "Input Error");
                }
                else { 
                    MessageBox.Show("Off Peak Input must be positive or zero", "Input Error"); 
                }
                tb.SelectAll();
                tb.Focus();
            }

            return valid;
        }

        // All methods inside this function to be used in validating the form
         public static bool IsValidData(TextBox tb) {
            return
                IsPresent(tb) &&
                NonNegativeInt32(tb);
        }
    } // end class
} // end namespace
