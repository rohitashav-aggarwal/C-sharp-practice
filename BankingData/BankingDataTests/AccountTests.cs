using Microsoft.VisualStudio.TestTools.UnitTesting;
using BankingData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingData.Tests
{
    [TestClass()]
    public class AccountTests
    {
        // constructor with positve intial balance

        // constructor with negative intial balance


        // deposit with positve amount

        // deposit with negative amount


        // withdraw with negative amount
        [TestMethod()]
        public void WithdrawTestNegativeAmount()
        {
            // Arrange
            Account acct = new Account(500);
            decimal amount = -100;
            decimal expectedBalance = 500;
            bool expectedResult = true;
            decimal actualBalance;
            bool actualResult;

            // Act
            actualResult = acct.Withdraw(amount);
            actualBalance = acct.Balance;

            //Assert
            Assert.AreEqual(expectedBalance, actualBalance);
            Assert.AreEqual(expectedResult, actualResult);

        }
        //withdraw with positive amount <= balance
        [TestMethod()]
        public void WithdrawTestPositiveAmount()
        {
            // Arrange
            Account acct = new Account(500);
            decimal amount = 100;
            decimal expectedBalance = 400;
            decimal actualBalance;

            // Act
            acct.Withdraw(amount);
            actualBalance = acct.Balance;

            //Assert
            Assert.AreEqual(expectedBalance, actualBalance);

        }
        //withdraw with positive amount > balance (NSF)
        [TestMethod()]
        public void WithdrawTestNSF()
        {
            // Arrange
            Account acct = new Account(500);
            decimal amount = 700;
            decimal expectedBalance = 500;
            decimal actualBalance;

            // Act
            acct.Withdraw(amount);
            actualBalance = acct.Balance;

            //Assert
            Assert.AreEqual(expectedBalance, actualBalance);

        }
    }
}