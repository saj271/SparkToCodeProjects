using System;

namespace Task2Solution
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////////////////////////////////////////////////////
            // Task 1 - Countdown Timer
            ////////////////////////////////////////////////////

            Console.Write("Enter the starting number: ");
            int number = int.Parse(Console.ReadLine());

            for (int i = number; i >= 1; i--)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Liftoff!");

            ////////////////////////////////////////////////////
            // Task 2 - Sum of Numbers 1 to N
            ////////////////////////////////////////////////////

            Console.WriteLine("Task 2 - Sum of Numbers 1 to N");

            Console.Write("Enter a positive number: ");
            int n = int.Parse(Console.ReadLine());

            int sum = 0;

            for (int i = 1; i <= n; i++)
            {
                sum = sum + i;
            }

            Console.WriteLine("Sum = " + sum);

            ////////////////////////////////////////////////////
            // Task 3 - Multiplication Table
            ////////////////////////////////////////////////////

            Console.WriteLine("Task 3 - Multiplication Table");

            Console.Write("Enter a number: ");
            int tableNumber = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(tableNumber + " x " + i + " = " + (tableNumber * i));
            }

            ////////////////////////////////////////////////////
            // Task 4 - Password Retry
            ////////////////////////////////////////////////////

            Console.WriteLine("Task 4 - Password Retry");

            string correctPassword = "Spark2026";
            string enteredPassword = "";

            while (enteredPassword != correctPassword)
            {
                Console.Write("Enter password: ");
                enteredPassword = Console.ReadLine();

                if (enteredPassword != correctPassword)
                {
                    Console.WriteLine("Incorrect password, try again");
                }
            }

            Console.WriteLine("Access Granted");

            ////////////////////////////////////////////////////
            // Task 5 - Number Guessing Game
            ////////////////////////////////////////////////////

            Console.WriteLine("Task 5 - Number Guessing Game");

            int secretNumber = 42;
            int guessNumber;
            int attempts = 0;

            do
            {
                Console.Write("Enter your guess: ");
                guessNumber = int.Parse(Console.ReadLine());

                attempts++;

                if (guessNumber > secretNumber)
                {
                    Console.WriteLine("Too high");
                }
                else if (guessNumber < secretNumber)
                {
                    Console.WriteLine("Too low");
                }

            } while (guessNumber != secretNumber);

            Console.WriteLine("Correct!");
            Console.WriteLine("Attempts: " + attempts);

            ////////////////////////////////////////////////////
            // Task 6 - Safe Division Calculator
            ////////////////////////////////////////////////////

            Console.WriteLine("Task 6 - Safe Division Calculator");

            try
            {
                Console.Write("Enter the first number: ");
                double firstNumber = double.Parse(Console.ReadLine());

                Console.Write("Enter the second number: ");
                double secondNumber = double.Parse(Console.ReadLine());

                if (secondNumber == 0)
                {
                    Console.WriteLine("Cannot divide by zero.");
                }
                else
                {
                    double result = firstNumber / secondNumber;
                    Console.WriteLine("Result = " + result);
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter numbers only.");
            }
            catch (Exception)
            {
                Console.WriteLine("An error occurred.");
            }

            ////////////////////////////////////////////////////
            // Task 7 - Repeating Menu with Exit Option
            ////////////////////////////////////////////////////

            Console.WriteLine("Task 7 - Repeating Menu with Exit Option");

            bool exitMenu = false;

            while (!exitMenu)
            {
                Console.WriteLine("\n===== MENU =====");
                Console.WriteLine("1. Say Hello");
                Console.WriteLine("2. Show Greeting");
                Console.WriteLine("3. Exit");

                try
                {
                    Console.Write("Choose an option: ");
                    int menuChoice = int.Parse(Console.ReadLine());

                    switch (menuChoice)
                    {
                        case 1:
                            Console.WriteLine("Hello!");
                            break;

                        case 2:
                            Console.WriteLine("Good Morning!");
                            break;

                        case 3:
                            Console.WriteLine("Goodbye!");
                            exitMenu = true;
                            break;

                        default:
                            Console.WriteLine("Invalid option.");
                            break;
                    }
                }
                catch
                {
                    Console.WriteLine("Please enter a valid number.");
                }
            }

            ////////////////////////////////////////////////////
            // Task 8 - Sum of Even Numbers Only
            ////////////////////////////////////////////////////

            Console.WriteLine("Task 8 - Sum of Even Numbers Only");

            Console.Write("Enter a positive whole number: ");
            int evenLimit = int.Parse(Console.ReadLine());

            int evenSum = 0;

            for (int i = 1; i <= evenLimit; i++)
            {
                if (i % 2 == 0)
                {
                    evenSum = evenSum + i;
                }
            }

            Console.WriteLine("Sum of even numbers = " + evenSum);
        }
    }
}
