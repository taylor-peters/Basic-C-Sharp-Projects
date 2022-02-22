using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParsingEnums
{
    class Program
    {
        static void Main(string[] args)
        {
            // Takes user input
            Console.WriteLine("Enter a day of the week: ");
            string input = Console.ReadLine();

            // Sanitizes input
            string value = input.ToLower();
            try
            {
                //  Compares input value against available enums.
                DaysOfTheWeek day = (DaysOfTheWeek)Enum.Parse(typeof(DaysOfTheWeek), value);
                Console.WriteLine("You seleceted " + day);
                Console.ReadLine();
            }
            catch (Exception)
            {
                Console.WriteLine("Please enter an actual day of the week.");
                Console.ReadLine();
            }

        }
        public enum DaysOfTheWeek
            {
                sunday,
                monday,
                tuesday,
                wednesday,
                thursday,
                friday,
                saturday
            }
    }
    
}
