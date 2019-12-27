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
        const double baseComRate = 60; // Flat rate for commercial usage (o to 1000 kwh)
        const double baseIndusPeakRate = 76.0; // Flat rate for Industrial Peak usage (o to 1000 kwh)
        const double baseIndusOffPeakRate = 40.0; // Flat rate for Industrial Off peak usage (o to 1000 kwh)
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
                return (rateOffPeakIndus * inputOffPeak) + baseIndusOffPeakRate;
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
                return (ratePeakIndus * inputPeak) + baseIndusPeakRate;
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
                return (rateCom * inputC) + baseComRate;
        }

        // Method call for calculating residential bill
        private static double ResBill(double inputR)
        {
            return (RATE_RES * inputR) + 6;
        }

        // Method call for calculating charge for industrial customers
        public double CalculateCharge(Customer cus, double usage, double offusage)
        {
           
            double bill = 0;
            if (cus.getCusType() == 'I')
            {
                double peak = peakBill(usage);
                double offpeak = offPeakBill(offusage);
                bill =  Math.Round((offpeak + peak), 2);
            }
            return bill;
        }

        // Method call for calculating charge for residential and commercial customers
        public double CalculateCharge(Customer cus, double usage)
        {
            double bill = 0;
   
            // Residential/Commercial button condition(if) - performs calculation for Resdential customer
            if (cus.getCusType() == 'R')// button check
            {
                bill = ResBill(usage); // calculate Residential bill
            }
            if (cus.getCusType() == 'C')
            {
                bill = ComBill(usage);
            }
            return bill;
        }
    }
}
