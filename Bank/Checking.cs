using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class Checking : Accounts
    {
        public Checking()
        {
            //Default constructor
        }

        //Savings account constructor
        public Checking(double balance, string accountNumber)
        {
            this.balance = balance;
            this.accountNumber = accountNumber;
        }

        //deposit
        public override double Deposit(double amount)
        {
            return base.Deposit(amount);
        }

        //withdraw
        public override double Withdraw(double amount)
        {
                return base.Withdraw(amount);
        }
        public double GetBalance()
        {
            return Balance;
        }
    }
}
