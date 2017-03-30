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
            while (run)
            {
                Console.WriteLine("Welcome to the Factorial Calculator!");
                Console.WriteLine("\nEnter an integer that's greater than 0 but less than or equal to 10: ");
                int.TryParse(Console.ReadLine(), out myInt);
                CalculateFactorial(myInt);
                run = Continue();
            }
            Console.ReadLine();
        }

        public static void CalculateFactorial(int num)
        {
            long factorial = 1;
            for (int i = 1; i <= num; i++)
            {
                factorial = i * factorial;
            }
            Console.WriteLine("\nThe factorial of " + num + " is " + factorial + " .");
        }

        public static Boolean Continue()
        {
            Console.WriteLine("Continue? (Y/N): ");
            string input = Console.ReadLine();
            Boolean run = true;
            input = input.ToLower();
            if (input == "n")
            {
                Console.WriteLine("Goodbye!");
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
