using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameSayer
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.firstName = "Taylor";
            person.lastName = "Peters";
            person.SayName();
            Console.ReadLine();

            Employee employee = new Employee();
            employee.firstName = "Sample";
            employee.lastName = "Student";
            employee.id = 12345;
            employee.SayName();
            Console.ReadLine();
        }
    }
}
