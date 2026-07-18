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

            Console.WriteLine("Task 1 - Personalized Welcome Function");

            Console.Write("Enter your name: ");
            string userName = Console.ReadLine();

            PrintWelcome(userName);

            ////////////////////////////////////////////////////
            // Task 2 - Square Number Function
            ////////////////////////////////////////////////////

            Console.WriteLine("Task 2 - Square Number Function");

            Console.Write("Enter a number: ");
            int squareNumber = int.Parse(Console.ReadLine());

            int squareResult = Square(squareNumber);

            Console.WriteLine("Square = " + squareResult);

            ////////////////////////////////////////////////////
            // Task 3 - Celsius to Fahrenheit Function
            ////////////////////////////////////////////////////

            Console.WriteLine("Task 3 - Celsius to Fahrenheit Function");

            Console.Write("Enter temperature in Celsius: ");
            double celsius = double.Parse(Console.ReadLine());

            double fahrenheit = CelsiusToFahrenheit(celsius);

            Console.WriteLine("Temperature in Fahrenheit = " + fahrenheit);

            ////////////////////////////////////////////////////
            // Task 4 - Fixed Menu Display Function
            ////////////////////////////////////////////////////

            Console.WriteLine("Task 4 - Fixed Menu Display Function");

            DisplayMenu();

            ////////////////////////////////////////////////////
            // Task 5 - Even or Odd Function
            ////////////////////////////////////////////////////

            Console.WriteLine("Task 5 - Even or Odd Function");

            Console.Write("Enter a number: ");
            int evenNumber = int.Parse(Console.ReadLine());

            bool isNumberEven = IsEven(evenNumber);

            if (isNumberEven)
            {
                Console.WriteLine("Even");
            }
            else
            {
                Console.WriteLine("Odd");
            }

            ////////////////////////////////////////////////////
            // Task 6 - Rectangle Area & Perimeter Functions
            ////////////////////////////////////////////////////

            Console.WriteLine("Task 6 - Rectangle Area & Perimeter Functions");

            Console.Write("Enter length: ");
            double rectangleLength = double.Parse(Console.ReadLine());

            Console.Write("Enter width: ");
            double rectangleWidth = double.Parse(Console.ReadLine());

            double rectangleArea =
                CalculateArea(rectangleLength, rectangleWidth);

            double rectanglePerimeter =
                CalculatePerimeter(rectangleLength, rectangleWidth);

            Console.WriteLine("Area = " + rectangleArea);
            Console.WriteLine("Perimeter = " + rectanglePerimeter);

            ////////////////////////////////////////////////////
            // Task 7 - Grade Letter Function
            ////////////////////////////////////////////////////

            Console.WriteLine("Task 7 - Grade Letter Function");

            Console.Write("Enter score: ");
            int gradeScore = int.Parse(Console.ReadLine());

            string gradeLetter = GetGradeLetter(gradeScore);

            Console.WriteLine("Grade = " + gradeLetter);

            ////////////////////////////////////////////////////
            // Task 8 - Countdown Function
            ////////////////////////////////////////////////////

            Console.WriteLine("Task 8 - Countdown Function");

            Console.Write("Enter starting number: ");
            int countdownStart = int.Parse(Console.ReadLine());

            Countdown(countdownStart);

            ////////////////////////////////////////////////////
            // Task 9 - Overloaded Multiply Function
            ////////////////////////////////////////////////////

            Console.WriteLine("Task 9 - Overloaded Multiply Function");

            int multiplyTwoIntegers = Multiply(5, 3);
            double multiplyTwoDoubles = Multiply(2.5, 4.0);
            int multiplyThreeIntegers = Multiply(2, 3, 4);

            Console.WriteLine("Two integers result = " + multiplyTwoIntegers);
            Console.WriteLine("Two doubles result = " + multiplyTwoDoubles);
            Console.WriteLine("Three integers result = " + multiplyThreeIntegers);

            ////////////////////////////////////////////////////
            // Task 10 - Overloaded Area Calculator
            ////////////////////////////////////////////////////

            Console.WriteLine("Task 10 - Overloaded Area Calculator");

            Console.Write("Choose shape (Square or Rectangle): ");
            string shapeChoice = Console.ReadLine();

            if (shapeChoice.ToLower() == "square")
            {
                Console.Write("Enter side: ");
                double squareSide = double.Parse(Console.ReadLine());

                double squareArea = CalculateArea(squareSide);

                Console.WriteLine("Square Area = " + squareArea);
            }
            else if (shapeChoice.ToLower() == "rectangle")
            {
                Console.Write("Enter length: ");
                double areaLength = double.Parse(Console.ReadLine());

                Console.Write("Enter width: ");
                double areaWidth = double.Parse(Console.ReadLine());

                double areaResult = CalculateArea(areaLength, areaWidth);

                Console.WriteLine("Rectangle Area = " + areaResult);
            }
            else
            {
                Console.WriteLine("Invalid shape.");
            }
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
            return (celsius * 9 / 5) + 32;
        }

        static void DisplayMenu()
        {
            Console.WriteLine("1) Start");
            Console.WriteLine("2) Help");
            Console.WriteLine("3) Exit");
        }

        static bool IsEven(int number)
        {
            return number % 2 == 0;
        }

        static double CalculateArea(double length, double width)
        {
            return length * width;
        }

        static double CalculatePerimeter(double length, double width)
        {
            return 2 * (length + width);
        }

        static string GetGradeLetter(int score)
        {
            if (score >= 90)
            {
                return "A";
            }
            else if (score >= 80)
            {
                return "B";
            }
            else if (score >= 70)
            {
                return "C";
            }
            else if (score >= 60)
            {
                return "D";
            }
            else
            {
                return "F";
            }
        }

        static void Countdown(int startingNumber)
        {
            for (int i = startingNumber; i >= 1; i--)
            {
                Console.WriteLine(i);
            }
        }

        static int Multiply(int number1, int number2)
        {
            return number1 * number2;
        }

        static double Multiply(double number1, double number2)
        {
            return number1 * number2;
        }

        static int Multiply(int number1, int number2, int number3)
        {
            return number1 * number2 * number3;
        }

        static double CalculateArea(double side)
        {
            return side * side;
        }
    }
}
