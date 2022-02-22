using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameSayer2
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employeeOne = new Employee();
            Employee employeeTwo = new Employee();

            employeeOne.firstName = "Sample";
            employeeOne.lastName = "Student";
            employeeOne.iD = 123;
            employeeTwo.iD = 150;

            if (employeeOne == employeeTwo)
            {
                Console.WriteLine("Same dude");
            }
            else
            {
                Console.WriteLine("Different dudes");
            }

            // Calls modified, via the virtual tag, inherited method from abstract superclass
            employeeOne.SayName();
            Console.ReadLine();

            // Polymorphism
            IQuittable quitter = new Employee();
            quitter.Quit();
        }
    }
}
