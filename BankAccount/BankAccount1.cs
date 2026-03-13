using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    public class BankAccount1
    {
        public string accountName;
        public string accountNumber;
        public double balance;

        public BankAccount1(string name, string number, double initialBalance)
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
            Console.WriteLine("Current Balance: PHP: " + balance);
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

        public void SendMoney(BankAccount1 receiver, double amount)
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
            Console.WriteLine("Money Received: PHP: " + amount);
        }
    }
}
  