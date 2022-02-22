using System;

namespace NameSayer
{
    public class Person
    {
        public string firstName;
        public string lastName;
        public void SayName()
        {
            // Concatenates names
            string fullName = (firstName + " " + lastName);
            Console.WriteLine("Name: " + fullName);
        }

    }

}
