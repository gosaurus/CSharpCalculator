using System;

namespace Calculator
{
    class Program 
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the calculator");
            Console.WriteLine("=========================");

            Console.WriteLine("Enter your operator:");
            string Operator = Console.ReadLine()!;

            Console.WriteLine("Enter your first number: ");
            string responseOne = Console.ReadLine()!;
            int numberOne = int.Parse(responseOne);

            Console.WriteLine("Enter your second number: ");
            string responseTwo = Console.ReadLine()!;
            int numberTwo = int.Parse(responseTwo);

            int result = 0;

            /*
            if (Operator == "+") {
                result = numberOne + numberTwo;
            }
            
            else if (Operator == "-") {
                result = numberOne - numberTwo;     
            }

            else if (Operator == "*") {
                result = numberOne * numberTwo;
            }

            else if (Operator == "/") {
                result = numberOne / numberTwo;
            }
            */

            switch(Operator)
            {
                case "+":
                    result = numberOne + numberTwo;
                    break;
                case "-":
                    result = numberOne - numberTwo;
                    break;
                case "*":
                    result = numberOne * numberTwo;
                    break;
                case "/":
                    result = numberOne / numberTwo;
                    break;
            }
            
            Console.WriteLine("Your result is: " + result);
        }
    }
}