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

            //Client and account info
            AccountHolder client1 = new AccountHolder("Shell", "Company LLC.", "332-259-4667", "B.stashingitaway@panama.bank");
            Savings saving1 = new Savings(2000000000.0d, "108111264");
            Checking checking1 = new Checking(1357000.0d, "246730001");

            Console.SetCursorPosition((Console.WindowWidth / 4), 0);
            string makeTransaction = "yes";
            do
            {
                Console.WriteLine("THE CENTRAL BANK OF PANAMA TAX HAVEN");
                Console.WriteLine("\n\n1. View Client Information");
                Console.WriteLine("2. View Account Balance");
                Console.WriteLine("3. Deposit Funds");
                Console.WriteLine("4. Withdraw Funds");
                Console.WriteLine("5. Exit");

                Console.Write("\nSelect option number: ");
                int selection = int.Parse(Console.ReadLine());
                while (selection < 1 || selection > 5)
                {
                    Console.WriteLine("\nSelect a valid option: ");
                    selection = int.Parse(Console.ReadLine());
                }
                Console.WriteLine();
                int subMenu;
                if (selection == 1)
                {
                    client1.ClientInformation();
                    Console.WriteLine("\nSavings account number: " + saving1.AccountNumber() + "\nBalance: " + saving1.GetBalance().ToString("C2"));
                    Console.WriteLine("\nChecking account number: " + checking1.AccountNumber() + "\nBalance: " + checking1.GetBalance().ToString("C2"));
                    makeTransaction = Transaction();
                }

                else if (selection == 5)
                {
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("1. Checking\n2. Savings");
                    Console.Write("Select option number: ");
                }
                if (makeTransaction != "yes" || (selection > 1 && selection < 5))
                {
                    subMenu = int.Parse(Console.ReadLine());
                    while (subMenu < 1 || subMenu > 2)
                    {
                        Console.WriteLine("\nSelect a valid option: ");
                        selection = int.Parse(Console.ReadLine());

                    }
                    if (selection == 2 && subMenu == 1)
                    {
                        Console.WriteLine("\nChecking account balance: "+checking1.GetBalance().ToString("C2"));
                        makeTransaction = Transaction();
                    }
                    else if (selection == 2 && subMenu == 2)
                    {
                        Console.WriteLine("\nSavings account balance: "+saving1.GetBalance().ToString("C2"));
                        makeTransaction = Transaction();
                    }
                    else if (selection == 3 && subMenu == 1)
                    {
                        Console.WriteLine("How  much would you like to deposit into checking today?");
                        double amount = double.Parse(Console.ReadLine());
                        checking1.Deposit(amount);
                        Console.WriteLine(checking1.GetBalance().ToString("C2"));
                        makeTransaction = Transaction();
                    }
                    else if (selection == 3 && subMenu == 2)
                    {
                        Console.WriteLine("How  much would you like to deposit into savings today?");
                        double amount = double.Parse(Console.ReadLine());
                        saving1.Deposit(amount);
                        Console.WriteLine(saving1.GetBalance().ToString("C2"));
                        makeTransaction = Transaction();
                    }
                    else if (selection == 4 && subMenu == 1)
                    {
                        Console.WriteLine("How  much would you like to withdraw from checking today?");
                        double amount = double.Parse(Console.ReadLine());
                        checking1.Withdraw(amount);
                        Console.WriteLine(checking1.GetBalance().ToString("C2"));
                        makeTransaction = Transaction();
                    }
                    else
                    {
                        Console.WriteLine("How  much would you like to withdraw from savings today?");
                        double amount = double.Parse(Console.ReadLine());
                        saving1.Withdraw(amount);
                        Console.WriteLine(saving1.GetBalance().ToString("C2"));
                        makeTransaction = Transaction();
                    }
                }
            }
            while (makeTransaction == "yes");
        }
        public static string Transaction()
        {
            Console.WriteLine("\nWould you like to make another transaction? Yes/No");
            string newTransaction = Console.ReadLine().ToLower();
            
            Console.Clear();
            if (newTransaction == "no")
            {
                Environment.Exit(0);
            }
            return newTransaction;
        }
    }
}