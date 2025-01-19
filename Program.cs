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

            Console.WriteLine($"How many times do you want to {Operator}?");
            string input = Console.ReadLine()!;
            int intInput = int.Parse(input);

            int[] myArray = new int[intInput];

            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine($"Enter your number {i + 1}: ");
                int intResponse = int.Parse(Console.Readline())!;
                myArray[i] = intResponse;
            }

            int result = myArray[0];

            //display myArray
            Console.Write("[{0}] \n", String.Join(", ", myArray));

            //Solution using i
            for (int i = 1; i < myArray.Length; i++)
            {
                 if (Operator == "+")
                 {
                    result += myArray[i];
                 }
                 else if (Operator == "-")
                 {
                    result -= myArray[i];
                 }
                 else if (Operator == "*")
                 {
                    result *= myArray[i];
                 }
                 else if (Operator == "/")
                 {
                    result /= myArray[i];
                 }
            }

            //Solution using foreach
            /*    
            foreach (int element in myArray)
            {
                Console.WriteLine($"Element = {element}");
                if (Operator == "+") {
                    result += element;
                }
                
                else if (Operator == "-") {
                    result -= element;     
                }

                else if (Operator == "*") {
                    if (result > 0)
                    {
                        result *= element;
                    }
                    else
                    {
                        result = element;
                    }
                }

                else if (Operator == "/") {
                    if (result > 0)
                    {
                        result /= element;
                    }
                    else
                    {
                        result = element;
                    }
                }
            
            }
            */ 

            /* 
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
            */            

            Console.WriteLine("Your result is: " + result);
        }
    }
}
