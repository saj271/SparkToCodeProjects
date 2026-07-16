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

           
        }
    }
}