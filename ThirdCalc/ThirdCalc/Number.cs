using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdCalc
{
    class Number
    {
        public Number()
        {
        }

        public int numOne { get; set; }
        public int numTwo { get; set; }

        // Creates optional parameter for second integer
        public static int Add(int numOne, int numTwo = 5)
        {
            int sum = numOne + numTwo;
            return sum;
        }
            

    }
}
