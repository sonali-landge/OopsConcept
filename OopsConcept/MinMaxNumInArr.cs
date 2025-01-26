using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcept
{
    internal class MinMaxNumInArr
    {
        static void Main()
        {
            int[] Arr = { 50, 30, 80, 10, 40 };
            int min = Arr[0];
            int max = Arr[0];
            foreach (int i in Arr)
            {
                if (i < min)
                {
                    min = i;
                }

                if (i > max)
                {
                    max = i;
                }
            }
            Console.WriteLine("Minimum Number is" + min);
            Console.WriteLine("maximum Number is" + max);

        }
    }
}

