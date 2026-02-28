using System;

namespace OnlineBankingSystem
{
    class BankAccount
    {
    
        public string accountName;
        public string accountNumber;
        public double balance;

        public BankAccount(string name, string number, double initialBalance)
        {
            accountName = name;
            accountNumber = number;
            balance = initialBalance;
        }

        public void DisplayAccount()
        {
            Console.WriteLine("\n--- Account Details ---");
            Console.WriteLine("Account Name: " + accountName);
            Console.WriteLine("Account Number: " + accountNumber);
            Console.WriteLine("Current Balance: ₱" + balance);
        }

        
        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                balance += amount;
                Console.WriteLine("Deposit Successful!");
            }
            else
            {
                Console.WriteLine("Invalid Deposit Amount.");
            }
        }

      
        public void Withdraw(double amount)
        {
            if (amount > 0 && amount <= balance)
            {
                balance -= amount;
                Console.WriteLine("Withdrawal Successful!");
            }
            else
            {
                Console.WriteLine("Invalid or Insufficient Balance.");
            }
        }

       
        public void SendMoney(BankAccount receiver, double amount)
        {
            if (amount > 0 && amount <= balance)
            {
                balance -= amount;
                receiver.ReceiveMoney(amount);
                Console.WriteLine("Money Sent Successfully!");
            }
            else
            {
                Console.WriteLine("Transaction Failed. Check Balance.");
            }
        }

       
        public void ReceiveMoney(double amount)
        {
            balance += amount;
            Console.WriteLine("Money Received: ₱" + amount);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            BankAccount user1 = new BankAccount("Genesis", "ACC1001", 5000);
            BankAccount user2 = new BankAccount("David", "ACC2002", 3000);

            int choice = 0;

            while (choice != 6)
            {
                Console.WriteLine("\n===== ONLINE BANKING SYSTEM =====");
                Console.WriteLine("1. Deposit");
                Console.WriteLine("2. Withdraw");
                Console.WriteLine("3. Send Money");
                Console.WriteLine("4. Receive Money");
                Console.WriteLine("5. Check Balance");
                Console.WriteLine("6. Exit");
                Console.Write("Enter choice: ");

                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter amount to deposit: ");
                        double dep = Convert.ToDouble(Console.ReadLine());
                        user1.Deposit(dep);
                        break;

                    case 2:
                        Console.Write("Enter amount to withdraw: ");
                        double wit = Convert.ToDouble(Console.ReadLine());
                        user1.Withdraw(wit);
                        break;

                    case 3:
                        Console.Write("Enter amount to send to David: ");
                        double send = Convert.ToDouble(Console.ReadLine());
                        user1.SendMoney(user2, send);
                        break;

                    case 4:
                        Console.Write("Enter amount to receive from David: ");
                        double receive = Convert.ToDouble(Console.ReadLine());
                        user2.SendMoney(user1, receive);
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