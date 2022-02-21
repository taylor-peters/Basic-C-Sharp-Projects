using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdCalc
{
    class Program
    {
        static void Main(string[] args)
        {

            Number number = new Number();

            Console.WriteLine("Welcome to my third 'calculator'");
            Console.WriteLine("Type in an integer");
            number.numOne = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Do you want to enter a second integer? Y/N");
            string answer = Console.ReadLine();

            if (answer.ToLower() == "y")
            {
                Console.WriteLine("Type in a second integer.");
                number.numTwo = Convert.ToInt32(Console.ReadLine());

                // Replaces option paramater with user's input
                Console.WriteLine("Sum is: " + Number.Add(number.numOne, number.numTwo) + "\n");
            }
            else
            {
                // Uses user's single input, adds five
                Console.WriteLine("Adding 5 to number...sum is: " + Number.Add(number.numOne) + "\n");
            }
            Console.ReadLine();

        }
    }
}
