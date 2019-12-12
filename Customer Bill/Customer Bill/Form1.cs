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
        const double rateRes = 0.052;
        const double rateCom = 0.045;
        const int baseComRate = 60;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCaluculate_Click(object sender, EventArgs e)
        {
            double inputRes;
            double calculateRes;

            inputRes = Convert.ToDouble(txtInput.Text);

            calculateRes = (rateRes * inputRes) + 6;

            lblResult.Text = calculateRes.ToString("c");
        }

        private void btnCalculateCom_Click(object sender, EventArgs e)
        {
            double inputCom = Convert.ToDouble(txtInputCom.Text);
            double calculateCom = 0;
            if (inputCom <= 1000)
            {
                calculateCom = baseComRate;
                lblResultCom.Text = calculateCom.ToString("c");
            }
            else if (inputCom > 1000)
            {
                inputCom -= 1000;
                calculateCom = (rateCom * inputCom) + 60;
                lblResultCom.Text = calculateCom.ToString("c");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblResult.Text = "";
            txtInput.Text = "";
            lblResultCom.Text = "";
            txtInputCom.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
