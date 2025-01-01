using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcept
{
    internal class Arithmatic_Operator
    {
        static void Main()
        {
            int num1 = 50;
            int num2 = 5;
            int sum = num1 + num2;
            int sub = num1 - num2;
            int mul = num1 * num2;  
            int div= num1 / num2;   
            int rem= num1 % num2;   
            Console.WriteLine("Addition: " + sum);
            Console.WriteLine("Substraction: " + sub);
            Console.WriteLine("Multiplication: " + mul);
            Console.WriteLine("Division: " + div);
            Console.WriteLine("reminder: " + rem);
        }
    }
}
