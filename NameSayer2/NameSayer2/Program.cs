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
            Employee employee = new Employee();
            employee.firstName = "Sample";
            employee.lastName = "Student";

            // Calls modified, via the virtual tag, inherited method from abstract superclass
            employee.SayName();
            Console.ReadLine();

            // Polymorphism
            IQuittable quitter = new Employee();
            quitter.Quit();
        }
    }
}
