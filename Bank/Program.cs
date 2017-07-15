using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bank of Cleveland");
            AccountHolder client1 = new AccountHolder("Jonathan", "Alvarado", "216-356-8350", "J.AlvRubio@gmail.com");
            Savings saving1 = new Savings(3000.0d,"108111264");
            Checking checking1 = new Checking(1000.0d, "246730001");

            int viewClientInformation = 1;
            int viewAccountBalance = 2;
            int depositFunds = 3;
            int withdrawFunds = 4;
            int exit = 5;
            int checking = 1;
            int savings = 2;
            int menuSelect;
            int subMenuSelect;

            Console.WriteLine("[1] View Client Information\n[2] View Account Balance\n[3] Deposit Funds\n[4] Withdraw Funds\n[5] Exit");
            menuSelect = int.Parse(Console.ReadLine());
            if (menuSelect == viewClientInformation)
            {
                client1.ClientInformation();
            }
            else if (menuSelect == viewAccountBalance)
            {
                Console.WriteLine("[1] Checking Account Balance\n[2] Savings Account Balance");
                subMenuSelect = int.Parse(Console.ReadLine());
                if (subMenuSelect == checking)
                {
                    Console.WriteLine(checking1.GetBalance());
                }
                else
                {
                    Console.WriteLine(saving1.GetBalance());
                }

            }
            else if (menuSelect == depositFunds)
            {
                Console.WriteLine("Deposit\n[1] To Checking Account\n[2] To Savings Account");
                subMenuSelect = int.Parse(Console.ReadLine());
                while (subMenuSelect != checking || subMenuSelect != savings)
                {
                    Console.WriteLine("Pleae select a valid option");
                    subMenuSelect = int.Parse(Console.ReadLine());
                }
                if (subMenuSelect == checking)
                {                    
                    Console.WriteLine("How much will you deposit into your checking account today?");
                    double amount = double.Parse(Console.ReadLine());
                    checking1.Deposit(amount);
                    checking1.GetBalance();
                }
                else
                {
                    Console.WriteLine("How much will you deposit into your savings account today?");
                    double amount = double.Parse(Console.ReadLine());
                    saving1.Deposit(amount);
                    saving1.GetBalance();
                }
            }
            else if (menuSelect == withdrawFunds)
            {
                Console.WriteLine("Withdraw\n[1] From Checking Account\n[2] From Savings Account");
                subMenuSelect = int.Parse(Console.ReadLine());
                while (subMenuSelect != checking || subMenuSelect != savings)
                {
                    Console.WriteLine("Pleae select a valid option");
                    subMenuSelect = int.Parse(Console.ReadLine());
                }
                if (subMenuSelect == checking)
                {
                    Console.WriteLine("How much will you deposit into your checking account today?");
                    double amount = double.Parse(Console.ReadLine());
                    checking1.Withdraw(amount);
                    checking1.GetBalance();
                }
                else
                {
                    Console.WriteLine("How much will you deposit into your savings account today?");
                    double amount = double.Parse(Console.ReadLine());
                    saving1.Withdraw(amount);
                    saving1.GetBalance();
                }
            }
            else if (menuSelect == exit)
            {
                Environment.Exit(0);
            }
        }

    }
}