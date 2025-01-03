using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcept
{
    internal class SmallNumInArr
    {
        static void Main()
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8 };
            int smallest = arr[0];
            foreach(int i in arr)
            {
                if (i<smallest)
                {
                    smallest = i ;
                }
            };
            Console.WriteLine("smallest number is" + smallest);
            
        }
    }
}
