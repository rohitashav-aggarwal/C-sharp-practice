using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; // for MessageBox

namespace Customer_Bill
{
    // repository of validation methods
    public static class Validator
    { 
        public static bool Present(TextBox tb)
        {
            bool valid = true; // "innocent until proven guilty"
            if (tb.Text == "") // "bad dog"
            {
                valid = false;
                if (tb.Name == "txtInput")
                {
                    MessageBox.Show("Input is required ", "Input Error");
                }
                else {
                    MessageBox.Show("Off Peak Input is required", "Input Error");
                }

               tb.Focus();
            }
            return valid;
        }

        public static bool NonNegativeInt32(TextBox tb)
        {
            bool valid = true;
            int val;
            if (!Int32.TryParse(tb.Text, out val)) // not an int
            {
                valid = false;
                if (tb.Name == "txtInput") {
                    MessageBox.Show("Input must be  a whole number", "Input Error"); }
                else
                {
                    MessageBox.Show("Off Peak Input must be  a whole number", "Input Error");
                }
                tb.SelectAll();
                tb.Focus();
            }
            
            else if (val < 0) // negetive
            {
                valid = false;
                if (tb.Name == "txtInput") {MessageBox.Show("Input must be positive or zero"); }
                else { MessageBox.Show("Off Peak Input must be positive or zero", "Input Error"); }
                tb.SelectAll();
                tb.Focus();
            }

            return valid;
        }
         public static bool IsValidData(TextBox tb) {
            return
                Present(tb) &&
                NonNegativeInt32(tb);
        }
    } // end class
} // end namespace
