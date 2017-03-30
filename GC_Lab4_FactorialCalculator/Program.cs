using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GC_Lab4_FactorialCalculator
{
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

        public static long CalculateFactorial(int n)
        {
            if (n == 0)
            {
                return 1;
            }
            return n * CalculateFactorial(n - 1);
        }

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
