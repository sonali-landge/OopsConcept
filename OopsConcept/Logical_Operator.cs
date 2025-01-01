using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcept
{
    internal class Logical_Operator
    {
        static void Main()
        {
            bool x = true;
            bool y = false;

            Console.WriteLine($"{(x && y)}");
            Console.WriteLine($"{(x || y)}");
            Console.WriteLine($"{!x}");
        }
    }
}
