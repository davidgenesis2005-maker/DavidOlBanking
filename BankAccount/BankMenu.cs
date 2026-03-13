using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    public class BankMenu
    {
        public static void ShowMenu(BankAccount1 user1, BankAccount1 user2)
        {
            int choice = 0;

            while (choice != 6)
            {
                Console.WriteLine("\n===== ONLINE BANKING SYSTEM =====");
                Console.WriteLine("1. Deposit ");
                Console.WriteLine("2. Withdraw ");
                Console.WriteLine("3. Send Money ");
                Console.WriteLine("4. Receive Money ");
                Console.WriteLine("5. Check Balance" );
                Console.WriteLine("6. Exit ");
                Console.Write("Enter choice: ");

                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter amount to deposit: ");
                        double dep = Convert.ToDouble(Console.ReadLine());
                        user1.Deposit(dep);

                        Console.WriteLine("\nUpdated Account Info:");
                        user1.DisplayAccount();
                        break;

                    case 2:
                        Console.Write("Enter amount to withdraw: ");
                        double wit = Convert.ToDouble(Console.ReadLine());
                        user1.Withdraw(wit);

                        Console.WriteLine("\nUpdated Account Info:");
                        user1.DisplayAccount();
                        break;

                    case 3:
                        Console.Write("Enter amount to send to David: ");
                        double send = Convert.ToDouble(Console.ReadLine());

                        user1.SendMoney(user2, send);

                        Console.WriteLine("\nSender Info:");
                        user1.DisplayAccount();

                        Console.WriteLine("\nReceiver Info:");
                        user2.DisplayAccount();
                        break;

                    case 4:
                        Console.Write("Enter amount to receive from David: ");
                        double receive = Convert.ToDouble(Console.ReadLine());

                        user2.SendMoney(user1, receive);

                        Console.WriteLine("\nSender Info:");
                        user2.DisplayAccount();

                        Console.WriteLine("\nReceiver Info:");
                        user1.DisplayAccount();
                        break;

                    case 5:
                        user1.DisplayAccount();
                        break;

                    case 6:
                        Console.WriteLine("Thank you for using Online Banking!");
                        break;

                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
            }
        }
    }
}
   