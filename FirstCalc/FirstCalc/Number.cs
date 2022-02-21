using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstCalc
{
    public class Number
    {
        public Number()
        {
            numberValue = Convert.ToInt32(Console.ReadLine());
        }
        public int numberValue { get; set; }

        public static int Double(int numberValue)
        {
            numberValue = numberValue * 2;
            return numberValue;
        }

        public static int Square(int numberValue)
        {
            numberValue *= numberValue;
            return numberValue;
        }

        public static int Cube(int numberValue)
        {
            numberValue = (numberValue * numberValue * numberValue);
            return numberValue;
        }

    }
}
