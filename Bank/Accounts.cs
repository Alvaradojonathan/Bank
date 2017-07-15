using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class Accounts
    {
        protected double balance;
        protected string accountNumber;

        //returning current balance
        public virtual double Balance{ get { return balance; } }

        //assign account number
        public virtual string AccountNumber()
        {
            return accountNumber;
        }

        //depositing an amount and returning a new balance
        public virtual double Deposit(double amount)
        {
            balance += amount;
            return balance;
        }

        //withdrawing an amount and returning a new balance
        public virtual double Withdraw(double amount)
        {
            balance -= amount;
            return balance;
        }
    }
}
