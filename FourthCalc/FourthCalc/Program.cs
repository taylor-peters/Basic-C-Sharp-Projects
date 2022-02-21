using System;


namespace FourthCalc
{
    class Program
    {
        static void Main(string[] args)
        { 
            Number number = new Number();

            Console.WriteLine("Choose two numbers.");
            number.numOne = Convert.ToInt32(Console.ReadLine()); 
            number.numTwo = Convert.ToInt32(Console.ReadLine());
            
            // Passes both arguments to Add method
            Number.Add(numOne: number.numOne, numTwo: number.numTwo);

            Console.ReadLine();
        }
    }
}
