using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FifthCalc
{
    public static class StaticNumber
    {
        static int denominator;
        static StaticNumber()
        {
            denominator = 2;
        }        
        public static void Divide(int numOne)
        {
            // Passes user integer, performs calculation with static integer from class
            numOne = numOne / denominator;
            Console.WriteLine(numOne);
        }
        public static void Divide(int numOne, int numTwo)
        {
            int quotient = numOne / numTwo;
            Console.WriteLine(quotient);
        }

    }


}
