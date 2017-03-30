using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Pete Rossman
//Grand Circus .NET Bootcamp Lab 4
//March 30, 2017

namespace GC_Lab4_FactorialCalculator
{
    //This program takes an integer and calculates the factorial of that integer.
    class Program
    {
        static void Main(string[] args)
        {
            int myInt;
            bool run = true;
            Console.WriteLine("Welcome to the Factorial Calculator!");
            while (run)
            {     
                Console.Write("\nEnter an integer that's greater than 0 but less than or equal to 20: ");
                int.TryParse(Console.ReadLine(), out myInt);
                long factorial = CalculateFactorial(myInt);
                Console.WriteLine("\nThe factorial of " + myInt + " is " + factorial + ".");
                run = Continue();
            }
            Console.ReadLine();
        }

        //This method calculates the factorial of an integer recursively.
        //1 is subtracted from the integer until n = 0, and at that point
        //the full factorial calculation is returned.

        public static long CalculateFactorial(int n)
        {
            if (n == 0)
            {
                return 1;
            }
            return n * CalculateFactorial(n - 1);
        }

        //The Continue method lets the user run the calculator again if desired.
        public static Boolean Continue()
        {
            Console.Write("\nContinue? (Y/N): ");
            string input = Console.ReadLine();
            Boolean run = true;
            input = input.ToLower();
            if (input == "n")
            {
                Console.WriteLine("\nGoodbye!");
                run = false;
            }
            else if (input == "y")
            {
                run = true;
            }
            else
            {
              Console.WriteLine("I'm sorry, I didn't understand your input. Let's try that again!");
              run = Continue();
            }

            return run;
        }
    }
}
