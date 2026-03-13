using System;
using BankAccount;

namespace BankApp
{
    class Program
    {
        static void Main(string[] args)
        {



            BankAccount1 user1 = new BankAccount1("Genesis", "ACC1001", 5000);
            BankAccount1 user2 = new BankAccount1("David", "ACC2002", 3000);

            if (!CLoginSystem.Login(user1))
                return;

            BankMenu.ShowMenu(user1, user2);
        }
    }
}