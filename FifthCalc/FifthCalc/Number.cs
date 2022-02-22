using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FifthCalc
{
    public class Number
    {
        public int numOne { get; set; }
        public int numTwo { get; set; }


        // Creates optional parameter for second integer
        public static void Divide(int numOne)
        {
            // Performs math operation on first integer - never displayed
            numOne = numOne / 2;
            Console.WriteLine(numOne);
        }
        // Instantiates output parameter
        int numberOfOperands;
        public static void Divide(int numOne, int numTwo, out int numberOfOperands)
        {
            int quotient = numOne / numTwo;
            Console.WriteLine(quotient);
            numberOfOperands = 2;
        }
    }
}
