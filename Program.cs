using System;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;
namespace Olbanking
{
    internal class BankAccountSystem
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ONlINE BANKING: DEPO/WITH/SEND/RECEIVE");
        }
        public string accountName;
        public string accountNumber;
        public double Balance;



        public void BankAccount(string name, string number, double initialBalance)
        {
            accountName = name;
            accountNumber = number;
            Balance = initialBalance;
        }
        public void DisplayAccount()
        {
            Console.WriteLine("---Account Details---");
            Console.WriteLine("Account Name: " + accountName);
            Console.WriteLine("Account Number: " + accountNumber);
            Console.WriteLine("Current Balance: P" + Balance);
        }

        public void Deposit(double amount)
        {

            if (amount < 0)
            {
                Balance += amount;
                Console.WriteLine("Deposit Successfully! ");

            }
            else
            {
                Console.WriteLine("Invalid Deposit Ammount! ");
            }


        }
        public void Withdraw(double amount)
        {
            if (amount > 0 && amount <= Balance)
            {
                Balance -= amount;
                Console.WriteLine("Withdrawal Successfully! ");
            }
            else
            {
                Console.WriteLine("Insufficient Ammount. ");
            }
        }
        public void Send(BankAccountSystem receiver, double amount)
        {
            if (amount > 0 && amount <= Balance) ;
            {
                Balance -= amount;
                Console.WriteLine("You Have Successfully Send the Money! ");

            }else
                Console.WriteLine("You Don't Have Enough Balance. ");
            {



            }


        }
    }
}