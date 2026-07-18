using System;
using System.Collections.Generic;

namespace BankingProject
{
    internal class Program
    {
        static List<string> customerNames = new List<string>();
        static List<string> accountNumbers = new List<string>();
        static List<double> balances = new List<double>();

        static void Main(string[] args)
        {
            bool exitApp = false;

            while (!exitApp)
            {
                Console.WriteLine();
                Console.WriteLine("===== Welcome to Spark Bank =====");
                Console.WriteLine("1. Add New Account");
                Console.WriteLine("2. Deposit Money");
                Console.WriteLine("3. Withdraw Money");
                Console.WriteLine("4. Show Balance");
                Console.WriteLine("5. Transfer Amount");
                Console.WriteLine("6. List All Accounts");
                Console.WriteLine("7. Close Account");
                Console.WriteLine("8. Exit");

                Console.Write("Choose an option: ");

                int choice;

                try
                {
                    choice = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine(
                        "Invalid input. Please enter a number from 1 to 8.");

                    continue;
                }

                switch (choice)
                {
                    case 1:
                        AddAccount();
                        break;

                    case 2:
                        DepositMoney();
                        break;

                    case 3:
                        WithdrawMoney();
                        break;

                    case 4:
                        ShowBalance();
                        break;

                    case 5:
                        Console.WriteLine("Transfer service is not added yet.");
                        break;

                    case 6:
                        Console.WriteLine("List accounts service is not added yet.");
                        break;

                    case 7:
                        Console.WriteLine("Close account service is not added yet.");
                        break;

                    case 8:
                        exitApp = true;

                        Console.WriteLine(
                            "Thank you for banking with Spark Bank. Goodbye!");

                        break;

                    default:
                        Console.WriteLine(
                            "Invalid option, please choose between 1 and 8.");

                        break;
                }
            }
        }

        static void AddAccount()
        {
            Console.WriteLine();
            Console.WriteLine("===== Add New Account =====");

            Console.Write("Enter customer name: ");
            string customerName = Console.ReadLine();

            Console.Write("Enter new account number: ");
            string accountNumber = Console.ReadLine();

            if (accountNumbers.Contains(accountNumber))
            {
                Console.WriteLine(
                    "Error: This account number already exists.");

                return;
            }

            Console.Write("Enter initial deposit amount: ");

            double initialDeposit;

            try
            {
                initialDeposit = double.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine(
                    "Invalid amount. Please enter a valid number.");

                return;
            }

            if (initialDeposit < 0)
            {
                Console.WriteLine(
                    "Initial deposit cannot be negative.");

                return;
            }

            customerNames.Add(customerName);
            accountNumbers.Add(accountNumber);
            balances.Add(initialDeposit);

            Console.WriteLine("Account created successfully.");
            Console.WriteLine("Customer Name = " + customerName);
            Console.WriteLine("Account Number = " + accountNumber);
            Console.WriteLine("Starting Balance = " + initialDeposit);
        }

        static void DepositMoney()
        {
            Console.WriteLine();
            Console.WriteLine("===== Deposit Money =====");

            Console.Write("Enter account number: ");
            string accountNumber = Console.ReadLine();

            int accountIndex = accountNumbers.IndexOf(accountNumber);

            if (accountIndex == -1)
            {
                Console.WriteLine("Error: Account number not found.");
                return;
            }

            Console.Write("Enter deposit amount: ");

            double depositAmount;

            try
            {
                depositAmount = double.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine(
                    "Invalid amount. Please enter a valid number.");

                return;
            }

            if (depositAmount <= 0)
            {
                Console.WriteLine(
                    "Deposit amount must be greater than zero.");

                return;
            }

            balances[accountIndex] =
                balances[accountIndex] + depositAmount;

            Console.WriteLine("Deposit completed successfully.");
            Console.WriteLine(
     "Updated Balance = " + balances[accountIndex]);
        }

        static void WithdrawMoney()
        {
            Console.WriteLine();
            Console.WriteLine("===== Withdraw Money =====");

            Console.Write("Enter account number: ");
            string accountNumber = Console.ReadLine();

            int accountIndex = accountNumbers.IndexOf(accountNumber);

            if (accountIndex == -1)
            {
                Console.WriteLine("Error: Account number not found.");
                return;
            }

            Console.Write("Enter withdrawal amount: ");

            double withdrawalAmount;

            try
            {
                withdrawalAmount = double.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine(
                    "Invalid amount. Please enter a valid number.");

                return;
            }

            if (withdrawalAmount <= 0)
            {
                Console.WriteLine(
                    "Withdrawal amount must be greater than zero.");

                return;
            }

            if (withdrawalAmount > balances[accountIndex])
            {
                Console.WriteLine("Error: Insufficient balance.");
                return;
            }

            balances[accountIndex] =
                balances[accountIndex] - withdrawalAmount;

            Console.WriteLine("Withdrawal completed successfully.");
            Console.WriteLine(
     "Updated Balance = " + balances[accountIndex]);
        }

        static void ShowBalance()
        {
            Console.WriteLine();
            Console.WriteLine("===== Show Balance =====");

            Console.Write("Enter account number: ");
            string accountNumber = Console.ReadLine();

            int accountIndex = accountNumbers.IndexOf(accountNumber);

            if (accountIndex == -1)
            {
                Console.WriteLine("Error: Account number not found.");
                return;
            }

            Console.WriteLine(
                "Customer Name = " + customerNames[accountIndex]);

            Console.WriteLine(
                "Account Number = " + accountNumbers[accountIndex]);

            Console.WriteLine(
                "Current Balance = " + balances[accountIndex]);
        }
    }
}
