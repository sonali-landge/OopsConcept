using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcept
{
    internal class EvenOddInt
    { static void Main()
        {
            
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            foreach (int i in numbers)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine("even number " + i);
                }
                else
                {
                    Console.WriteLine("Odd number " + i);
                }
    
            }
        }
        
    }
}
