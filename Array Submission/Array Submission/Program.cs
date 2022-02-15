using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Submission
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] foods = { "Cereal", "Banana", "Bread", "Coffee", "Apple", "Hamburger", "Walnut", "Peach", "Pear", "Kale" };
            Console.WriteLine("Pick an index between 1-10");

            // Takes user input, adjusts for array index
            int foodIndex = Convert.ToInt32(Console.ReadLine()) - 1;

            // Checks for illegal input
            if (foodIndex > 9)
                Console.Write("Number is outside of available options");
                Console.ReadLine();
            Console.WriteLine(foods[foodIndex]);
            Console.ReadLine();

            int[] nums = { 4,6,87,9,342,5,67,8, 89,1200};
            Console.WriteLine("Pick an index between 1-10");
            int numIndex = Convert.ToInt32(Console.ReadLine()) - 1;
            if (numIndex > 9)
                Console.Write("Number is outside of available options");
                Console.ReadLine();

            Console.WriteLine(nums[numIndex]);
            Console.ReadLine();

            // Instantiates new list of strings
            List<string> newFoods = new List<string>
                { "Cereal", "Coffee", "Apple", "Hamburger", "Walnut", "Pear", "Banana", "Bread",  "Peach", "Kale" };
            Console.WriteLine("Pick an index between 1-10");
            int newFoodIndex = Convert.ToInt32(Console.ReadLine()) - 1;
            if (newFoodIndex > 9)
                Console.Write("Number is outside of available options");
                Console.ReadLine();
            Console.WriteLine(newFoods[newFoodIndex]);
            Console.ReadLine();
        }
    }
}
