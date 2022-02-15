using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boolean_Comparisons
{
    class BooleanComparisons
    {
        static void Main(string[] args)
        {
            Console.WriteLine("While Statement");
            Console.WriteLine("What is your favorite color?");
            string color = Console.ReadLine();

            // Sanitizes input, checks for match
            while (color.ToLower() != "blue")
            {
                Console.WriteLine("Incorrect, guess again?");
                color = Console.ReadLine();
            }
            Console.WriteLine("Congrats");
            Console.ReadLine();

            Console.WriteLine("Do / While Statement");
            int number;

            // Guarantees one iteration of the do loop body 
            do
            {
                Console.WriteLine("Guess a number between 1 & 10");
                number = Convert.ToInt32(Console.ReadLine());
            } while (number != 3);

            Console.WriteLine("Congrats");
            Console.ReadLine();            
        }
    }
}
