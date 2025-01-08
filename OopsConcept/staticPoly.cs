using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcept
{
    class Calculator
    {
        public void Add(int a, int b)
        {
            Console.WriteLine("sum of two int numbers is" + (a + b));
        }
        public void Add(double a, double b)
        {
            Console.WriteLine("sum of two double numbers is" + (a + b));
        }
        public void Add(double a, int b)
        {
            Console.WriteLine("sum of int and double numbers is" + (a + b));
        }
        public void Add(int a, double b, int c)
        {
            Console.WriteLine("sum of two int and  one double number is" + (a + b + c));
        }
    }
        internal class staticPoly
        {
            static void Main()
            {
                Calculator calculator = new Calculator();
                calculator.Add(2, 4);
                calculator.Add(3.5, 5.5);
                calculator.Add(4.5, 6);
                calculator.Add(6, 7.5, 2);


            }
        }
    
}
