using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcept
{
    internal class GradeCalculator
    {
        static void Main()
        {
            Console.Write("Enter a percentage: ");
            int grade = int.Parse(Console.ReadLine());

            if (grade >= 90)
                Console.WriteLine("Letter Grade: A");
            else if (grade >= 80)
                Console.WriteLine("Letter Grade: B");
            else if (grade >= 70)
                Console.WriteLine("Letter Grade: C");
            else if (grade >= 60)
                Console.WriteLine("Letter Grade: D");
            else
                Console.WriteLine("Letter Grade: F");
        }
    }
}
