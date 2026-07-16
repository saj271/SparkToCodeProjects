using System;

namespace Task2Solution
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////////////////////////////////////////////////////
            // Task 1 - Absolute Difference
            ////////////////////////////////////////////////////

            Console.WriteLine("Task 1 - Absolute Difference");

            Console.Write("Enter the first number: ");
            double firstNumber = double.Parse(Console.ReadLine());

            Console.Write("Enter the second number: ");
            double secondNumber = double.Parse(Console.ReadLine());

            double subtractionResult = firstNumber - secondNumber;
            double positiveDifference = Math.Abs(subtractionResult);

            Console.WriteLine("Positive Difference = " + positiveDifference);

            ////////////////////////////////////////////////////
            // Task 2 - Power & Root Explorer
            ////////////////////////////////////////////////////

            Console.WriteLine("Task 2 - Power & Root Explorer");

            Console.Write("Enter a number: ");
            double powerNumber = double.Parse(Console.ReadLine());

            double square = Math.Pow(powerNumber, 2);
            double squareRoot = Math.Sqrt(powerNumber);

            Console.WriteLine("Square = " + square);
            Console.WriteLine("Square Root = " + squareRoot);

            ////////////////////////////////////////////////////
            // Task 3 - Name Formatter
            ////////////////////////////////////////////////////

            Console.WriteLine("Task 3 - Name Formatter");

            Console.Write("Enter your full name: ");
            string fullName = Console.ReadLine();

            Console.WriteLine("Uppercase = " + fullName.ToUpper());
            Console.WriteLine("Lowercase = " + fullName.ToLower());
            Console.WriteLine("Number of Characters = " + fullName.Length);

            ////////////////////////////////////////////////////
            // Task 4 - Subscription End Date
            ////////////////////////////////////////////////////

            Console.WriteLine("Task 4 - Subscription End Date");

            Console.Write("Enter the number of trial days: ");
            int trialDays = int.Parse(Console.ReadLine());

            DateTime endDate = DateTime.Today.AddDays(trialDays);

            Console.WriteLine("Subscription End Date = " + endDate.ToString("yyyy-MM-dd"));

            ////////////////////////////////////////////////////
            // Task 5 - Grade Rounding System
            ////////////////////////////////////////////////////

            Console.WriteLine("Task 5 - Grade Rounding System");

            Console.Write("Enter your exam score: ");
            double examScore = double.Parse(Console.ReadLine());

            double roundedScore = Math.Round(examScore);

            Console.WriteLine("Rounded Score = " + roundedScore);

            if (roundedScore >= 60)
            {
                Console.WriteLine("Result = Pass");
            }
            else
            {
                Console.WriteLine("Result = Fail");
            }

            ////////////////////////////////////////////////////
            // Task 6 - Password Strength Checker
            ////////////////////////////////////////////////////

            Console.WriteLine("Task 6 - Password Strength Checker");

            Console.Write("Enter a password: ");
            string userPassword = Console.ReadLine();

            if (userPassword.Length >= 8 &&
                !userPassword.ToLower().Contains("password"))
            {
                Console.WriteLine("Strong Password");
            }
            else
            {
                Console.WriteLine("Weak Password");

                if (userPassword.Length < 8)
                {
                    Console.WriteLine("Reason: Password must be at least 8 characters.");
                }

                if (userPassword.ToLower().Contains("password"))
                {
                    Console.WriteLine("Reason: Password must not contain the word 'password'.");
                }
            }

            ////////////////////////////////////////////////////
            // Task 7 - Clean Name Comparator
            ////////////////////////////////////////////////////

            Console.WriteLine("Task 7 - Clean Name Comparator");

            Console.Write("Enter the first name: ");
            string firstName = Console.ReadLine();

            Console.Write("Enter the second name: ");
            string secondName = Console.ReadLine();

            firstName = firstName.Trim().ToUpper();
            secondName = secondName.Trim().ToUpper();

            if (firstName == secondName)
            {
                Console.WriteLine("Match");
            }
            else
            {
                Console.WriteLine("No Match");
            }

            ////////////////////////////////////////////////////
            // Task 8 - Membership Expiry Checker
            ////////////////////////////////////////////////////

            Console.WriteLine("Task 8 - Membership Expiry Checker");

            Console.Write("Enter membership start date (yyyy-MM-dd): ");
            DateTime startDate = DateTime.Parse(Console.ReadLine());

            Console.Write("Enter membership days: ");
            int membershipDays = int.Parse(Console.ReadLine());

            DateTime expiryDate = startDate.AddDays(membershipDays);

            if (expiryDate >= DateTime.Today)
            {
                Console.WriteLine("Status = Active");
            }
            else
            {
                Console.WriteLine("Status = Expired");
            }

            Console.WriteLine("Expiry Date = " + expiryDate.ToString("yyyy-MM-dd"));

            ////////////////////////////////////////////////////
            // Task 9 - Round Up / Round Down Explorer
            ////////////////////////////////////////////////////

            Console.WriteLine("Task 9 - Round Up / Round Down Explorer");

            Console.Write("Enter a decimal number: ");
            double decimalNumber = double.Parse(Console.ReadLine());

            double nearestWhole = Math.Round(decimalNumber);
            double roundedUp = Math.Ceiling(decimalNumber);
            double roundedDown = Math.Floor(decimalNumber);

            Console.WriteLine("Nearest Whole Number = " + nearestWhole);
            Console.WriteLine("Always Rounded Up = " + roundedUp);
            Console.WriteLine("Always Rounded Down = " + roundedDown);
        }
    }
}