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
            Console.WriteLine("Welcome to the Factorial Calculator!");
            Console.WriteLine("\nEnter an integer that's greater than 0 but less than or equal to 10: ");
            int.TryParse(Console.ReadLine(), out myInt);
            CalculateFactorial(myInt);
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
    }
}
