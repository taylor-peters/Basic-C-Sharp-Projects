using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to my 'calculator'");
            Console.WriteLine("Pick a number");
            Number number = new Number();

            Console.WriteLine("Doubling the number");
            Console.WriteLine(Number.Double(number.numberValue));

            Console.WriteLine("Squaring the number");
            Console.WriteLine(Number.Square(number.numberValue));

            Console.WriteLine("Cubing the number");
            Console.WriteLine(Number.Cube(number.numberValue));



            //if (operation.ToLower() == "double")
            //{
            //    number.numberValue = Number.Double(number.numberValue);
            //}
            //else if (operation.ToLower() == "square")
            //{
            //    number.numberValue = Number.Square(number.numberValue);
            //}
            //else if (operation.ToLower() == "cube")
            //{
            //    number.numberValue = Number.Cube(number.numberValue);
            //}
            //else
            //{
            //    Console.WriteLine("Incorrect request, please try again");
            //    Console.ReadLine();
            //}
            //Console.WriteLine("Your answer is: " + number.numberValue);
            Console.ReadLine();

        }
    }
}
