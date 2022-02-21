using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourthCalc
{
    class Number
    {

        public int numOne { get; set; }
        public int numTwo { get; set; }

        // Creates optional parameter for second integer
        public static void Add(int numOne, int numTwo)
        {
            // Performs math operation on first integer - never displayed
            int doubleOne = numOne + numOne;
            Console.WriteLine("Writing the second integer");
            Console.WriteLine(numTwo);
        }
    }
}
