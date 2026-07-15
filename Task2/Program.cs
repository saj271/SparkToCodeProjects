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
        }
    }
}
