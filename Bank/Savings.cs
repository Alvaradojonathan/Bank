using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class Savings : Accounts
    {
        public Savings()
        {
            //Default constructor
        }

        //Savings account constructor
        public Savings(double balance, string accountNumber)
        {
            this.balance = balance;
            this.accountNumber = accountNumber;

        }

        //deposit
        public override double Deposit(double amount)
        {
            return base.Deposit(amount);
        }

        //withdraw, not allowed if balance will be negative
        public override double Withdraw(double amount)
        {
            if (amount > balance)
            {
                throw new Exception("Transaction Denied. Contact your bank.");
            }
            else
            {
                balance -= amount;
                return balance;
            }
        }
        public double GetBalance()
        {
            return Balance;
        }

        public override string AccountNumber()
        {
            return accountNumber;
        }
    }
}
