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

    class Product
    {
        public string ProductName { get; set; }
        public double Price { get; set; }
        public int StockQuantity { get; set; }

        public void Sell(int quantity)
        {
            if (StockQuantity >= quantity)
            {
                StockQuantity = StockQuantity - quantity;
            }
            else
            {
                Console.WriteLine("Not enough stock.");
            }

            LogTransaction();
        }

        public void Restock(int quantity)
        {
            StockQuantity = StockQuantity + quantity;
            LogTransaction();
        }

        public double GetInventoryValue()
        {
            PrintDetails();
            return Price * StockQuantity;
        }

        private void PrintDetails()
        {
            Console.WriteLine("Product Name: " + ProductName);
            Console.WriteLine("Price: " + Price);
            Console.WriteLine("Stock Quantity: " + StockQuantity);
        }

        private void LogTransaction()
        {
            Console.WriteLine("Transaction logged.");
        }
    }
    internal class Program
    {
        static BankAccount account1 = new BankAccount();
        static BankAccount account2 = new BankAccount();

        static Student student1 = new Student();
        static Student student2 = new Student();

        static Product product1 = new Product();
        static Product product2 = new Product();

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

            product1.ProductName = "Wireless Mouse";
            product1.Price = 5.500;
            product1.StockQuantity = 50;

            product2.ProductName = "Mechanical Keyboard";
            product2.Price = 15.750;
            product2.StockQuantity = 20;


            bool exitProgram = false;

            while (!exitProgram)
            {
                Console.WriteLine();
                Console.WriteLine("===== OOP Management System =====");
                Console.WriteLine("1. View Account Details");
                Console.WriteLine("2. Update Student Address");
                Console.WriteLine("3. Make a Deposit");
                Console.WriteLine("4. Make a Withdrawal");
                Console.WriteLine("5. View Product Details");
                Console.WriteLine("6. Register a Student");
                Console.WriteLine("7. Compare Two Account Balances");
                Console.WriteLine("8. Restock Product");
                Console.WriteLine("9. Transfer Between Accounts");
                Console.WriteLine("10. Update Student Grade");
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

                    case 4:
                        MakeWithdrawal();
                        break;

                    case 5:
                        ViewProductDetails();
                        break;

                    case 6:
                        RegisterStudent();
                        break;

                    case 7:
                        CompareAccountBalances();
                        break;

                    case 8:
                        RestockProduct();
                        break;

                    case 9:
                        TransferBetweenAccounts();
                        break;

                    case 10:
                        UpdateStudentGrade();
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
        static void MakeWithdrawal()
        {
            Console.WriteLine();
            Console.WriteLine("===== Make a Withdrawal =====");

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

            Console.Write("Enter withdrawal amount: ");

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
                account1.Withdraw(amount);

                Console.WriteLine("Holder Name: " + account1.HolderName);
                Console.WriteLine("Updated Balance: " + account1.Balance);
            }
            else if (accountChoice == 2)
            {
                account2.Withdraw(amount);

                Console.WriteLine("Holder Name: " + account2.HolderName);
                Console.WriteLine("Updated Balance: " + account2.Balance);
            }
            else
            {
                Console.WriteLine("Invalid account choice.");
            }
        }

        static void ViewProductDetails()
        {
            Console.WriteLine();
            Console.WriteLine("===== View Product Details =====");

            Console.WriteLine("1. Wireless Mouse");
            Console.WriteLine("2. Mechanical Keyboard");
            Console.Write("Choose a product: ");

            int productChoice;

            try
            {
                productChoice = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Invalid input.");
                return;
            }

            double inventoryValue;

            if (productChoice == 1)
            {
                inventoryValue = product1.GetInventoryValue();

                Console.WriteLine(
                    "Total Inventory Value: " + inventoryValue);
            }
            else if (productChoice == 2)
            {
                inventoryValue = product2.GetInventoryValue();

                Console.WriteLine(
                    "Total Inventory Value: " + inventoryValue);
            }
            else
            {
                Console.WriteLine("Invalid product choice.");
            }
        }

        static void RegisterStudent()
        {
            Console.WriteLine();
            Console.WriteLine("===== Register a Student =====");

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

            if (studentChoice != 1 && studentChoice != 2)
            {
                Console.WriteLine("Invalid student choice.");
                return;
            }

            Console.Write("Enter student email: ");
            string studentEmail = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(studentEmail))
            {
                Console.WriteLine("Email cannot be empty.");
                return;
            }

            if (studentChoice == 1)
            {
                student1.Register(studentEmail);

                Console.WriteLine(
                    "Student " + student1.Name + " registered successfully.");
            }
            else
            {
                student2.Register(studentEmail);

                Console.WriteLine(
                    "Student " + student2.Name + " registered successfully.");
            }
        }

        static void CompareAccountBalances()
        {
            Console.WriteLine();
            Console.WriteLine("===== Compare Two Account Balances =====");

            if (account1.Balance > account2.Balance)
            {
                Console.WriteLine(account1.HolderName + " has the higher balance.");
                Console.WriteLine("Balance = " + account1.Balance);
            }
            else if (account2.Balance > account1.Balance)
            {
                Console.WriteLine(account2.HolderName + " has the higher balance.");
                Console.WriteLine("Balance = " + account2.Balance);
            }
            else
            {
                Console.WriteLine("Both accounts have the same balance.");
                Console.WriteLine("Balance = " + account1.Balance);
            }
        }

        static void RestockProduct()
        {
            Console.WriteLine();
            Console.WriteLine("===== Restock Product =====");

            Console.WriteLine("1. Wireless Mouse");
            Console.WriteLine("2. Mechanical Keyboard");
            Console.Write("Choose a product: ");

            int productChoice;

            try
            {
                productChoice = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Invalid input.");
                return;
            }

            if (productChoice != 1 && productChoice != 2)
            {
                Console.WriteLine("Invalid product choice.");
                return;
            }

            Console.Write("Enter quantity to add: ");

            int quantity;

            try
            {
                quantity = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Invalid quantity.");
                return;
            }

            if (quantity <= 0)
            {
                Console.WriteLine("Quantity must be greater than zero.");
                return;
            }

            Product selectedProduct;

            if (productChoice == 1)
            {
                selectedProduct = product1;
            }
            else
            {
                selectedProduct = product2;
            }

            selectedProduct.Restock(quantity);

            Console.WriteLine("Product restocked successfully.");
            Console.WriteLine("Current Stock = " + selectedProduct.StockQuantity);

            if (selectedProduct.StockQuantity < 10)
            {
                Console.WriteLine("Stock Level: Low");
            }
            else if (selectedProduct.StockQuantity < 50)
            {
                Console.WriteLine("Stock Level: Moderate");
            }
            else
            {
                Console.WriteLine("Stock Level: Well Stocked");
            }
        }

        static void TransferBetweenAccounts()
        {
            Console.WriteLine();
            Console.WriteLine("===== Transfer Between Accounts =====");

            Console.WriteLine("1. Karim");
            Console.WriteLine("2. Ali");
            Console.Write("Choose the source account: ");

            int sourceChoice;

            if (!int.TryParse(Console.ReadLine(), out sourceChoice))
            {
                Console.WriteLine("Invalid input.");
                return;
            }

            Console.Write("Choose the destination account: ");

            int destinationChoice;

            if (!int.TryParse(Console.ReadLine(), out destinationChoice))
            {
                Console.WriteLine("Invalid input.");
                return;
            }

            if ((sourceChoice != 1 && sourceChoice != 2) ||
                (destinationChoice != 1 && destinationChoice != 2))
            {
                Console.WriteLine("Invalid account choice.");
                return;
            }

            if (sourceChoice == destinationChoice)
            {
                Console.WriteLine(
                    "Source and destination accounts cannot be the same.");

                return;
            }

            Console.Write("Enter transfer amount: ");

            double amount;

            if (!double.TryParse(Console.ReadLine(), out amount))
            {
                Console.WriteLine("Invalid amount.");
                return;
            }

            if (amount <= 0)
            {
                Console.WriteLine("Amount must be greater than zero.");
                return;
            }

            BankAccount sourceAccount;
            BankAccount destinationAccount;

            if (sourceChoice == 1)
            {
                sourceAccount = account1;
            }
            else
            {
                sourceAccount = account2;
            }

            if (destinationChoice == 1)
            {
                destinationAccount = account1;
            }
            else
            {
                destinationAccount = account2;
            }

            if (sourceAccount.Balance < amount)
            {
                Console.WriteLine("Transfer failed: Insufficient balance.");
                return;
            }

            sourceAccount.Withdraw(amount);
            destinationAccount.Deposit(amount);

            Console.WriteLine("Transfer completed successfully.");
            Console.WriteLine(
                "Source Account Balance: " + sourceAccount.Balance);

            Console.WriteLine(
                "Destination Account Balance: " + destinationAccount.Balance);
        }
    

    static void UpdateStudentGrade()
        {
            Console.WriteLine();
            Console.WriteLine("===== Update Student Grade =====");

            Console.WriteLine("1. Ali");
            Console.WriteLine("2. Ahmed");
            Console.Write("Choose a student: ");

            int studentChoice;

            if (!int.TryParse(Console.ReadLine(), out studentChoice))
            {
                Console.WriteLine("Invalid input.");
                return;
            }

            if (studentChoice != 1 && studentChoice != 2)
            {
                Console.WriteLine("Invalid student choice.");
                return;
            }

            Console.Write("Enter the new grade: ");

            int newGrade;

            if (!int.TryParse(Console.ReadLine(), out newGrade))
            {
                Console.WriteLine("Invalid grade. Please enter a number.");
                return;
            }

            if (newGrade < 0 || newGrade > 100)
            {
                Console.WriteLine("Grade must be between 0 and 100.");
                return;
            }

            if (studentChoice == 1)
            {
                student1.Grade = newGrade;

                Console.WriteLine("Grade updated successfully.");
                Console.WriteLine("Student Name: " + student1.Name);
                Console.WriteLine("New Grade: " + student1.Grade);
            }
            else
            {
                student2.Grade = newGrade;

                Console.WriteLine("Grade updated successfully.");
                Console.WriteLine("Student Name: " + student2.Name);
                Console.WriteLine("New Grade: " + student2.Grade);
            }
        }
    }
}
