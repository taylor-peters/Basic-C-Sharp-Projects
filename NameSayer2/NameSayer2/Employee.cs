using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameSayer2
{
    class Employee : Person, IQuittable
    {
        bool isActive = true;
        public int iD { get; set; }
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
        public static bool operator== (Employee e1, Employee e2)
        {
            if (e1.iD == e2.iD)
            {
                return true;
            }
            return false;
        }
        public static bool operator!= (Employee e1, Employee e2)
        {
            return !(e1.iD == e2.iD);
        }
    }
}
