using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employeeList = new List<Employee>();

            Employee employeeOne = new Employee("Taylor", "Peters", 1);
            Employee employeeTwo = new Employee("Tyler", "Peters", 10);
            Employee employeeThree = new Employee("Trevor", "Peters", 2);
            Employee employeeFour = new Employee("Travis", "Peters", 3);
            Employee employeeFive = new Employee("Tractor", "Peters", 4);
            Employee employeeSix = new Employee("Trailer", "Peters", 105);
            Employee employeeSeven = new Employee("Tator", "Peters", 106);
            Employee employeeEight = new Employee("Gator", "Peters", 107);
            Employee employeeNine = new Employee("Joe", "Peters", 8);
            Employee employeeTen = new Employee("Joe", "Peterson", 9);

            employeeList.Add(employeeOne);
            employeeList.Add(employeeTwo);
            employeeList.Add(employeeThree);
            employeeList.Add(employeeFour);
            employeeList.Add(employeeFive);
            employeeList.Add(employeeSix);
            employeeList.Add(employeeSeven);
            employeeList.Add(employeeEight);
            employeeList.Add(employeeNine);
            employeeList.Add(employeeTen);

            // Finding Joe's with foreach loop
            List<Employee> joeList = new List<Employee>();
            foreach (Employee employee in employeeList)
            {
                if (employee.first == "Joe")
                    joeList.Add(employee);
            }

            // Find Joe's with lambda expression
            List<Employee> lambdaList = employeeList.Where(x => x.first == "Joe").ToList();
            foreach (Employee employee in lambdaList)
            {
                Console.WriteLine(employee.first + " " + employee.last);
            }

            // Finding employee id's with lambda expression
            List<Employee> bigNumber = employeeList.Where(x => x.employeeId > 5).ToList();
            foreach (Employee employee in bigNumber)
            {
                Console.WriteLine(employee.first + " " + employee.last + " - Employee ID: " + employee.employeeId);
            }
            Console.ReadLine();
        }
    }
}
