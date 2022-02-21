using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondCalc
{
    class Number
    {
        public Number()
        {
        }

        public int numberValue { get; set; }
        public decimal decimalValue { get; set; }
        public string stringValue { get; set; }

        public static int Double(int numberValue)
        {
            // Converts user input to integer
            numberValue = Convert.ToInt32(Console.ReadLine());
            numberValue = numberValue + numberValue;
            return numberValue;
        }

        public static int Double(decimal decimalValue)
        {
            // Converts user input to decimal
            decimalValue = Convert.ToDecimal(Console.ReadLine());
            decimalValue = decimalValue * 5;
            return Convert.ToInt32(decimalValue);
        }

        public static int Double(string stringValue)
        {
            // Takes user input
            stringValue = Console.ReadLine();
            try
            { 
                // Checks if calculation is possible
                int temp = Convert.ToInt32(stringValue);
                temp *= temp;
                stringValue = Convert.ToString(temp);
            } catch (FormatException)
            {
                Console.WriteLine("{0} is an incalculable input", stringValue);
                Console.ReadLine();
            }
            return Convert.ToInt32(stringValue);
        }
    }
}
