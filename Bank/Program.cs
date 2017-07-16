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
            Console.WriteLine("Bank of Panama: Where your money \"was\" safe\n\n");
            //Client and account info
            AccountHolder client1 = new AccountHolder("Jonathan", "Alvarado", "216-356-8350", "j.alvrubio@gmail.com");
            Savings saving1 = new Savings(3000.0d, "108111264");
            Checking checking1 = new Checking(1000.0d, "246730001");
            string cont;

            do
            {
                Console.WriteLine("1. View Client Information");
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
                switch (selection)
                {
                    case 1:
                        {
                            client1.ClientInformation();
                            return;
                        }
                    case 5:
                        {
                            client1.ClientInformation();
                            Console.WriteLine("Savings account balance: " + saving1.GetBalance());
                            Console.WriteLine("Checking account balance: " + checking1.GetBalance());
                            Environment.Exit(0);
                            return;
                        }
                    default:
                        {
                            Console.Write("\nSelect option number: ");
                            selection = int.Parse(Console.ReadLine());
                            while (selection < 1 || selection > 2)
                            {
                                Console.WriteLine("\nSelect a valid option: ");
                                selection = int.Parse(Console.ReadLine());
                            }
                            if (selection == 1)
                            {
                                subMenu = selection;
                            }
                            return;
                        }
                }
            }
            while (cont == "yes");
        }
    }
}