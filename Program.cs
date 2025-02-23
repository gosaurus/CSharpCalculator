using System;

namespace Calculator
{
    class Program 
    {
        static void Main(string[] args)
        {
            PrintWelcomeMessage();
            string Operator = GetOperator();
            
            int NumberArrayLength = CalculationTimes(Operator);

            int[] myNumberArray = CreateNumberArray(NumberArrayLength);

            int result = myNumberArray[0];

            //display myNumberArray
            Console.Write("[{0}] \n", String.Join(", ", myNumberArray));

            //Solution using i
            for (int i = 1; i < myNumberArray.Length; i++)
            {
                 if (Operator == "+")
                 {
                    result += myNumberArray[i];
                 }
                 else if (Operator == "-")
                 {
                    result -= myNumberArray[i];
                 }
                 else if (Operator == "*")
                 {
                    result *= myNumberArray[i];
                 }
                 else if (Operator == "/")
                 {
                    result /= myNumberArray[i];
                 }
            }

            //Solution using foreach
            /*    
            foreach (int element in myNumberArray)
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
        
        private static void PrintWelcomeMessage()
        {
            Console.WriteLine("Welcome to the calculator");
            Console.WriteLine("=========================");
        }

        private static string GetOperator()
        {
            Console.WriteLine("Enter your operator:");
            string Operator = Console.ReadLine()!;
            return Operator;
        }        
        
        private static int CalculationTimes(string Operator)
        {
            Console.WriteLine($"How many times do you want to {Operator}?");
            string input = Console.ReadLine()!;
            int intInput = int.Parse(input);
            return intInput;
        }
       
        private static int[] CreateNumberArray(int NumberArrayLength) 
        {
            int[] myNumberArray = new int[NumberArrayLength];
            for (int i = 0; i < myNumberArray.Length; i++)
            {
                Console.WriteLine($"Enter your number {i + 1}: ");
                int intResponse = int.Parse(Console.ReadLine())!;
                myNumberArray[i] = intResponse;
            }

            return myNumberArray;
        }
    }
}
