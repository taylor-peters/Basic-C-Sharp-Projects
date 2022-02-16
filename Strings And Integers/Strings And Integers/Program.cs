using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings_And_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<double> numerators = new List<double> { 2, 4, 5, 7, 10, 20, 235, 1250 };
                Console.WriteLine("Choose a number to divide by:");
                
                // User provides denominator
                int denominator = Convert.ToInt32(Console.ReadLine());
                foreach (int num in numerators)
                {
                    double quotient = num / denominator;
                    Console.WriteLine(quotient);
                }
            }
            // Checks for incorrect input format  
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            // Checks for 0 denominator
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            // Informs user of success
            Console.WriteLine("Program continued");
            Console.ReadLine();
        }
    }
}
