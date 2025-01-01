using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcept
{
    internal class Relational_Operator
    {
        static void Main()
        {
            int num1 = 10;
            int num2 = 5;

            Console.WriteLine($"{num1 == num2}");
            Console.WriteLine($"{num1 != num2}");
            Console.WriteLine($"{num1 > num2}");
            Console.WriteLine($"{num1 < num2}");
            Console.WriteLine($"{num1 >= num2}");
            Console.WriteLine($"{num1 <= num2}");
        }
    }
}
