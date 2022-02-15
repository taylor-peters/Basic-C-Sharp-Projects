using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Insurance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to my car insurance approval app");

            // Takes user input and converts it to an int
            Console.WriteLine("What is your age");
            int age = Convert.ToInt32(Console.ReadLine());

            // Takes user input and converts it to a bool
            Console.WriteLine("Have you ever had a DUI? Write true or false.");
            string drunk = Console.ReadLine();
            bool dui = false;
            if (drunk == "true")
                dui = true;

            // Takes user input and converts it to an int
            Console.WriteLine("How many speeding tickets do you have?");
            int tickets = Convert.ToInt32(Console.ReadLine());

            bool approved = false;

            // Qualifies users must be older than 15, have no DUI's, and have no more than 3 tickets
            if ((age > 15) && (dui == false) && (tickets <= 3))
            {
                approved = true;
            }
                 

            Console.WriteLine("Qualified?");
            Console.WriteLine(approved);

            Console.ReadLine();

        }
    }
}
