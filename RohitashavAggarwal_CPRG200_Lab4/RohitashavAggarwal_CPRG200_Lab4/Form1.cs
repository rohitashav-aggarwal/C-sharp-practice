/*
 * @Author: Rohitashav Aggarwal
 * @Date: 22 January 2020
 * @Purpose: Retrieve/Update orders for a particular OrderID and display statistics
 * @Class: CPRG-200 lab 4 - OOSD Program - SAIT
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RohitashavAggarwal_CPRG200_Lab4
{
    public partial class Form1 : Form
    {
        // to bind order details table with the order id
        BindingList<OrderDetails> orderDetailsList = new BindingList<OrderDetails>();
       
        public Form1() // form initialize
        {
            InitializeComponent();
            dataGridView1.DataSource = orderDetailsList;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadOrderIdComboBox(); // loading combo box with order id values when forms loads
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateShipDate(sender, e); // Updating shipping date on clicking update button
        }

        public void button2_Click(object sender, EventArgs e) // Retrieve Button on click event
        {
            // selecting or typing a valid order id and displaying the results
            try
            {
                int orderID = Convert.ToInt32(cborderId.Text);
                Orders myOrder = OrdersDB.GetOrders(orderID);
                List<OrderDetails> myOrderDetails = OrderDetailsDB.GetOrderDetails(orderID);

                if (Object.Equals(myOrder, null)) // if ordr id not valid, show the follofing message
                {
                    MessageBox.Show("No matching Order Id's found, please provide a valid Order ID", "Order ID Error");
                }
                else // else display all the fields and read only order details data grid form
                {
                    displayOrder(myOrder);
                    displayOrderDetails(myOrderDetails);
                    calculateTotalprice();
                }
            }
            catch(FormatException) // catching the wrong format order id exception, in case user types an alphabet or anything other than the valid id
            {
                MessageBox.Show("Select from the drop down list and Retrieve.", "Input Error");
            }
        }

        private void calculateTotalprice() // calculating the total price for all the orders associated with one order id
        {
            int orderID = Convert.ToInt32(cborderId.Text);
            List<OrderDetails> myOrderDetails = OrderDetailsDB.GetOrderDetails(orderID);

            double totalPrice = 0;
            double UnitPrice = 0;
            int Quantity = 0;
            double Discount = 0;
            
            foreach (OrderDetails d in myOrderDetails) // calculating by going through each order details rows
            {
                UnitPrice = d.UnitPrice;
                Quantity = d.Quantity;
                Discount = d.Discount;
                totalPrice += UnitPrice * (1 - Discount) * Quantity;
            }
            lblTotalPrice.Text = totalPrice.ToString("c"); // displaying the result in the text field in a currency format
        }

        private void LoadOrderIdComboBox() // method to load combo box
        {
            // storing the ids from orderIdDB class and displaying inside the Combo box
            try
            {
                List<OrderId> ids = OrderIdDB.GetOrderIds();
                cborderId.DataSource = ids;
                cborderId.DisplayMember = "OrderId";
            }
            // catching any exception while populating the combo box
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }
        private void UpdateShipDate(object sender, EventArgs e) // update ship date method
        {
            try
            {
                // setting the orderid to accept null values by using nullable datetime values
                int orderID = Convert.ToInt32(cborderId.Text);
                DateTime? NewShippedDate;
                if (String.IsNullOrEmpty(txtShipDate.Text))
                {
                    NewShippedDate = null;
                }
                else
                {
                    NewShippedDate = DateTime.Parse(txtShipDate.Text);
                }
            
                // adding validation for new shipped date to be between order date and requird date
                DateTime? RequiredDate = Convert.ToDateTime(txtReqDate.Text);
                DateTime? Orderdate = Convert.ToDateTime(txtOrderDate.Text);
                if (RequiredDate >= NewShippedDate && Orderdate <= NewShippedDate)
                {
                    OrdersDB.UpdateShippingDate(NewShippedDate, orderID); // method to update shipping value
                    MessageBox.Show("Shipped Date Updated", "Update");
                }
                else if (RequiredDate < NewShippedDate)
                {
                    MessageBox.Show("Shipped Date can not be ahead of Required Date.", "Date Error");
                    Form1_Load(sender, e);
                }
                else if(Orderdate > NewShippedDate)
                {
                    MessageBox.Show("Shipped Date can not be earlier than the Order Date","Date Error");
                }
                else if (NewShippedDate == null) //method to update new shipped date with null values
                {
                    OrdersDB.UpdateShippingDate(orderID); // using the same method name with different signatures
                    MessageBox.Show("Null value Added.","Null Value");
                }
                else
                {
                    MessageBox.Show("Shipped Date not acceptable.", "Incorrect Syntax");
                }
            }
            catch (FormatException) // catching the shipped date format exception incase it's in a wrong format
            {
                MessageBox.Show("Select from the drop down list and Retrieve. Use the correct format for date MM/DD/YYYY.", "Input Error");
            }
        }

        private void displayOrderDetails(List<OrderDetails> Details) // method to display the order details in a grid view
        {
            dataGridView1.DataSource = Details;
        }

        private void displayOrder(Orders order) // method to display the customer details based on order id
        {
            txtCustomerId.Text = order.CustomerID.ToString();
            txtOrderDate.Text = (order.OrderDate.HasValue) ? order.OrderDate.Value.ToShortDateString() : null;
            txtReqDate.Text = (order.RequiredDate.HasValue) ? order.RequiredDate.Value.ToShortDateString() : null;
            txtShipDate.Text = (order.ShippedDate.HasValue) ? order.ShippedDate.Value.ToShortDateString() : null;
        }

        // exit the form
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }// end of class
}// end namespace
