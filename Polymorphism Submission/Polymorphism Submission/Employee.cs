using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_Submission
{
    class Employee : Person, IQuittable
    {
        bool isActive = true;

        // Virtual tag allows us to overwrite empty method from superclass
        public virtual void SayName()
        {
            string fullName = (firstName + " " + lastName);
            Console.WriteLine("Name: " + fullName);
        }
        public void Quit()
        {
            isActive = false;
        }
      
    }
}
