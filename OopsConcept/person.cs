using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcept
{


    class person
    {
        private string firstName { get; set; }
        private string lastName { get; set; }
        public void DisplayFullName()
        {
            Console.WriteLine(" Full Name is " + firstName + " " + lastName);
        }
        static void Main()
        {
            person p1 = new person();
            p1.firstName = "Sonali";
            p1.lastName = "Landge";
            p1.DisplayFullName();

        }

    }
}



