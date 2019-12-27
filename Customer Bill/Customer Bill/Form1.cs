/*
 * @Author: Rohitashav Aggarwal
 * @Date: 26 December 2019
 * @Purpose: Calculating 3 Customer type Electricity Bills and storing customer data
 * @Class: CPRG-200 lab 2 - OOSD Program - SAIT
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
using CustomerData;

namespace Customer_Bill
{
    public partial class Form1 : Form
    {
        // initialized variables to record statistics
        private Char customerType;
        private int totalCustomers;
        private double totalCharges = 0;
        private double resCharges = 0;
        private double comCharges = 0;
        private double indCharges = 0;
        

        public Form1()
        {
            InitializeComponent();
        }

        // declared enumeration to record customer type
        public enum billType
        {
            Residential = 'R',
            Commercial = 'C',
            Industrial = 'I'
        }

        // Calculate button - performs bill calculation depends on customer type and input value
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double bill = 0; // initialize bill to zero
            
            Calculation cal = new Calculation();
            if (validate()) {
                Customer cus = new Customer(txtName.Text, Convert.ToInt32(txtAccNo.Text), customerType);
                if (customerType == 'R' || customerType == 'C') // if residential or commercial
                {
                    bill = cal.CalculateCharge(cus, Convert.ToDouble(txtInput.Text));
                    lblResult.Text = bill.ToString("c");
                }
                else
                { // else industrial
                    bill = cal.CalculateCharge(cus,
                           Convert.ToDouble(txtInput.Text),
                           Convert.ToDouble(txtOffPeakInput.Text));
                    // display result
                    lblResult.Text = bill.ToString("c");
                }
            }
        }

        // validate method to validate data before calculating
        public bool validate()
        {
            if (btnResidential.Checked || btnCommercial.Checked) 
            {
               return 
                Validator.IsPresent(txtName) &&
                Validator.IsValidData(txtAccNo) &&
                Validator.IsValidData(txtInput);
            }
               return
                Validator.IsPresent(txtName) &&
                Validator.IsValidData(txtAccNo) &&
                Validator.IsValidData(txtInput) &&
                Validator.IsValidData(txtOffPeakInput);
        }

        // on selecting residential button
        private void btnResidential_CheckedChanged(object sender, EventArgs e)
        {
            customerType = (char)billType.Residential; // enum used 
            txtOffPeakInput.Enabled = false; // functionality off
            txtOffPeakInput.Visible = false; // visibility off
            label3.Visible = false; // visibility off

        }
        
        // on selecting commercial button
        private void btnCommercial_CheckedChanged(object sender, EventArgs e)
        {
            customerType = (char)billType.Commercial; // enum used
            txtOffPeakInput.Enabled = false; // functionality off
            txtOffPeakInput.Visible = false; // visibility off
            label3.Visible = false; // visibility off
        }

        // on selecting industrial button
        private void btnIndustrial_CheckedChanged(object sender, EventArgs e)
        {
            customerType = (char)billType.Industrial; // enum used
            txtOffPeakInput.Enabled = true; // functionality on
            txtOffPeakInput.Visible = true; // visibility on
            label3.Visible = true; // visibility on
        }

        // When form loads focus on Residential button, Input and read data from the file and display
        // calculate statistics
        private void Form1_Load(object sender, EventArgs e)
        {
            btnResidential.Checked = true;
            customerType = (char) billType.Residential;
            txtInput.Focus();
            Customer customer = new Customer();
            List<Customer> customerList = customer.readFile();
            foreach (Customer c in customerList)
            {
                // total charges
                totalCharges = totalCharges + c.getCharge();
                // individual charges
                if(c.getCusType() == 'R')
                {
                    resCharges = resCharges + c.getCharge();
                }
                else if (c.getCusType() == 'C')
                {
                    comCharges = comCharges + c.getCharge();
                }
                else
                {
                    indCharges = indCharges + c.getCharge();
                }
                lstCustomer.Items.Add(c.ToString());
            }
            // display statistics
            displayOnLoad();
        }

        // on clicking add button, add data to the list and update statistics
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (validate() && Validator.labelPresent(lblResult))
            {
                Customer c = new Customer(txtName.Text, Convert.ToInt32(txtAccNo.Text), customerType);
                c.setCharge(Convert.ToDouble(lblResult.Text.Remove(0, 1)));
                lstCustomer.Items.Add(c.ToString()); // add to the list
                c.updateFile(c); // update data
                totalCustomers = lstCustomer.Items.Count; // update total customers statistics
                totalCharges = totalCharges + c.getCharge(); // update total charges statistics
                // update individual charges statistics
                if (c.getCusType() == 'R')
                {
                    resCharges = resCharges + c.getCharge();
                }
                else if (c.getCusType() == 'C')
                {
                    comCharges = comCharges + c.getCharge();
                }
                else
                {
                    indCharges = indCharges + c.getCharge();
                }
            }
            // display statistics
            displayOnLoad();
        }

        // display method to display statistics on the form
        private void displayOnLoad()
        {
            lblTotalCust.Text = lstCustomer.Items.Count.ToString();
            lblTotalCharges.Text = totalCharges.ToString("c");
            lblResCharges.Text = resCharges.ToString("c");
            lblComCharges.Text = comCharges.ToString("c");
            lblIndCharges.Text = indCharges.ToString("c");
        }

        // On click clear button, clear all input fields
        private void btnClear_Click(object sender, EventArgs e)
        {
            lblResult.Text = "";
            txtInput.Text = "";
            txtOffPeakInput.Text = "";
            txtAccNo.Text = "";
            txtName.Text = "";
        }

        // on click exit button, exit the form
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    } // end class
} // end namespace

