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
        public static bool IsPresent(TextBox tb, string name)
        {
            bool valid = true; // "innocent until proven guilty"
            if (tb.Text == "") // "bad dog"
            {
                valid = false;
                MessageBox.Show(name + " is required", "Input Error");
                tb.Focus();
            }
            return valid;
        }

        public static bool Present(TextBox tb1, string name)
        {
            bool valid1 = true; // "innocent until proven guilty"
            if (tb1.Text == "") // "bad dog"
            {
                valid1 = false;
                MessageBox.Show(name + " is required", "Input Error");
                tb1.Focus();
            }
            return valid1;
        }

        /*public static bool IsInt32(TextBox tb, string name)
        {
            bool valid = true;
            int val;
            if(!Int32.TryParse(tb.Text, out val)) // not an int
            {
                valid = false;
                MessageBox.Show(name + " must be  a whole number", "Input Error");
                tb.SelectAll();
                tb.Focus();
            }
            return valid;
        }*/

        public static bool IsNonNegativeInt32(TextBox tb, string name)
        {
            bool valid = true;
            int val;
            if (!Int32.TryParse(tb.Text, out val)) // not an int
            {
                valid = false;
                MessageBox.Show(name + " must be  a whole number", "Input Error");
                tb.SelectAll();
                tb.Focus();
            }
            
            else if(val < 0) // negetive
            {
                valid = false;
                MessageBox.Show(name + " must be positive or zero");
                tb.SelectAll();
                tb.Focus();
            }
            return valid;
        }


        public static bool NonNegativeInt32(TextBox tb1, string name)
        {
            bool valid2 = true;
            int val2;
            if (!Int32.TryParse(tb1.Text, out val2)) // not an int
            {
                valid2 = false;
                MessageBox.Show(name + " must be  a whole number", "Input Error");
                tb1.SelectAll();
                tb1.Focus();
            }
            
            else if (val2 < 0) // negetive
            {
                valid2 = false;
                MessageBox.Show(name + " must be positive or zero");
                tb1.SelectAll();
                tb1.Focus();
            }

            return valid2;
        }
        /*
        public static bool IsDouble(TextBox tb, string name)
        {
            bool valid = true;
            double val;
            if (!Double.TryParse(tb.Text, out val)) // not a double value
            {
                valid = false;
                MessageBox.Show(name + " must be a number", "Input Error");
                tb.SelectAll();
                tb.Focus();
            }
            return valid;
        }

        public static bool IsNonNegativeDouble(TextBox tb, string name)
        {
            bool valid = true;
            double val;
            if (!Double.TryParse(tb.Text, out val)) // not a double value
            {
                valid = false;
                MessageBox.Show(name + " must be a number", "Input Error");
                tb.SelectAll();
                tb.Focus();
            }
            else if (val < 0) // negetive
            {
                valid = false;
                MessageBox.Show(name + "must be positive or zero");
                tb.SelectAll();
                tb.Focus();
            }
            return valid;
        }
        */
    } // end class
} // end namespace
