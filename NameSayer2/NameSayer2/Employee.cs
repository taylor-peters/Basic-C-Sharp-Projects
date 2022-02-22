using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameSayer2
{
    class Employee : Person
    {
        // Virtual tag allows us to overwrite empty method from superclass
        public virtual void SayName()
        {
            string fullName = (firstName + " " + lastName);
            Console.WriteLine("Name: " + fullName);
        }
    }
}
