using System;

namespace OOP1
{
    class BankAccount
    {
        public int AccountNumber { get; set; }
        public string HolderName { get; set; }
        public double Balance { get; set; }

        public void Deposit(double amount)
        {
            Balance = Balance + amount;
            SendEmail();
        }

        public void Withdraw(double amount)
        {
            if (Balance >= amount)
            {
                Balance = Balance - amount;
                SendEmail();
            }
            else
            {
                Console.WriteLine("Insufficient balance.");
            }
        }

        public double CheckBalance()
        {
            PrintInformation();
            return Balance;
        }

        private void PrintInformation()
        {
            Console.WriteLine("Holder Name: " + HolderName);
            Console.WriteLine("Balance: " + Balance);
        }

        private void SendEmail()
        {
            Console.WriteLine("Email notification sent.");
        }
    }

    internal class Program
    {
        static BankAccount account1 = new BankAccount();
        static BankAccount account2 = new BankAccount();

        static void Main(string[] args)
        {
            account1.AccountNumber = 1163;
            account1.HolderName = "Karim";
            account1.Balance = 120;

            account2.AccountNumber = 15203;
            account2.HolderName = "Ali";
            account2.Balance = 63;

            bool exitProgram = false;

            while (!exitProgram)
            {
                Console.WriteLine();
                Console.WriteLine("===== OOP Management System =====");
                Console.WriteLine("1. View Account Details");
                Console.WriteLine("20. Exit");
                Console.Write("Choose an option: ");

                int choice;

                try
                {
                    choice = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Invalid input.");
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        ViewAccountDetails();
                        break;

                    case 20:
                        exitProgram = true;
                        Console.WriteLine("Goodbye!");
                        break;

                    default:
                        Console.WriteLine("Invalid option.");
                        break;
                }
            }
        }

        static void ViewAccountDetails()
        {
            Console.WriteLine();
            Console.WriteLine("===== View Account Details =====");
            Console.WriteLine("1. Account 1163 - Karim");
            Console.WriteLine("2. Account 15203 - Ali");
            Console.Write("Choose an account: ");

            int accountChoice;

            try
            {
                accountChoice = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Invalid input.");
                return;
            }

            if (accountChoice == 1)
            {
                account1.CheckBalance();
            }
            else if (accountChoice == 2)
            {
                account2.CheckBalance();
            }
            else
            {
                Console.WriteLine("Invalid account choice.");
            }
        }
    }
}