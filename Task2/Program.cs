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
        }
    }
}
