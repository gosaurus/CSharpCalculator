using System;

namespace Calculator
{ class Program 
    {
        static void Main(string[] args)
        {
            bool ContinueCalculator;
            do
            {
                PrintWelcomeMessage();
                string Operator = GetOperator();
                
                int NumberArrayLength = CalculationTimes(Operator);

                int[] myNumberArray = CreateNumberArray(NumberArrayLength);

                int result = myNumberArray[0];

                //display myNumberArray
                Console.Write("[{0}] \n", String.Join(", ", myNumberArray));

                result = PerformCalculations(result, myNumberArray, Operator);

                Console.WriteLine("Your result is: " + result);
                
                ContinueCalculator = Continue();
            }
            while (ContinueCalculator);
        }
    
        private static bool Continue()
        {
            Console.WriteLine("Do you want to continue? Y/n");
            string response = Console.ReadLine().Trim();
            if (response == "n" || response == "N")
            {
                return false;
            }
            return true;
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
            if ((Operator == "+") || (Operator == "-") || (Operator == "*") || (Operator == "/"))
            { 
                return Operator;
            } 
            Console.WriteLine("Invalid input.");
            return GetOperator();
        }        
        
        private static int CalculationTimes(string Operator)
        {
            Console.WriteLine($"How many times do you want to {Operator}?");
            int parsedIntegerResponse = StringInputNumber();
            return parsedIntegerResponse;
        }
       
        private static int[] CreateNumberArray(int NumberArrayLength) 
        {
            int[] myNumberArray = new int[NumberArrayLength];
            for (int i = 0; i < myNumberArray.Length; i++)
            {
                Console.WriteLine($"Enter number {i + 1}: ");
                int parsedIntegerResponse = StringInputNumber();
                myNumberArray[i] = parsedIntegerResponse;
            }

            return myNumberArray;
        }
        
        private static int StringInputNumber()
        {
            if (int.TryParse(Console.ReadLine(), out int parsedIntegerResponse) &&
                parsedIntegerResponse > 0)
            {
                return parsedIntegerResponse;
            }
            Console.WriteLine("Invalid input. Please enter a valid number greater than 0.");
            return StringInputNumber();
        }

        private static int PerformCalculations (int result, int[] myNumberArray, string Operator)
        {
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
            return result;
        }
    }
}
