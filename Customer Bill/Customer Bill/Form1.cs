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

        const double rateRes = 0.052; // Residential Usage per kwh
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

        // Calculate button - performs calculation depends on customer and input value
        private void btnCaluculate_Click(object sender, EventArgs e)
        {

            if (Validator.IsPresent(txtInput, "Input") &&
                Validator.IsNonNegativeInt32(txtInput, "Input") &&
                Validator.Present(txtOffPeakInput, "Off Peak Input") &&
                Validator.NonNegativeInt32(txtOffPeakInput, "Off Peak Input")
              )
            {
                double inputRes = Convert.ToDouble(txtInput.Text); // Residential usage input converted to double from String
                double calculateRes; // Residential Final Bill Amount
                double inputCom = Convert.ToDouble(txtInput.Text); // Commercial usage input converted to double from String
                double calculateCom; // Commercial Final Bill Amount
                double inputPeakIndus = Convert.ToDouble(txtInput.Text); // Industrial usage input converted to double from String
                double calculatePeakIndus = 0; // Peak hours Bill Amount
                double inputOffPeakIndus = Convert.ToDouble(txtOffPeakInput.Text);
                double calculateOffPeakIndus = 0; // Off Peak hours Bill Amount
                // Residential button condition(if) - performs calculation for Resdential customer
                if (btnResidential.Checked)
                {
                    calculateRes = ResBill(inputRes);

                    lblResult.Text = calculateRes.ToString("c"); // display the bill in currency format
                }
                
                // Commercial RadioButton checked condition(else if) - performs calculation for Commercial customer
                else if (btnCommercial.Checked)
                {
                    if (inputCom <= 1000) // setting a base line for usage
                    {
                        calculateCom = baseComRate; // flat rate applied to the base line usage
                        lblResult.Text = calculateCom.ToString("c"); // display the bill in currency format
                    }

                    else if (inputCom > 1000) // Any usage greater than base line
                    {
                        inputCom -= 1000; // Usage above the base line(1000)
                        calculateCom = ComBill(inputCom);
                        lblResult.Text = calculateCom.ToString("c"); // display the bill in currency format
                    }
                }

                

                // Industrial RadioButton checked condition(else if) - performs calculation for industrial customer
                else if (btnIndustrial.Checked)
                {
                    if (inputPeakIndus <= 1000)
                    {
                        calculatePeakIndus = baseIndusPeakRate;
                    }
                    else if (inputPeakIndus > 1000)
                    {
                        inputPeakIndus -= 1000;
                        calculatePeakIndus = peakBill(inputPeakIndus);
                    }


                    
                    if (inputOffPeakIndus <= 1000)
                    {
                        calculateOffPeakIndus = baseIndusOffPeakRate;
                    }
                    else if (inputOffPeakIndus > 1000)
                    {
                        inputOffPeakIndus -= 1000;
                        calculateOffPeakIndus = offPeakBill(inputOffPeakIndus);
                    }


                    double calculateIndus = calculatePeakIndus + calculateOffPeakIndus;
                    lblResult.Text = calculateIndus.ToString("c");
                }

            }
        }

        private static double offPeakBill(double inputOffPeak)
        {
            return (rateOffPeakIndus * inputOffPeak) + 40;
        }

        private static double peakBill(double inputPeak)
        {
            return (ratePeakIndus * inputPeak) + 76;
        }

        private static double ComBill(double inputC)
        {
            return (rateCom * inputC) + 60;
        }

        private static double ResBill(double inputR)
        {
            return (rateRes * inputR) + 6;
        }

        private void btnResidential_CheckedChanged(object sender, EventArgs e)
        {
            txtOffPeakInput.Enabled = false;
            txtOffPeakInput.Visible = false;
            label3.Visible = false;
        }

        private void btnCommercial_CheckedChanged(object sender, EventArgs e)
        {
            txtOffPeakInput.Enabled = false;
            txtOffPeakInput.Visible = false;
            label3.Visible = false;
        }

        private void btnIndustrial_CheckedChanged(object sender, EventArgs e)
        {
            txtOffPeakInput.Enabled = true;
            txtOffPeakInput.Visible = true;
            label3.Visible = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnResidential.Checked = true;
            txtInput.Focus();

        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            lblResult.Text = "";
            txtInput.Text = "";
            txtOffPeakInput.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
