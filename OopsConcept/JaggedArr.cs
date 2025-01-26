using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcept
{
    internal class JaggedArr
    {
        static void Main()
        {
            int[][] arr = new int[][]
            {
               new int[] {1,2},
               new int[] {3,4,5},
               new int[] {6,7,8,9,10,11}


            };

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    Console.Write(arr[i][j] + " ");

                }
                Console.WriteLine();
            }


        }
    }
}
