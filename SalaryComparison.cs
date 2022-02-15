using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
         
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.WriteLine("Person 1");
            Console.WriteLine("What is your hourly rate?");
            double personOneRate = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("How many hours do you work per week?");
            double personOneHours = Convert.ToDouble(Console.ReadLine());

            // Calculates annual salary based on weekly hours and hourly rate, multiplied by weeks in a year
            double personOneSalary = personOneHours * personOneRate * 52; 

            Console.WriteLine("Person 2");
            Console.WriteLine("What is your hourly rate?");
            double personTwoRate = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("How many hours do you work per week?");
            double personTwoHours = Convert.ToDouble(Console.ReadLine());
            double personTwoSalary = personTwoHours * personTwoRate * 51;

            // Concatenates string with salary variable
            Console.WriteLine("Person 1's salary is $" + personOneSalary);
            Console.WriteLine("Person 2's salary is $" + personTwoSalary);

            // Compares salaries
            Console.WriteLine("Does Person 1 make more than Person 2?");
            bool salaryComparison = personOneSalary > personTwoSalary;
            Console.WriteLine(salaryComparison);
            Console.ReadLine();
        }
    }
}
