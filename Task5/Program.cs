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

            ////////////////////////////////////////////////////
            // Task 2 - Dynamic To-Do List
            ////////////////////////////////////////////////////

            Console.WriteLine("Task 2 - Dynamic To-Do List");

            List<string> todoList = new List<string>();

            for (int i = 0; i < 5; i++)
            {
                Console.Write("Enter task " + (i + 1) + ": ");
                string todoItem = Console.ReadLine();

                todoList.Add(todoItem);
            }

            Console.WriteLine("To-Do List:");

            int todoNumber = 1;

            foreach (string task in todoList)
            {
                Console.WriteLine(todoNumber + ") " + task);
                todoNumber++;
            }

            ////////////////////////////////////////////////////
            // Task 3 - Browsing History Stack
            ////////////////////////////////////////////////////

            Console.WriteLine("Task 3 - Browsing History Stack");

            Stack<string> browsingHistory = new Stack<string>();

            for (int i = 0; i < 3; i++)
            {
                Console.Write("Enter website URL " + (i + 1) + ": ");
                string websiteUrl = Console.ReadLine();

                browsingHistory.Push(websiteUrl);
            }

            string closedPage = browsingHistory.Pop();

            Console.WriteLine("Back button pressed.");
            Console.WriteLine("Page left = " + closedPage);
            Console.WriteLine("Page landed on = " + browsingHistory.Peek());

            ////////////////////////////////////////////////////
            // Task 4 - Customer Service Queue
            ////////////////////////////////////////////////////

            Console.WriteLine("Task 4 - Customer Service Queue");

            Queue<string> customerQueue = new Queue<string>();

            for (int i = 0; i < 3; i++)
            {
                Console.Write("Enter customer name " + (i + 1) + ": ");
                string customerName = Console.ReadLine();

                customerQueue.Enqueue(customerName);
            }

            string servedCustomer = customerQueue.Dequeue();

            Console.WriteLine("Customer served = " + servedCustomer);

            ////////////////////////////////////////////////////
            // Task 5 - Array Grade Range
            ////////////////////////////////////////////////////

            Console.WriteLine("Task 5 - Array Grade Range");

            int[] gradeRange = new int[5];
            int gradeTotal = 0;

            for (int i = 0; i < gradeRange.Length; i++)
            {
                Console.Write("Enter grade " + (i + 1) + ": ");
                gradeRange[i] = int.Parse(Console.ReadLine());

                gradeTotal = gradeTotal + gradeRange[i];
            }

            Array.Sort(gradeRange);

            int lowestGrade = gradeRange[0];
            int highestGrade = gradeRange[gradeRange.Length - 1];
            double gradeAverage = (double)gradeTotal / gradeRange.Length;

            Console.WriteLine("Lowest Grade = " + lowestGrade);
            Console.WriteLine("Highest Grade = " + highestGrade);
            Console.WriteLine("Average = " + gradeAverage);

            ////////////////////////////////////////////////////
            // Task 6 - Filtered Shopping List
            ////////////////////////////////////////////////////

            Console.WriteLine("Task 6 - Filtered Shopping List");

            List<string> shoppingList = new List<string>();
            bool addingShoppingItems = true;

            while (addingShoppingItems)
            {
                Console.Write("Enter shopping item or type done: ");
                string shoppingItem = Console.ReadLine();

                if (shoppingItem.ToLower() == "done")
                {
                    addingShoppingItems = false;
                }
                else
                {
                    shoppingList.Add(shoppingItem);
                }
            }

            Console.WriteLine("Shopping List Before Removal:");

            foreach (string item in shoppingList)
            {
                Console.WriteLine("- " + item);
            }

            Console.Write("Enter an item to remove: ");
            string itemToRemove = Console.ReadLine();

            bool itemRemoved = shoppingList.Remove(itemToRemove);

            if (itemRemoved)
            {
                Console.WriteLine("Item removed successfully.");
            }
            else
            {
                Console.WriteLine("Item was not found.");
            }

            Console.WriteLine("Shopping List After Removal:");

            foreach (string item in shoppingList)
            {
                Console.WriteLine("- " + item);
            }


        }
    }
}
