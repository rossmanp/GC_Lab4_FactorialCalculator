using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GC_Lab4_FactorialCalculator
{
    class IntValidator
    {
        static int _myInt;

        public IntValidator()
        {

        }

        //This method confirms that the user entered an integer, and returns the integer.

        public static int getInt(string prompt)
        {

            int.TryParse(prompt, out _myInt);
            while (!int.TryParse(prompt, out _myInt))
            {
                Console.Write("The value must be an integer, try again: ");
                prompt = Console.ReadLine();
            }
            return _myInt;
        }

        //For the user to proceed, he or she must enter an integer within the specified range.

        public static int getIntWithinRange(string prompt, int min, int max)
        {
            bool run = true;
            IntValidator num = new IntValidator();
            while (run)
            {
                Console.WriteLine("Enter an integer between 0 and 20: ");
                _myInt = IntValidator.getInt(Console.ReadLine());
                if (_myInt < min)
                {
                    Console.WriteLine("Error! Number must be greater than " + (min - 1));
                }
                else if (_myInt > max)
                {
                    Console.WriteLine("Error! Number must be less than " + (max + 1));
                }
                else
                {
                    run = false;
                }
            }
            return _myInt;
        }
    }
}
