using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondCalc
{
    class Program
    {
        static void Main(string[] args)
        {            
            Number number = new Number();
            Console.WriteLine("Welcome to my second 'calculator'");

            Console.WriteLine("Type an integer");            
            Console.WriteLine(Number.Double(number.numberValue));
            Console.WriteLine("Integer Operation: Number Was Doubled\n");
            
            Console.WriteLine("Type an decimal");
            Console.WriteLine(Number.Double(number.decimalValue));
            Console.WriteLine("Decimal Operation: Number Multiplied by 5\n");        

            Console.WriteLine("Type an string");
            Console.WriteLine(Number.Double(number.stringValue));
            Console.WriteLine("String Operation: Number Squared\n");
            
            Console.ReadLine();
        }
    }
}
