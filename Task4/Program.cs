using System;

namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////////////////////////////////////////////////////
            // Task 1 - Personalized Welcome Function
            ////////////////////////////////////////////////////

            Console.Write("Enter your name: ");
            string userName = Console.ReadLine();

            PrintWelcome(userName);

            Console.WriteLine();

            ////////////////////////////////////////////////////
            // Task 2 - Square Number Function
            ////////////////////////////////////////////////////

            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());

            int result = Square(number);

            Console.WriteLine("Square = " + result);

            Console.WriteLine();

            ////////////////////////////////////////////////////
            // Task 3 - Celsius to Fahrenheit Function
            ////////////////////////////////////////////////////

            Console.Write("Enter temperature in Celsius: ");
            double celsius = double.Parse(Console.ReadLine());

            double fahrenheit = CelsiusToFahrenheit(celsius);

            Console.WriteLine("Temperature in Fahrenheit = " + fahrenheit);

            Console.WriteLine();

            ////////////////////////////////////////////////////
            // Task 4 - Fixed Menu Display Function
            ////////////////////////////////////////////////////

            DisplayMenu();
        }

        static void PrintWelcome(string name)
        {
            Console.WriteLine("Welcome, " + name + "!");
            Console.WriteLine("We are happy to see you.");
        }

        static int Square(int number)
        {
            return number * number;
        }

        static double CelsiusToFahrenheit(double celsius)
        {
            double fahrenheit = (celsius * 9 / 5) + 32;
            return fahrenheit;
        }

        static void DisplayMenu()
        {
            Console.WriteLine("========== MENU ==========");
            Console.WriteLine("1) Start");
            Console.WriteLine("2) Help");
            Console.WriteLine("3) Exit");
        }
    }
}