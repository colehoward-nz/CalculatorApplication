using System;

namespace CalculatorApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Calculator.Main mainMethod = new Calculator.Main();
            
            bool continueProgram = true;

            while (continueProgram == true)
            {
                mainMethod.RunStuff();

                Console.WriteLine("Would you like to make another calculation?");
                Console.WriteLine("   Enter either: true or false");
                continueProgram = bool.Parse(Console.ReadLine());
            }
            Console.WriteLine();
            Console.WriteLine("Thank you for using the program!");
            Console.WriteLine();
        }
    }
}
