using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomerData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerData.Tests
{
    [TestClass()]
    public class CalculationTests
    {
        [TestMethod()]
        public void CalculateChargeForResidentialTest()
        {
            //Arrange
            Calculation cal = new Calculation();
            Customer c = new Customer();
            c.setCusType('R');
            double usage = 100;
            double expectedCharge = 11.2;
            double actualCharge;

            //Act
            actualCharge = cal.CalculateCharge(c, usage);

            //Assert
            Assert.AreEqual(expectedCharge, actualCharge);
        }

        [TestMethod()]
        public void CalculateChargeForCommercialTest()
        {
            //Arrange
            Calculation cal = new Calculation();
            Customer c = new Customer();
            c.setCusType('C');
            double usage = 100;
            double expectedCharge = 60;
            double actualCharge;

            //Act
            actualCharge = cal.CalculateCharge(c, usage);

            //Assert
            Assert.AreEqual(expectedCharge, actualCharge);
        }

        [TestMethod()]
        public void CalculateChargeForCommercialTest2()
        {
            //Arrange
            Calculation cal = new Calculation();
            Customer c = new Customer();
            c.setCusType('C');
            double usage = 1001;
            double expectedCharge = 60.045;
            double actualCharge;

            //Act
            actualCharge = cal.CalculateCharge(c, usage);

            //Assert
            Assert.AreEqual(expectedCharge, actualCharge);
        }

        [TestMethod()]
        public void CalculateChargeForIndustrialTest()
        {
            //Arrange
            Calculation cal = new Calculation();
            Customer c = new Customer();
            c.setCusType('I');
            double usage = 100;
            double secondUsage = 200;
            double expectedCharge = 116;
            double actualCharge;

            //Act
            actualCharge = cal.CalculateCharge(c, usage, secondUsage);

            //Assert
            Assert.AreEqual(expectedCharge, actualCharge);
        }

        [TestMethod()]
        public void CalculateChargeForIndustrialTest2()
        {
            //Arrange
            Calculation cal = new Calculation();
            Customer c = new Customer();
            c.setCusType('I');
            double usage = 1001;
            double secondUsage = 200;
            double expectedCharge = 116.065;
            double actualCharge;

            //Act
            actualCharge = cal.CalculateCharge(c, usage, secondUsage);

            //Assert
            Assert.AreEqual(expectedCharge, actualCharge);
        }

        [TestMethod()]
        public void CalculateChargeForIndustrialTest3()
        {
            //Arrange
            Calculation cal = new Calculation();
            Customer c = new Customer();
            c.setCusType('I');
            double usage = 100;
            double secondUsage = 1001;
            double expectedCharge = 116.028;
            double actualCharge;

            //Act
            actualCharge = cal.CalculateCharge(c, usage, secondUsage);

            //Assert
            Assert.AreEqual(expectedCharge, actualCharge);
        }

        [TestMethod()]
        public void CalculateChargeForIndustrialTest4()
        {
            //Arrange
            Calculation cal = new Calculation();
            Customer c = new Customer();
            c.setCusType('I');
            double usage = 1001;
            double secondUsage = 1001;
            double expectedCharge = 116.093;
            double actualCharge;

            //Act
            actualCharge = cal.CalculateCharge(c, usage, secondUsage);

            //Assert
            Assert.AreEqual(expectedCharge, actualCharge);
        }
    }
}