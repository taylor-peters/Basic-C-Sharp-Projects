using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employeeOne = new Employee();

            employeeOne.firstName = "Sample";
            employeeOne.lastName = "Student";        

            // Calls modified, via the virtual tag, inherited method from abstract superclass
            employeeOne.SayName();
            Console.ReadLine();

        }
    }
}
