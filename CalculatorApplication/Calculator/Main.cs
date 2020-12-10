using System;
using System.Collections;
using System.Linq;

namespace CalculatorApplication.Calculator
{
    public class Main
    {
        string[] operationList = new string[4] { "+", "-", "*", "/" };

        string operation;
        int firstNum;
        int secondNum;
        int answer;
        public void RunStuff()
        {
            Console.WriteLine("What type of calculation do you want to perform? (+, -, * or /)");
            operation = Console.ReadLine();
            if (operationList.Contains(operation))
            {
                Console.WriteLine("Enter the first number:");
                while (Int32.TryParse(Console.ReadLine(), out int result) == false)
                {
                    Console.WriteLine("That isn't a number!");
                    
                }
                firstNum = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Enter the second number:");
                while (Int32.TryParse(Console.ReadLine(), out int result) == false)
                {
                    Console.WriteLine("That isn't a number!");
                    
                }
                secondNum = Int32.Parse(Console.ReadLine());

                Console.WriteLine("You've selected " + firstNum + " and " + secondNum);
                if (operation == "+")
                {
                    answer = firstNum + secondNum;
                }
                else if (operation == "-")
                {
                    answer = firstNum - secondNum;
                }
                else if (operation == "*")
                {
                    answer = firstNum * secondNum;
                }
                else if (operation == "/")
                {
                    answer = firstNum / secondNum;
                }
                Console.WriteLine();
                Console.WriteLine(firstNum + " " + operation + " " + secondNum);
                Console.WriteLine("= " + answer);
                Console.WriteLine();
                
            }
            else
            {
                RunStuff();
            }
        }
    }
}
