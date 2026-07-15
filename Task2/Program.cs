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
        }
    }
}
