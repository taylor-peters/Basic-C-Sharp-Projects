using System;


namespace FifthCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creates new number object
            Number number = new Number();

            Console.WriteLine("Enter an Integer to Divide by Two");
            number.numOne = Convert.ToInt32(Console.ReadLine());

            // Passes both arguments to Divide method
            // Prints once with instance class, once with static class
            Number.Divide(number.numOne);
            StaticNumber.Divide(number.numOne);

            Console.WriteLine("Enter a Second Integer to Divide the First By");
            number.numTwo = Convert.ToInt32(Console.ReadLine());
            Number.Divide(number.numOne, number.numTwo, out int numberOfOperands);
            StaticNumber.Divide(number.numOne, number.numTwo);
            Console.ReadLine();


        }
    }
}
