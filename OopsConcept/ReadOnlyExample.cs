using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcept
{   
    class ReadOnlyExample1
    {
        public readonly int num1;
        public ReadOnlyExample1(int num2)
        {
            num1 = num2;
            num1 = 20;
        }
        public void printreadyOnly()
        {
            Console.WriteLine("Number is " + num1);
        }

    }
    internal class ReadOnlyExample
    {
        static void Main()
        {
            ReadOnlyExample1 e1 = new ReadOnlyExample1(30);
            e1.printreadyOnly();

        }

    }
}
