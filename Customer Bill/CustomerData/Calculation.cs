using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerData
{
    public  class Calculation
    {
        // Declare the constant variables to be used throughout different calculations
        const double RATE_RES = 0.052; // Residential Usage per kwh
        const double rateCom = 0.045; // Commercial Usage per kwh (more than 1000 kwh)
        const int baseComRate = 60; // Flat rate for commercial usage (o to 1000 kwh)
        const int baseIndusPeakRate = 76; // Flat rate for Industrial Peak usage (o to 1000 kwh)
        const int baseIndusOffPeakRate = 40; // Flat rate for Industrial Off peak usage (o to 1000 kwh)
        const double ratePeakIndus = 0.065; // Industrial peak Usage per kwh (more than 1000 kwh)
        const double rateOffPeakIndus = 0.028;// Industrial off peak Usage per kwh (more than 1000 kwh)
        //private int offPeakInput;

        // Method call for calculating off peak bill
        private static double offPeakBill(double inputOffPeak)
        {
            if (inputOffPeak < 1000)
            {
                return baseIndusOffPeakRate;
            } else
                inputOffPeak -= 1000;
                return (rateOffPeakIndus * inputOffPeak) + 40;
        }

        // Method call for calculating peak bill
        private static double peakBill(double inputPeak)
        {
            if (inputPeak < 1000)
            {
                return baseIndusPeakRate;
            }
            else
                inputPeak -= 1000;
                return (ratePeakIndus * inputPeak) + 76;
        }

        // Method call for calculating commercial bill
        private static double ComBill(double inputC)
        {
            if (inputC < 1000)
            {
                return baseComRate;
            }
            else
                inputC -= 1000;
                return (rateCom * inputC) + 60;
        }

        // Method call for calculating residential bill
        private static double ResBill(double inputR)
        {
            return (RATE_RES * inputR) + 6;
        }

        public double CalculateCharge(Customer cus, double usage, double offusage)
        {
           
            double bill = CalculateCharge(cus, usage);
            if (cus.getCusType() == 'I')
            {
               bill = peakBill(usage) + offPeakBill(offusage);
            }
            return bill;
        }
        public double CalculateCharge(Customer cus, double usage)
        {
            //double inputRes = 0; // Residential usage input
            //double calculateRes; // Residential Final Bill Amount
            //double inputCom = 0; // Commercial usage input
            double bill = 0;
   
            // Residential button condition(if) - performs calculation for Resdential customer
            if (cus.getCusType() == 'R')// button check and input validation
            {
                bill = ResBill(usage); // calculate Residential bill
            }
            if (cus.getCusType() == 'C')
            {
                bill = ComBill(usage);
            }
            
            return bill;
            //// Commercial RadioButton checked condition(else if) - performs calculation for Commercial customer
            //if (cus.getCusType() == 'C') // button check and input validation
            //{
            //    if (inputCom <= 1000) // setting a base line for usage
            //    {
            //        calculateCom = baseComRate; // flat rate applied to the base line usage
            //        return calculateCom.ToString("c"); // display the bill in currency format
            //    }

            //    else  // Any usage greater than base line
            //    {
            //        inputCom -= 1000; // Usage above the base line(1000)
            //        calculateCom = ComBill(inputCom); // calculate commercial bill
            //        return calculateCom.ToString("c"); // display the bill in currency format
            //    }


            //}


            //// Industrial RadioButton checked condition(else if) - performs calculation for industrial customer
            //if (cus.getCusType() == 'I') // button check and input validation
            //{
            //    double calculatePeakIndus = 0; // initialize Peak hours Bill Amount
            //    double calculateOffPeakIndus = 0; // Off Peak hours Bill Amount

            //    if (input <= 1000) // input less than 1000
            //    {
            //        calculatePeakIndus = baseIndusPeakRate; // flat rate applicable
            //        return Convert.ToString(calculatePeakIndus);
            //    }
            //    else if (input > 1000) // input more than 1000
            //    {
            //        input -= 1000; // usage above flat rate
            //        calculatePeakIndus = peakBill(input); // calculate peak bill amount
            //        return Convert.ToString(calculatePeakIndus);
            //    }



            //    if (offPeakInput <= 1000) // input less than 1000
            //    {
            //        calculateOffPeakIndus = baseIndusOffPeakRate; // flat rate applicable
            //        return Convert.ToString(calculateOffPeakIndus);
            //    }
            //    else if (offPeakInput > 1000) // input more than 1000
            //    {
            //        offPeakInput -= 1000; // usage above flat rate
            //        calculateOffPeakIndus = offPeakBill(offPeakInput); // calculate off peak bill amount
            //        return Convert.ToString(calculateOffPeakIndus);
            //    }

                // calculate total industrial bill (peak plus off peak)
              //  double calculateIndus = calculatePeakIndus + calculateOffPeakIndus;
                //return calculateIndus.ToString("c"); // display and add currency format
            //}
        }

    }
}
