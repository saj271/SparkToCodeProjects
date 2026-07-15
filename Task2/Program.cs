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

            ////////////////////////////////////////////////////
            // Task 9 - Validated Positive Number Input
            ////////////////////////////////////////////////////

            Console.WriteLine("Task 9 - Validated Positive Number Input");

            int positiveNumber = 0;
            bool validInput = false;

            do
            {
                try
                {
                    Console.Write("Enter a positive whole number: ");
                    positiveNumber = int.Parse(Console.ReadLine());

                    if (positiveNumber > 0)
                    {
                        validInput = true;
                    }
                    else
                    {
                        Console.WriteLine("Please enter a number greater than zero.");
                    }
                }
                catch
                {
                    Console.WriteLine("Invalid input. Please enter a whole number.");
                }

            } while (!validInput);

            int totalSum = 0;

            for (int i = 1; i <= positiveNumber; i++)
            {
                totalSum = totalSum + i;
            }

            Console.WriteLine("Sum = " + totalSum);

            ////////////////////////////////////////////////////
            // Task 10 - Simple ATM Simulation
            ////////////////////////////////////////////////////

            Console.WriteLine("Task 10 - Simple ATM Simulation");

            int correctPin = 1234;
            double atmBalance = 100.000;
            int pinAttempts = 0;
            bool pinAccepted = false;

            while (pinAttempts < 3 && !pinAccepted)
            {
                try
                {
                    Console.Write("Enter PIN: ");
                    int enteredPin = int.Parse(Console.ReadLine());

                    if (enteredPin == correctPin)
                    {
                        pinAccepted = true;
                    }
                    else
                    {
                        pinAttempts++;
                        Console.WriteLine("Incorrect PIN");
                    }
                }
                catch
                {
                    pinAttempts++;
                    Console.WriteLine("Invalid PIN");
                }
            }

            if (!pinAccepted)
            {
                Console.WriteLine("Card Blocked");
            }
            else
            {
                bool atmRunning = true;

                while (atmRunning)
                {
                    Console.WriteLine("\n===== ATM MENU =====");
                    Console.WriteLine("1. Deposit");
                    Console.WriteLine("2. Withdraw");
                    Console.WriteLine("3. Check Balance");
                    Console.WriteLine("4. Exit");

                    try
                    {
                        Console.Write("Choose an option: ");
                        int atmChoice = int.Parse(Console.ReadLine());

                        switch (atmChoice)
                        {
                            case 1:
                                try
                                {
                                    Console.Write("Enter deposit amount: ");
                                    double depositAmount = double.Parse(Console.ReadLine());

                                    if (depositAmount <= 0)
                                    {
                                        Console.WriteLine("Amount must be positive.");
                                    }
                                    else
                                    {
                                        atmBalance = atmBalance + depositAmount;

                                        Console.WriteLine(
                                            "New Balance: " +
                                            atmBalance.ToString("F3") +
                                            " OMR"
                                        );
                                    }
                                }
                                catch
                                {
                                    Console.WriteLine("Invalid amount.");
                                }

                                break;

                            case 2:
                                try
                                {
                                    Console.Write("Enter withdrawal amount: ");
                                    double withdrawalAmount = double.Parse(Console.ReadLine());

                                    if (withdrawalAmount <= 0)
                                    {
                                        Console.WriteLine("Amount must be positive.");
                                    }
                                    else if (withdrawalAmount > atmBalance)
                                    {
                                        Console.WriteLine("Insufficient balance.");
                                    }
                                    else
                                    {
                                        atmBalance = atmBalance - withdrawalAmount;

                                        Console.WriteLine(
                                            "New Balance: " +
                                            atmBalance.ToString("F3") +
                                            " OMR"
                                        );
                                    }
                                }
                                catch
                                {
                                    Console.WriteLine("Invalid amount.");
                                }

                                break;

                            case 3:
                                Console.WriteLine(
                                    "Current Balance: " +
                                    atmBalance.ToString("F3") +
                                    " OMR"
                                );
                                break;

                            case 4:
                                Console.WriteLine("Thank you for using the ATM.");
                                atmRunning = false;
                                break;

                            default:
                                Console.WriteLine("Invalid option.");
                                break;
                        }
                    }
                    catch
                    {
                        Console.WriteLine("Please enter a valid menu number.");
                    }
                }
            }
        }
    }
}
