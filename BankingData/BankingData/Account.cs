using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingData
{
    public class Account
    {
        private static int nextNo = 100; // first account no gets 100
        private int accountNo;
        private decimal balance;
    
        // read-only
        public decimal Balance { get { return balance; } }

        //constructor
        public Account(decimal initBalance)
        {
            accountNo = nextNo;
            nextNo++; // prepares for next account
            if (initBalance >= 0)
                balance = initBalance;
            else // negative initbalance
                balance = 0;
        }

        // public methods
        public void Deposit (decimal amount) // ignore negative
        {
            if (amount < 0)
                amount = 0;
            balance += amount;
        }

        public bool Withdraw (decimal amount) // ignore negative
        {
            if (amount < 0)
                amount = 0;
            if (amount <= balance) // good
            {
                balance -= amount;
                return true;
            }
            else // NSF
                return false;
        }

        public override string ToString()
        {
            return accountNo.ToString() + ": " + balance.ToString("c");
        }

    }
}
