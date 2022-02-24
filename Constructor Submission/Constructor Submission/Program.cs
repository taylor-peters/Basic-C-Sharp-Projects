using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_Submission
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creates two new objects, one with two parameters, one with one
            Person personOne = new Person("Taylor", "Peters");
            Person personTwo = new Person("John");
            {
                // Calls 'missing' parameter
                Console.WriteLine(personTwo.lName);
                Console.ReadLine();
            };
        }
    }
}
