/*
 * @Author: Rohitashav Aggarwal
 * @Date: 26 December 2019
 * @Purpose: Calculating 3 Customer type Electricity Bills and storing customer data
 * @Class: CPRG-200 lab 2 - OOSD Program - SAIT
*/

using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomerData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerData.Tests
{
    // 1st test case to calculate residential bill
    [TestClass()]
    public class CalculationTests
    {
        [TestMethod()]
        public void CalculateChargeForResidentialTest()
        {
            //Arrange
            Calculation cal = new Calculation();
            Customer c = new Customer();
            c.setCusType('R'); // customer type - residential
            double usage = 100;
            double expectedCharge = 11.2;
            double actualCharge;

            //Act
            actualCharge = cal.CalculateCharge(c, usage); // residential bill method

            //Assert
            Assert.AreEqual(expectedCharge, actualCharge);
        }

        // 2nd test case to calculate commercial bill
        [TestMethod()]
        public void CalculateChargeForCommercialTest()
        {
            //Arrange
            Calculation cal = new Calculation();
            Customer c = new Customer();
            c.setCusType('C'); // customer type - commercial
            double usage = 100;
            double expectedCharge = 60;
            double actualCharge;

            //Act
            actualCharge = cal.CalculateCharge(c, usage); // commercial bill method

            //Assert
            Assert.AreEqual(expectedCharge, actualCharge);
        }

        // 3rd test case to calculate commercial bill with usage over 1000 kwh
        [TestMethod()]
        public void CalculateChargeForCommercialTest2()
        {
            //Arrange
            Calculation cal = new Calculation();
            Customer c = new Customer();
            c.setCusType('C'); // customer type - commercial
            double usage = 1001;
            double expectedCharge = 60.045;
            double actualCharge;

            //Act
            actualCharge = cal.CalculateCharge(c, usage); // commercial bill method

            //Assert
            Assert.AreEqual(expectedCharge, actualCharge);
        }

        // 4th test case to calculate industrial bill with both usage less than 1000
        [TestMethod()]
        public void CalculateChargeForIndustrialTest()
        {
            //Arrange
            Calculation cal = new Calculation();
            Customer c = new Customer();
            c.setCusType('I'); // customer type - industrial
            double usage = 0;
            double secondUsage = 0;
            double expectedCharge = 116;
            double actualCharge;

            //Act
            actualCharge = cal.CalculateCharge(c, usage, secondUsage); // industrial bill method

            //Assert
            Assert.AreEqual(expectedCharge, actualCharge);
        }

        // 5th test case to calculate industrial bill with peakUsage over 1000
        [TestMethod()]
        public void CalculateChargeForIndustrialTest2()
        {
            //Arrange
            Calculation cal = new Calculation();
            Customer c = new Customer();
            c.setCusType('I'); // customer type - industrial
            double usage = 1001;
            double secondUsage = 200;
            double expectedCharge = 116.06;
            double actualCharge;

            //Act
            actualCharge = cal.CalculateCharge(c, usage, secondUsage); // industrial bill method

            //Assert
            Assert.AreEqual(expectedCharge, actualCharge);
        }

        // 6th test case to calculate industrial bill with offPeakUsage over 1000
        [TestMethod()]
        public void CalculateChargeForIndustrialTest3()
        {
            //Arrange
            Calculation cal = new Calculation();
            Customer c = new Customer();
            c.setCusType('I'); // customer type - industrial
            double usage = 100;
            double secondUsage = 1001;
            double expectedCharge = 116.03;
            double actualCharge;

            //Act
            actualCharge = cal.CalculateCharge(c, usage, secondUsage); // industrial bill method

            //Assert
            Assert.AreEqual(expectedCharge, actualCharge);
        }

        // 7th test case to calculate industrial bill with both Usage over 1000
        [TestMethod()]
        public void CalculateChargeForIndustrialTest4()
        {
            //Arrange
            Calculation cal = new Calculation();
            Customer c = new Customer();
            c.setCusType('I'); // customer type - industrial
            double usage = 1001;
            double secondUsage = 1001;
            double expectedCharge = 116.09;
            double actualCharge;

            //Act
            actualCharge = cal.CalculateCharge(c, usage, secondUsage); // industrial bill method

            //Assert
            Assert.AreEqual(expectedCharge, actualCharge);
        }
    }
}