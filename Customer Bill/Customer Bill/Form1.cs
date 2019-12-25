/*
 * @Author: Rohitashav Aggarwal
 * @Date: 12 December 2019
 * @Purpose: Calculating 3 Customer type Electricity Bills
 * @Class: CPRG-200 lab 1 - OOSD Program - SAIT
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
        private Char customerType;

        public Form1()
        {
            InitializeComponent();
        }
        //Form1 t = new Form1();
        public enum billType
        {
            Residential = 'R',
            Commercial = 'C',
            Industrial = 'I'
        }

        // Calculate button - performs calculation depends on customer type and input value
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double bill = 0;
            
            Calculation cal = new Calculation();
            if (validate()) {
                Customer cus = new Customer(txtName.Text, Convert.ToInt32(txtAccNo.Text), customerType);
                if (customerType == 'R' || customerType == 'C')
                {
                    bill = cal.CalculateCharge(cus, Convert.ToDouble(txtInput.Text));
                    //cus.setCharge(bill);
                    lblResult.Text = bill.ToString("c");
                    //cus.updateFile(cus);
                }
                else
                {
                    bill = cal.CalculateCharge(cus,
                        Convert.ToDouble(txtInput.Text),
                        Convert.ToDouble(txtOffPeakInput.Text));
                    //cus.setCharge(bill);
                    lblResult.Text = bill.ToString("c");
                }
            }

            
        }

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
            customerType = (char)billType.Residential;
            txtOffPeakInput.Enabled = false; // functionality off
            txtOffPeakInput.Visible = false; // visibility off
            label3.Visible = false; // visibility off

        }
        
        // on selecting commercial button
        private void btnCommercial_CheckedChanged(object sender, EventArgs e)
        {
            customerType = (char)billType.Commercial;
            txtOffPeakInput.Enabled = false; // functionality off
            txtOffPeakInput.Visible = false; // visibility off
            label3.Visible = false; // visibility off
        }

        // on selecting industrial button
        private void btnIndustrial_CheckedChanged(object sender, EventArgs e)
        {
            customerType = (char)billType.Industrial;
            txtOffPeakInput.Enabled = true; // functionality on
            txtOffPeakInput.Visible = true; // visibility on
            label3.Visible = true; // visibility on
        }

        // When form loads focus on Residential button and Input
        private void Form1_Load(object sender, EventArgs e)
        {
            btnResidential.Checked = true;
            customerType = (char) billType.Residential;
            txtInput.Focus();
            Customer customer = new Customer();
            List<Customer> customerList = customer.readFile();
            foreach (Customer c in customerList)
                lstCustomer.Items.Add(c.ToString());
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (validate() && Validator.labelPresent(lblResult))
            {
                Customer c = new Customer(txtName.Text, Convert.ToInt32(txtAccNo.Text), customerType);
                c.setCharge(Convert.ToDouble(lblResult.Text.Remove(0, 1)));
                lstCustomer.Items.Add(c.ToString());
                c.updateFile(c);
                
            }
        }
    } // end class
} // end namespace

