using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcept
{
    internal class Continuestmt
    {
        static void Main()
        {
            
            for (int i = 1; i <=20; i++)
            {
                if (i % 3 == 0)
                {
                    continue;
                }
             Console.WriteLine(i);
            }


            
        }
    }
}
