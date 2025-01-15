using System;

namespace Calculator
{
    class Program 
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the calculator");
            Console.WriteLine("=========================");

            Console.WriteLine("Enter your first number: ");
            string responseOne = Console.ReadLine()!;
            int numberOne = int.Parse(responseOne);

            Console.WriteLine("Enter your second number: ");
            string responseTwo = Console.ReadLine()!;
            int numberTwo = int.Parse(responseTwo);

            int result = numberOne * numberTwo;
            Console.WriteLine("Your result is: " + result);
        }
    }
}