using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    public class CLoginSystem
    {
        public static bool Login(BankAccount1 user)
        {
            Console.WriteLine("===== ONLINE BANKING LOGIN =====");
            Console.Write("Enter your Account Number: ");
            string accInput = Console.ReadLine();

            if (accInput != user.accountNumber)
            {
                Console.WriteLine("Invalid Account Number. Access Denied.");
                return false;
            }

            Console.WriteLine("\nLogin Successful!");
            user.DisplayAccount();
            return true;
        }
    }
}
   