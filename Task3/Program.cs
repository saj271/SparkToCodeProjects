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
        }
    }
}