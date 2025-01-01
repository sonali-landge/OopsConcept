using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcept
{
    internal class Breakstmt
    {
        static void Main()
        {
            int Sum = 0;
            while (true)
            {
                Console.WriteLine("Enter a number");
                int n = int.Parse(Console.ReadLine());
                
                if (n < 0)
                {
                    break;
                }
                Sum = Sum + n;
                Console.WriteLine("now the sume is"+Sum);
            }

        }
    }
}
