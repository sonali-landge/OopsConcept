using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcept
{
    internal class PrimeNumInArr
    {
        static void Main()
        {
            int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 };
            foreach (int num in nums)
            {
                if (num <= 1)
                {
                    continue;
                }
                bool isPrime = true;

                for (int i = 2; i <= num / 2; i++)
                {
                    if (num%i == 0)
                    {
                        isPrime = false;
                        break;
                    }


                }
                if (isPrime)
                {
                    Console.WriteLine(num+" ");
                }


            }

        }
    }
}
