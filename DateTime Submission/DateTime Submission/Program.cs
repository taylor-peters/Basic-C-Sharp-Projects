using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTime_Submission
{
    class Program
    {
        static void Main(string[] args)
        {
            // Prints current time
            Console.WriteLine(DateTime.Now);

            // Receives user input
            Console.WriteLine("Enter a number");
            double number = Convert.ToDouble(Console.ReadLine());

            // Calculates future time based on double provided from user
            DateTime currentTime = DateTime.Now;
            DateTime futureTime = currentTime.AddHours(number);

            // Prints future time
            Console.WriteLine("In {0} hours, it will be: " + futureTime, number);
            Console.ReadLine();
        }
    }
}
