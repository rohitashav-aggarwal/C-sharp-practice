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

namespace Customer_Bill
{
    public partial class Form1 : Form
    {
        // Declare the constant variables to be used throughout different calculations

        
        const double RATE_RES = 0.052; // Residential Usage per kwh
        const double rateCom = 0.045; // Commercial Usage per kwh (more than 1000 kwh)
        const int baseComRate = 60; // Flat rate for commercial usage (o to 1000 kwh)
        const int baseIndusPeakRate = 76; // Flat rate for Industrial Peak usage (o to 1000 kwh)
        const int baseIndusOffPeakRate = 40; // Flat rate for Industrial Off peak usage (o to 1000 kwh)
        const double ratePeakIndus = 0.065; // Industrial peak Usage per kwh (more than 1000 kwh)
        const double rateOffPeakIndus = 0.028;// Industrial off peak Usage per kwh (more than 1000 kwh)

        public Form1()
        {
            InitializeComponent();
        }

        // Calculate button - performs calculation depends on customer type and input value
        private void btnCaluculate_Click(object sender, EventArgs e)
        {
            double inputRes; // Residential usage input
            double calculateRes; // Residential Final Bill Amount
            double inputCom; // Commercial usage input
            double calculateCom; // Commercial Final Bill Amount

            // Residential button condition(if) - performs calculation for Resdential customer
            if (btnResidential.Checked && Validator.IsValidData(txtInput))// button check and input validation
            {
                inputRes = Convert.ToDouble(txtInput.Text); // input data
                calculateRes = ResBill(inputRes); // calculate Residential bill

                lblResult.Text = calculateRes.ToString("c"); // display the bill in currency format
            }

            // Commercial RadioButton checked condition(else if) - performs calculation for Commercial customer
            if (btnCommercial.Checked && Validator.IsValidData(txtInput)) // button check and input validation
            {
                inputCom = Convert.ToDouble(txtInput.Text); // input data
                if (inputCom <= 1000) // setting a base line for usage
                {
                    calculateCom = baseComRate; // flat rate applied to the base line usage
                    lblResult.Text = calculateCom.ToString("c"); // display the bill in currency format
                }

                else if (inputCom > 1000) // Any usage greater than base line
                {
                    inputCom -= 1000; // Usage above the base line(1000)
                    calculateCom = ComBill(inputCom); // calculate commercial bill
                    lblResult.Text = calculateCom.ToString("c"); // display the bill in currency format
                }
            }


            // Industrial RadioButton checked condition(else if) - performs calculation for industrial customer
            if (btnIndustrial.Checked && Validator.IsValidData(txtInput) && Validator.IsValidData(txtOffPeakInput)) // button check and input validation
            {
                double inputPeakIndus = Convert.ToDouble(txtInput.Text); // Industrial usage input converted to double from String
                double calculatePeakIndus = 0; // initialize Peak hours Bill Amount
                double inputOffPeakIndus = Convert.ToDouble(txtOffPeakInput.Text); // Industrial off peak usage input converted to double from String
                double calculateOffPeakIndus = 0; // Off Peak hours Bill Amount

                if (inputPeakIndus <= 1000) // input less than 1000
                {
                    calculatePeakIndus = baseIndusPeakRate; // flat rate applicable
                }
                else if (inputPeakIndus > 1000) // input more than 1000
                {
                    inputPeakIndus -= 1000; // usage above flat rate
                    calculatePeakIndus = peakBill(inputPeakIndus); // calculate peak bill amount
                }



                if (inputOffPeakIndus <= 1000) // input less than 1000
                {
                    calculateOffPeakIndus = baseIndusOffPeakRate; // flat rate applicable
                }
                else if (inputOffPeakIndus > 1000) // input more than 1000
                {
                    inputOffPeakIndus -= 1000; // usage above flat rate
                    calculateOffPeakIndus = offPeakBill(inputOffPeakIndus); // calculate off peak bill amount
                }

                // calculate total industrial bill (peak plus off peak)
                double calculateIndus = calculatePeakIndus + calculateOffPeakIndus;
                lblResult.Text = calculateIndus.ToString("c"); // display and add currency format
            }

        }
        
        // Method call for calculating off peak bill
        private static double offPeakBill(double inputOffPeak)
        {
            return (rateOffPeakIndus * inputOffPeak) + 40;
        }

        // Method call for calculating peak bill
        private static double peakBill(double inputPeak)
        {
            return (ratePeakIndus * inputPeak) + 76;
        }

        // Method call for calculating commercial bill
        private static double ComBill(double inputC)
        {
            return (rateCom * inputC) + 60;
        }

        // Method call for calculating residential bill
        private static double ResBill(double inputR)
        {
            return (RATE_RES * inputR) + 6;
        }

        // on selecting residential button
        private void btnResidential_CheckedChanged(object sender, EventArgs e)
        {
            txtOffPeakInput.Enabled = false; // functionality off
            txtOffPeakInput.Visible = false; // visibility off
            label3.Visible = false; // visibility off
        }
        
        // on selecting commercial button
        private void btnCommercial_CheckedChanged(object sender, EventArgs e)
        {
            txtOffPeakInput.Enabled = false; // functionality off
            txtOffPeakInput.Visible = false; // visibility off
            label3.Visible = false; // visibility off
        }

        // on selecting industrial button
        private void btnIndustrial_CheckedChanged(object sender, EventArgs e)
        {
            txtOffPeakInput.Enabled = true; // functionality on
            txtOffPeakInput.Visible = true; // visibility on
            label3.Visible = true; // visibility on
        }

        // When form loads focus on Residential button and Input
        private void Form1_Load(object sender, EventArgs e)
        {
            btnResidential.Checked = true;
            txtInput.Focus();

        }

        // On click clear button, clear all input fields
        private void btnClear_Click(object sender, EventArgs e)
        {
            lblResult.Text = "";
            txtInput.Text = "";
            txtOffPeakInput.Text = "";
        }

        // on click exit button, exit the form
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    } // end class
} // end namespace

