using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class AccountHolder : Clients
    {
        private string firstName;
        private string lastName;
        private string phoneNumber;
        private string email;

        public string FirstName { get; }
        public string LastName { get; }
        public string PhoneNumber { get; }
        public string Email { get; }

        public AccountHolder()
        {
            // default Constructor
        }

        public AccountHolder(string firstName, string lastName, string phoneNumber, string email)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.phoneNumber = phoneNumber;
            this.email = email;
        }
        public override void ClientInformation()
        {
            Console.SetCursorPosition((Console.WindowWidth / 3), 13);
            Console.WriteLine("Account Information:\nName: " + firstName + " " + lastName);
            Console.WriteLine("\nPhone Number: " + phoneNumber);
            Console.WriteLine("\nE-Mail Address: " + email);
        }
    }
}
