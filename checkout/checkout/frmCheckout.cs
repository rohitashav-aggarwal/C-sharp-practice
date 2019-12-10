using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace checkout
{
    public partial class frmCheckout : Form
    {

        // form-level variables
        const decimal TAX_PCT = 0.05m;

        public frmCheckout()
        {
            InitializeComponent();
        }

        // calculate checkout amount based on price and quantity
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // local variables
            int qty; // quantity purchase
            decimal price; // unit price
            decimal payAmount; // total amount (to calculate)
            decimal subTotal; // before tax
            decimal taxAmount; // tax percentage
            // get qty and price
            qty = Convert.ToInt32(txtQuantity.Text);
            price = Convert.ToDecimal(txtPrice.Text);
            // calculate the payAmount
            subTotal = qty * price;
            taxAmount = subTotal * TAX_PCT;
            payAmount = subTotal + taxAmount;
            // display the result
            lblSubTotal.Text = subTotal.ToString("c"); // currency format
            lblTax.Text = taxAmount.ToString("c"); // tax on total
            label3.Text = payAmount.ToString("c");
        }

        private void lblClear_Click(object sender, EventArgs e)
        {
            txtPrice.Text = "";
            txtQuantity.Text = "";
            lblSubTotal.Text = "";
            lblTax.Text = "";
            label3.Text = "";
            txtPrice.Focus();
        }
    }
}
