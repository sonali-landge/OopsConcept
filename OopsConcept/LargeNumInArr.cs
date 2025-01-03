using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcept
{
    internal class LargeNumInArr
    {
        static void Main()
        {
            int[] arr = { 1, 2, 3, 4, 5, 78, 7, 8, 9, 10 };
            int largest = arr[0];
            foreach (int i in arr)
            {
                if (i > largest)
                {
                    largest = i;
                   
                }
            }
            Console.WriteLine("largest number is" + largest);
        }
    }
}
