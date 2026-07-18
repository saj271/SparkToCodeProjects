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

            Console.WriteLine(
                "Two integers result = " + multiplyTwoIntegers);

            Console.WriteLine(
                "Two doubles result = " + multiplyTwoDoubles);

            Console.WriteLine(
                "Three integers result = " + multiplyThreeIntegers);

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

                double areaResult =
                    CalculateArea(areaLength, areaWidth);

                Console.WriteLine("Rectangle Area = " + areaResult);
            }
            else
            {
                Console.WriteLine("Invalid shape.");
            }

            ////////////////////////////////////////////////////
            // Task 11 - Function-Based Calculator
            ////////////////////////////////////////////////////

            Console.WriteLine("Task 11 - Function-Based Calculator");

            bool calculatorRunning = true;

            while (calculatorRunning)
            {
                Console.WriteLine("1) Add");
                Console.WriteLine("2) Subtract");
                Console.WriteLine("3) Multiply");
                Console.WriteLine("4) Divide");
                Console.WriteLine("5) Exit");

                Console.Write("Choose an operation: ");
                int operationChoice =
                    int.Parse(Console.ReadLine());

                if (operationChoice == 5)
                {
                    calculatorRunning = false;
                }
                else if (operationChoice >= 1 &&
                         operationChoice <= 4)
                {
                    Console.Write("Enter the first number: ");
                    double calculatorNumber1 =
                        double.Parse(Console.ReadLine());

                    Console.Write("Enter the second number: ");
                    double calculatorNumber2 =
                        double.Parse(Console.ReadLine());

                    double calculatorResult = 0;
                    string operationName = "";

                    switch (operationChoice)
                    {
                        case 1:
                            operationName = "Addition";
                            calculatorResult =
                                Add(calculatorNumber1,
                                    calculatorNumber2);
                            break;

                        case 2:
                            operationName = "Subtraction";
                            calculatorResult =
                                Subtract(calculatorNumber1,
                                         calculatorNumber2);
                            break;

                        case 3:
                            operationName = "Multiplication";
                            calculatorResult =
                                MultiplyNumbers(calculatorNumber1,
                                                calculatorNumber2);
                            break;

                        case 4:
                            operationName = "Division";
                            calculatorResult =
                                DivideNumbers(calculatorNumber1,
                                              calculatorNumber2);
                            break;
                    }

                    DisplayResult(operationName, calculatorResult);
                }
                else
                {
                    Console.WriteLine("Invalid choice.");
                }
            }

            ////////////////////////////////////////////////////
            // Task 12 - Student Report Card Generator
            ////////////////////////////////////////////////////

            Console.WriteLine("Task 12 - Student Report Card Generator");

            Console.Write("Enter student name: ");
            string studentName = Console.ReadLine();

            Console.Write("Enter first subject score: ");
            double firstSubjectScore =
                double.Parse(Console.ReadLine());

            Console.Write("Enter second subject score: ");
            double secondSubjectScore =
                double.Parse(Console.ReadLine());

            Console.Write("Enter third subject score: ");
            double thirdSubjectScore =
                double.Parse(Console.ReadLine());

            double studentAverage =
                CalculateAverage(firstSubjectScore,
                                 secondSubjectScore,
                                 thirdSubjectScore);

            string studentGrade =
                GetGradeLetter(studentAverage);

            PrintReportCard(studentName,
                            studentAverage,
                            studentGrade);
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

        static int Multiply(int number1,
                            int number2,
                            int number3)
        {
            return number1 * number2 * number3;
        }

        static double CalculateArea(double side)
        {
            return side * side;
        }

        static double Add(double number1, double number2)
        {
            return number1 + number2;
        }

        static double Subtract(double number1, double number2)
        {
            return number1 - number2;
        }

        static double MultiplyNumbers(double number1,
                                      double number2)
        {
            return number1 * number2;
        }

        static double DivideNumbers(double number1,
                                    double number2)
        {
            try
            {
                if (number2 == 0)
                {
                    throw new DivideByZeroException();
                }

                return number1 / number2;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine(
                    "Cannot divide by zero.");

                return 0;
            }
        }

        static void DisplayResult(string operationName,
                                  double result)
        {
            Console.WriteLine(
                operationName + " Result = " + result);
        }

        static double CalculateAverage(double score1,
                                       double score2,
                                       double score3)
        {
            return (score1 + score2 + score3) / 3;
        }

        static string GetGradeLetter(double average)
        {
            if (average >= 90)
            {
                return "A";
            }
            else if (average >= 80)
            {
                return "B";
            }
            else if (average >= 70)
            {
                return "C";
            }
            else if (average >= 60)
            {
                return "D";
            }
            else
            {
                return "F";
            }
        }

        static void PrintReportCard(string studentName,
                                    double average,
                                    string grade)
        {
            Console.WriteLine("========== REPORT CARD ==========");
            Console.WriteLine("Student Name = " + studentName);
            Console.WriteLine("Average = " + average);
            Console.WriteLine("Grade = " + grade);
            Console.WriteLine("=================================");
        }
    }
}
