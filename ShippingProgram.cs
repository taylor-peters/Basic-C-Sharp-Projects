using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shipping_Quote_App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below");
            Console.WriteLine("What is the weight of your package?");
            double weight = Convert.ToDouble(Console.ReadLine());

            // Checks for weight restriction, prints message and exits program
            if (weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day");
                Console.ReadLine();
            }
            else
            {
                // Takes in user input for dimensions
                Console.WriteLine("What is the height of your package?");
                double height = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("What is the width of your package?");
                double width = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("What is the length of your package?");
                double length = Convert.ToDouble(Console.ReadLine());

                // Checks for dimension restriction, prints message and exits program
                if ((height + width + length) > 50)
                {
                    Console.WriteLine("Package too big to be shipped via Package Express.");
                    Console.ReadLine();
                }
                else
                {
                    // Calculates raw cost, then rounds to price
                    double cost = (((height * width * length)* weight)/ 100);
                    double price = (Math.Round(cost, 2));
                    Console.WriteLine("Your estimated total for shipping this package is: $" + price);
                    Console.ReadLine();
                }
            }



        }
    }
}
