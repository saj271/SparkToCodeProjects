using System;
using System.Collections.Generic;

namespace Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////////////////////////////////////////////////////
            // Task 1 - Fixed Grades Array
            ////////////////////////////////////////////////////

            Console.WriteLine("Task 1 - Fixed Grades Array");

            int[] fixedGrades = new int[5];

            for (int i = 0; i < fixedGrades.Length; i++)
            {
                Console.Write("Enter grade " + (i + 1) + ": ");
                fixedGrades[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Entered Grades:");

            foreach (int grade in fixedGrades)
            {
                Console.WriteLine(grade);
            }

           
        }
    }
}
