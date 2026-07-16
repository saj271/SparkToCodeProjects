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

            double difference = firstNumber - secondNumber;
            double absoluteDifference = Math.Abs(difference);

            Console.WriteLine("Absolute Difference = " + absoluteDifference);

            ////////////////////////////////////////////////////
            // Task 2 - Power & Root Explorer
            ////////////////////////////////////////////////////

            Console.WriteLine("Task 2 - Power & Root Explorer");

            Console.Write("Enter a number: ");
            double powerNumber = double.Parse(Console.ReadLine());

            double squareResult = Math.Pow(powerNumber, 2);
            double squareRootResult = Math.Sqrt(powerNumber);

            Console.WriteLine("Square = " + squareResult);
            Console.WriteLine("Square Root = " + squareRootResult);

            ////////////////////////////////////////////////////
            // Task 3 - Rounding Demonstration
            ////////////////////////////////////////////////////

            Console.WriteLine("Task 3 - Rounding Demonstration");

            Console.Write("Enter a decimal number: ");
            double decimalNumber = double.Parse(Console.ReadLine());

            Console.WriteLine("Rounded = " + Math.Round(decimalNumber));
            Console.WriteLine("Ceiling = " + Math.Ceiling(decimalNumber));
            Console.WriteLine("Floor = " + Math.Floor(decimalNumber));

            ////////////////////////////////////////////////////
            // Task 4 - Trigonometry Explorer
            ////////////////////////////////////////////////////

            Console.WriteLine("Task 4 - Trigonometry Explorer");

            Console.Write("Enter an angle in degrees: ");
            double angleDegrees = double.Parse(Console.ReadLine());

            double angleRadians = angleDegrees * Math.PI / 180;

            Console.WriteLine("Sin = " + Math.Sin(angleRadians));
            Console.WriteLine("Cos = " + Math.Cos(angleRadians));
            Console.WriteLine("Tan = " + Math.Tan(angleRadians));

            ////////////////////////////////////////////////////
            // Task 5 - Random Number Generator
            ////////////////////////////////////////////////////

            Console.WriteLine("Task 5 - Random Number Generator");

            Random randomGenerator = new Random();

            int randomNumber = randomGenerator.Next(1, 101);

            Console.WriteLine("Random Number = " + randomNumber);

            ////////////////////////////////////////////////////
            // Task 6 - Password Strength Checker
            ////////////////////////////////////////////////////

            Console.WriteLine("Task 6 - Password Strength Checker");

            Console.Write("Enter your password: ");
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

            Console.WriteLine("Expiry Date: " + expiryDate.ToString("yyyy-MM-dd"));

            if (expiryDate >= DateTime.Today)
            {
                Console.WriteLine("Membership Status: Active");
            }
            else
            {
                Console.WriteLine("Membership Status: Expired");
            }

            ////////////////////////////////////////////////////
            // Task 9 - Round Up / Round Down Explorer
            ////////////////////////////////////////////////////

            Console.WriteLine("Task 9 - Round Up / Round Down Explorer");

            Console.Write("Enter a decimal number: ");
            double roundingNumber = double.Parse(Console.ReadLine());

            double nearestWhole = Math.Round(roundingNumber);
            double roundedUp = Math.Ceiling(roundingNumber);
            double roundedDown = Math.Floor(roundingNumber);

            Console.WriteLine("Nearest Whole Number = " + nearestWhole);
            Console.WriteLine("Always Rounded Up = " + roundedUp);
            Console.WriteLine("Always Rounded Down = " + roundedDown);

            ////////////////////////////////////////////////////
            // Task 10 - Number Guessing Game with Hints
            ////////////////////////////////////////////////////

            Console.WriteLine("Task 10 - Number Guessing Game with Hints");

            Random gameRandom = new Random();

            int secretNumber = gameRandom.Next(1, 101);

            int userGuess = 0;

            while (userGuess != secretNumber)
            {
                Console.Write("Guess a number between 1 and 100: ");
                userGuess = int.Parse(Console.ReadLine());

                int guessDifference = Math.Abs(userGuess - secretNumber);

                if (userGuess == secretNumber)
                {
                    Console.WriteLine("Correct! You guessed the number.");
                }
                else if (guessDifference <= 5)
                {
                    Console.WriteLine("Very Close!");
                }
                else if (userGuess > secretNumber)
                {
                    Console.WriteLine("Too High!");
                }
                else
                {
                    Console.WriteLine("Too Low!");
                }
            }
        }
    }
}