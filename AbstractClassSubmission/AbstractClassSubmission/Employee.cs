using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassSubmission
{
    public class Employee : Person
    { 
        public int iD { get; set; }
        
        // Virtual tag allows us to overwrite empty method from superclass
        public virtual void SayName()
        {
            string fullName = (firstName + " " + lastName);
            Console.WriteLine("Name: " + fullName);
        }
    }
}
