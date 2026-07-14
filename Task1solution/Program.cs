using System;

namespace CSharpFundamentalsPart1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////////////////////////////////////////////////////
            // Task 1 - Personal Info Card
            ////////////////////////////////////////////////////
            string personName = "Saja";
            int personAge = 22;
            double personHeight = 1.65;
            bool isStudent = true;

            Console.WriteLine("Task 1 - Personal Info Card");
            Console.WriteLine("Name: " + personName);
            Console.WriteLine("Age: " + personAge);
            Console.WriteLine("Height: " + personHeight);
            Console.WriteLine("Student: " + isStudent);
            Console.WriteLine("\n--------------------------------\n");

            ////////////////////////////////////////////////////
            // Task 2 - Rectangle Calculator
            ////////////////////////////////////////////////////
            Console.WriteLine("Task 2 - Rectangle Calculator");
            Console.Write("Enter rectangle length: ");
            double rectangleLength = double.Parse(Console.ReadLine() ?? "0");
            Console.Write("Enter rectangle width: ");
            double rectangleWidth = double.Parse(Console.ReadLine() ?? "0");
            double rectangleArea = rectangleLength * rectangleWidth;
            double rectanglePerimeter = 2 * (rectangleLength + rectangleWidth);
            Console.WriteLine("Area: " + rectangleArea);
            Console.WriteLine("Perimeter: " + rectanglePerimeter);
            Console.WriteLine("\n--------------------------------\n");

            ////////////////////////////////////////////////////
            // Task 3 - Even or Odd Checker
            ////////////////////////////////////////////////////
            Console.WriteLine("Task 3 - Even or Odd Checker");
            Console.Write("Enter a whole number: ");
            int evenOddNumber = int.Parse(Console.ReadLine() ?? "0");
            if (evenOddNumber % 2 == 0)
            {
                Console.WriteLine("The number is even.");
            }
            else
            {
                Console.WriteLine("The number is odd.");
            }
            Console.WriteLine("\n--------------------------------\n");

            ////////////////////////////////////////////////////
            // Task 4 - Voting Eligibility
            ////////////////////////////////////////////////////
            Console.WriteLine("Task 4 - Voting Eligibility");
            Console.Write("Enter your age: ");
            int voterAge = int.Parse(Console.ReadLine() ?? "0");
            Console.Write("Do you have a valid national ID? (yes/no): ");
            string idAnswer = Console.ReadLine() ?? "";
            bool hasValidId = idAnswer == "yes";
            if (voterAge >= 18 && hasValidId)
            {
                Console.WriteLine("Eligible to vote.");
            }
            else
            {
                Console.WriteLine("Not eligible to vote.");
            }
            Console.WriteLine("\n--------------------------------\n");

            ////////////////////////////////////////////////////
            // Task 5 - Grade Letter Lookup
            ////////////////////////////////////////////////////
            Console.WriteLine("Task 5 - Grade Letter Lookup");
            Console.Write("Enter grade letter (A, B, C, D, or F): ");
            char gradeLetter = char.Parse(Console.ReadLine() ?? " ");
            switch (gradeLetter)
            {
                case 'A': Console.WriteLine("Excellent"); break;
                case 'B': Console.WriteLine("Very Good"); break;
                case 'C': Console.WriteLine("Good"); break;
                case 'D': Console.WriteLine("Pass"); break;
                case 'F': Console.WriteLine("Fail"); break;
                default: Console.WriteLine("Invalid grade"); break;
            }
            Console.WriteLine("\n--------------------------------\n");

            ////////////////////////////////////////////////////
            // Task 6 - Temperature Converter
            ////////////////////////////////////////////////////
            Console.WriteLine("Task 6 - Temperature Converter");
            Console.Write("Enter temperature in Celsius: ");
            double celsius = double.Parse(Console.ReadLine() ?? "0");
            double fahrenheit = (celsius * 9 / 5) + 32;
            Console.WriteLine("Temperature in Fahrenheit: " + fahrenheit);
            if (celsius < 10)
            {
                Console.WriteLine("Weather: Cold");
            }
            else if (celsius <= 30)
            {
                Console.WriteLine("Weather: Mild");
            }
            else
            {
                Console.WriteLine("Weather: Hot");
            }
            Console.WriteLine("\n--------------------------------\n");

            ////////////////////////////////////////////////////
            // Task 7 - Movie Ticket Pricing
            ////////////////////////////////////////////////////
            Console.WriteLine("Task 7 - Movie Ticket Pricing");
            Console.Write("Enter your age: ");
            int customerAge = int.Parse(Console.ReadLine() ?? "0");
            if (customerAge >= 0 && customerAge <= 12)
            {
                Console.WriteLine("Category: Child");
                Console.WriteLine("Ticket Price: 2.000 OMR");
            }
            else if (customerAge >= 13 && customerAge <= 59)
            {
                Console.WriteLine("Category: Adult");
                Console.WriteLine("Ticket Price: 5.000 OMR");
            }
            else if (customerAge >= 60)
            {
                Console.WriteLine("Category: Senior");
                Console.WriteLine("Ticket Price: 3.000 OMR");
            }
            else
            {
                Console.WriteLine("Invalid age.");
            }
            Console.WriteLine("\n--------------------------------\n");

            ////////////////////////////////////////////////////
            // Task 8 - Restaurant Bill with Membership Discount
            ////////////////////////////////////////////////////
            Console.WriteLine("Task 8 - Restaurant Bill with Membership Discount");
            Console.Write("Enter total bill amount: ");
            double originalBill = double.Parse(Console.ReadLine() ?? "0");
            Console.Write("Are you a loyalty member? (yes/no): ");
            string memberAnswer = Console.ReadLine() ?? "";
            bool isMember = memberAnswer == "yes";
            double discountAmount = 0;
            if (originalBill > 20 && isMember)
            {
                discountAmount = originalBill * 0.15;
            }
            double finalBill = originalBill - discountAmount;
            Console.WriteLine("Original Bill: " + originalBill + " OMR");
            Console.WriteLine("Discount Amount: " + discountAmount + " OMR");
            Console.WriteLine("Final Amount: " + finalBill + " OMR");
            Console.WriteLine("\n--------------------------------\n");

            ////////////////////////////////////////////////////
            // Task 9 - Day Name Finder
            ////////////////////////////////////////////////////
            Console.WriteLine("Task 9 - Day Name Finder");
            Console.Write("Enter a day number from 1 to 7: ");
            int dayNumber = int.Parse(Console.ReadLine() ?? "0");
            switch (dayNumber)
            {
                case 1: Console.WriteLine("Sunday"); break;
                case 2: Console.WriteLine("Monday"); break;
                case 3: Console.WriteLine("Tuesday"); break;
                case 4: Console.WriteLine("Wednesday"); break;
                case 5: Console.WriteLine("Thursday"); break;
                case 6: Console.WriteLine("Friday"); break;
                case 7: Console.WriteLine("Saturday"); break;
                default: Console.WriteLine("Invalid day number"); break;
            }
            Console.WriteLine("\n--------------------------------\n");

            ////////////////////////////////////////////////////
            // Task 10 - Mini Calculator
            ////////////////////////////////////////////////////
            Console.WriteLine("Task 10 - Mini Calculator");
            Console.Write("Enter the first number: ");
            double firstNumber = double.Parse(Console.ReadLine() ?? "0");
            Console.Write("Enter the second number: ");
            double secondNumber = double.Parse(Console.ReadLine() ?? "0");
            Console.Write("Enter an operator (+, -, *, /, or %): ");
            char calculatorOperator = char.Parse(Console.ReadLine() ?? " ");
            switch (calculatorOperator)
            {
                case '+': Console.WriteLine("Result: " + (firstNumber + secondNumber)); break;
                case '-': Console.WriteLine("Result: " + (firstNumber - secondNumber)); break;
                case '*': Console.WriteLine("Result: " + (firstNumber * secondNumber)); break;
                case '/':
                    if (secondNumber != 0) Console.WriteLine("Result: " + (firstNumber / secondNumber));
                    else Console.WriteLine("Cannot divide by zero");
                    break;
                case '%':
                    if (secondNumber != 0) Console.WriteLine("Result: " + (firstNumber % secondNumber));
                    else Console.WriteLine("Cannot divide by zero");
                    break;
                default: Console.WriteLine("Invalid operator"); break;
            }
            Console.WriteLine("\n--------------------------------\n");

            ////////////////////////////////////////////////////
            // Task 11 - Loan Eligibility System
            ////////////////////////////////////////////////////
            Console.WriteLine("Task 11 - Loan Eligibility System");
            Console.Write("Enter your age: ");
            int applicantAge = int.Parse(Console.ReadLine() ?? "0");
            Console.Write("Enter your monthly income: ");
            double monthlyIncome = double.Parse(Console.ReadLine() ?? "0");
            Console.Write("Do you have an existing loan? (yes/no): ");
            string existingLoanAnswer = Console.ReadLine() ?? "";
            bool hasExistingLoan = existingLoanAnswer == "yes";
            if (applicantAge >= 21 && applicantAge <= 60 && monthlyIncome >= 400 && !hasExistingLoan)
            {
                Console.WriteLine("Eligible for the loan.");
            }
            else
            {
                Console.WriteLine("Not eligible for the loan.");
                if (applicantAge < 21 || applicantAge > 60)
                    Console.WriteLine("Reason: Age is outside the allowed range.");
                else if (monthlyIncome < 400)
                    Console.WriteLine("Reason: Monthly income is too low.");
                else
                    Console.WriteLine("Reason: Applicant has an existing loan.");
            }
            Console.WriteLine("\n--------------------------------\n");

            ////////////////////////////////////////////////////
            // Task 12 - Shipping Cost Calculator
            ////////////////////////////////////////////////////
            Console.WriteLine("Task 12 - Shipping Cost Calculator");
            Console.Write("Enter region code (A, B, or C): ");
            char regionCode = char.Parse(Console.ReadLine() ?? " ");
            Console.Write("Enter package weight in kg: ");
            double packageWeight = double.Parse(Console.ReadLine() ?? "0");
            double baseCost = 0;
            double extraCharge = 0;
            bool validRegion = true;
            switch (regionCode)
            {
                case 'A': baseCost = 1.000; break;
                case 'B': baseCost = 3.000; break;
                case 'C': baseCost = 7.000; break;
                default:
                    Console.WriteLine("Invalid region");
                    validRegion = false;
                    break;
            }
            if (validRegion)
            {
                if (packageWeight > 10) extraCharge = 5.000;
                else if (packageWeight > 5) extraCharge = 2.000;
                else extraCharge = 0;
                double totalShippingCost = baseCost + extraCharge;
                Console.WriteLine("Base Cost: " + baseCost + " OMR");
                Console.WriteLine("Extra Charge: " + extraCharge + " OMR");
                Console.WriteLine("Total Shipping Cost: " + totalShippingCost + " OMR");
            }
            Console.WriteLine("\n--------------------------------\n");

            ////////////////////////////////////////////////////
            // Task 13 - Triangle Type Classifier
            ////////////////////////////////////////////////////
            Console.WriteLine("Task 13 - Triangle Type Classifier");
            Console.Write("Enter the first side: ");
            double side1 = double.Parse(Console.ReadLine() ?? "0");
            Console.Write("Enter the second side: ");
            double side2 = double.Parse(Console.ReadLine() ?? "0");
            Console.Write("Enter the third side: ");
            double side3 = double.Parse(Console.ReadLine() ?? "0");
            bool validTriangle = side1 + side2 > side3 && side1 + side3 > side2 && side2 + side3 > side1;
            if (!validTriangle)
            {
                Console.WriteLine("The sides do not form a valid triangle.");
            }
            else if (side1 == side2 && side2 == side3)
            {
                Console.WriteLine("Triangle Type: Equilateral");
            }
            else if (side1 == side2 || side1 == side3 || side2 == side3)
            {
                Console.WriteLine("Triangle Type: Isosceles");
            }
            else
            {
                Console.WriteLine("Triangle Type: Scalene");
            }
            Console.WriteLine("\n--------------------------------\n");

            ////////////////////////////////////////////////////
            // Task 14 - Online Store Checkout
            ////////////////////////////////////////////////////
            Console.WriteLine("Task 14 - Online Store Checkout");
            Console.Write("Enter product code (1, 2, or 3): ");
            int productCode = int.Parse(Console.ReadLine() ?? "0");
            Console.Write("Enter quantity: ");
            int quantity = int.Parse(Console.ReadLine() ?? "0");
            Console.Write("Do you have a discount coupon? (yes/no): ");
            string couponAnswer = Console.ReadLine() ?? "";
            bool hasCoupon = couponAnswer == "yes";
            double unitPrice = 0;
            bool validProduct = true;
            switch (productCode)
            {
                case 1: unitPrice = 8.500; break;
                case 2: unitPrice = 12.000; break;
                case 3: unitPrice = 5.000; break;
                default:
                    Console.WriteLine("Invalid product code");
                    validProduct = false;
                    break;
            }
            if (validProduct)
            {
                double subtotal = unitPrice * quantity;
                double storeDiscount = 0;
                if (hasCoupon && subtotal > 20) storeDiscount = subtotal * 0.10;
                double amountAfterDiscount = subtotal - storeDiscount;
                double taxAmount = amountAfterDiscount * 0.05;
                double finalTotal = amountAfterDiscount + taxAmount;
                Console.WriteLine("Subtotal: " + subtotal + " OMR");
                Console.WriteLine("Discount Amount: " + storeDiscount + " OMR");
                Console.WriteLine("Tax Amount: " + taxAmount + " OMR");
                Console.WriteLine("Final Total: " + finalTotal + " OMR");
            }
            Console.WriteLine("\n--------------------------------\n");

            ////////////////////////////////////////////////////
            // Task 15 - University Admission Decision
            ////////////////////////////////////////////////////
            Console.WriteLine("Task 15 - University Admission Decision");
            Console.Write("Enter program type (S for Science, A for Arts): ");
            char programType = char.Parse(Console.ReadLine() ?? " ");
            Console.Write("Enter GPA: ");
            double applicantGpa = double.Parse(Console.ReadLine() ?? "0");
            Console.Write("Enter entrance exam score: ");
            int examScore = int.Parse(Console.ReadLine() ?? "0");
            Console.Write("Do you have an extracurricular achievement? (yes/no): ");
            string achievementAnswer = Console.ReadLine() ?? "";
            bool hasAchievement = achievementAnswer == "yes";
            switch (programType)
            {
                case 'S':
                    if (applicantGpa >= 3.0 && examScore >= 75)
                    {
                        Console.WriteLine("Program: Science");
                        Console.WriteLine("Result: Admitted");
                    }
                    else if (hasAchievement)
                    {
                        Console.WriteLine("Program: Science");
                        Console.WriteLine("Result: Conditionally Admitted");
                    }
                    else
                    {
                        Console.WriteLine("Program: Science");
                        Console.WriteLine("Result: Not Admitted");
                    }
                    break;
                case 'A':
                    if (applicantGpa >= 2.5 && examScore >= 60)
                    {
                        Console.WriteLine("Program: Arts");
                        Console.WriteLine("Result: Admitted");
                    }
                    else if (hasAchievement)
                    {
                        Console.WriteLine("Program: Arts");
                        Console.WriteLine("Result: Conditionally Admitted");
                    }
                    else
                    {
                        Console.WriteLine("Program: Arts");
                        Console.WriteLine("Result: Not Admitted");
                    }
                    break;
                default:
                    Console.WriteLine("Invalid program type");
                    break;
            }

            Console.WriteLine("\nAll tasks completed.");
        }
    }
}