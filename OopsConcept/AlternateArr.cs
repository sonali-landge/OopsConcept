using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcept
{
    internal class AlternateArr
    {
        static void Main()
        {
            int[] arr1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            for (int i = 0; i < arr1.Length; i = i + 2)
            {


                Console.WriteLine(arr1[i]);


            }
        }
    }
}

