using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_Submission
{
    class Person
    {
        // Constructor chained
        public Person(string firstName) : this(firstName, "Doe")
        {
        }
        public Person(string firstName, string lastName)
        {
            fName = firstName;
            lName = lastName;
        }
        public string fName { get; set; }
        public string lName { get; set; }
    }
}
