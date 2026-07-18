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
        }

        static void PrintWelcome(string name)
        {
            Console.WriteLine("Welcome, " + name + "!");
            Console.WriteLine("We are happy to see you.");

            ////////////////////////////////////////////////////
            // Task 2 - Square Number Function
            ////////////////////////////////////////////////////

            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());

            int result = Square(number);

            Console.WriteLine("Square = " + result);
        }

        static int Square(int number)
        {
            return number * number;
        }
    }
}