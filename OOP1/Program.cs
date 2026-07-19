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

    class Student
    {
        public int Grade { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

        private string email;
        int age;

        public void Register(string Email)
        {
            email = Email;
            SendEmail();
        }

        private void SendEmail()
        {
            Console.WriteLine("Registration email sent.");
        }
    }

    internal class Program
    {
        static BankAccount account1 = new BankAccount();
        static BankAccount account2 = new BankAccount();

        static Student student1 = new Student();
        static Student student2 = new Student();

        static void Main(string[] args)
        {
            account1.AccountNumber = 1163;
            account1.HolderName = "Karim";
            account1.Balance = 120;

            account2.AccountNumber = 15203;
            account2.HolderName = "Ali";
            account2.Balance = 63;

            student1.Name = "Ali";
            student1.Address = "Muscat";
            student1.Grade = 65;

            student2.Name = "Ahmed";
            student2.Address = "Muscat";
            student2.Grade = 70;

            bool exitProgram = false;

            while (!exitProgram)
            {
                Console.WriteLine();
                Console.WriteLine("===== OOP Management System =====");
                Console.WriteLine("1. View Account Details");
                Console.WriteLine("2. Update Student Address");
                Console.WriteLine("3. Make a Deposit");
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

                    case 2:
                        UpdateStudentAddress();
                        break;

                    case 3:
                        MakeDeposit();
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

        static void UpdateStudentAddress()
            {
                Console.WriteLine();
                Console.WriteLine("===== Update Student Address =====");

                Console.WriteLine("1. Ali");
                Console.WriteLine("2. Ahmed");
                Console.Write("Choose a student: ");

                int studentChoice;

                try
                {
                    studentChoice = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Invalid input.");
                    return;
                }

                Console.Write("Enter the new address: ");
                string newAddress = Console.ReadLine();

                if (studentChoice == 1)
                {
                    student1.Address = newAddress;

                    Console.WriteLine("Address updated successfully.");
                    Console.WriteLine("Student Name: " + student1.Name);
                    Console.WriteLine("New Address: " + student1.Address);
                }
                else if (studentChoice == 2)
                {
                    student2.Address = newAddress;

                    Console.WriteLine("Address updated successfully.");
                    Console.WriteLine("Student Name: " + student2.Name);
                    Console.WriteLine("New Address: " + student2.Address);
                }
                else
                {
                    Console.WriteLine("Invalid student choice.");
                }
        }
        static void MakeDeposit()
        {
            Console.WriteLine();
            Console.WriteLine("===== Make a Deposit =====");

            Console.WriteLine("1. Karim");
            Console.WriteLine("2. Ali");
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

            Console.Write("Enter deposit amount: ");

            double amount;

            try
            {
                amount = double.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Invalid amount.");
                return;
            }

            if (amount <= 0)
            {
                Console.WriteLine("Amount must be greater than zero.");
                return;
            }

            if (accountChoice == 1)
            {
                account1.Deposit(amount);

                Console.WriteLine("Deposit completed successfully.");
                Console.WriteLine("Holder Name: " + account1.HolderName);
                Console.WriteLine("Updated Balance: " + account1.Balance);
            }
            else if (accountChoice == 2)
            {
                account2.Deposit(amount);

                Console.WriteLine("Deposit completed successfully.");
                Console.WriteLine("Holder Name: " + account2.HolderName);
                Console.WriteLine("Updated Balance: " + account2.Balance);
            }
            else
            {
                Console.WriteLine("Invalid account choice.");
            }
        }

    }
}
