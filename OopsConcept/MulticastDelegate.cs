using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static OopsConcept.MultiDelegateExample;
namespace OopsConcept
{
    public class MultiDelegateExample
    {
        public delegate void Delegate1(int a, int b);

        public  void Addition(int a, int b)
        {
            Console.WriteLine($"Addition is {a + b}");
        }
        public  void Substraction(int a, int b)
        {
            Console.WriteLine($"Substraction is {a - b}");
        }
        public void Multiplication(int a, int b)
        {
            Console.WriteLine($"Multiplication is {a * b}");
        }
    }
    internal class MulticastDelegate
    {
        public static void Main()
        {
            MultiDelegateExample m1 = new MultiDelegateExample();
            Delegate1 d1 = m1.Addition;
            d1 += m1.Substraction;
            d1+= m1.Multiplication;
            d1(8,2);





        }
    }
}
