using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcept
{
    internal class SingleDelegate
    {
        public delegate void AddDelegate(int a, int b);
        public delegate void SubDelegate(int a, int b);
        public static void Addition(int a, int b)
        {
            Console.WriteLine($"Addition is {a + b}");
        }
        public static void Substraction(int a, int b)
        {
            Console.WriteLine($"Substraction is {a - b}");
        }
        public static void Main()
        {
            AddDelegate add = Addition;
            add(3, 5);
            SubDelegate sub = Substraction;
            sub(4, 2);
        }

    }
}
