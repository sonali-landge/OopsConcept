using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcept
{
    internal class Gotostmt
    {
        static void Main()
        {
            int age;

        start:
            Console.WriteLine("Enter your age");
            age = int.Parse(Console.ReadLine()); 

            if (age < 0 || age > 120) 
            {
                Console.WriteLine("Invalid age. Please try again.");
                goto start; 
            }

            Console.WriteLine("You entered the correct age: " + age);
        }


    }
}
