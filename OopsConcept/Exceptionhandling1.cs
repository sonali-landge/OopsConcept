using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcept
{
    internal class Exceptionhandling1
    {
        public static void Main()
        {
            try
            {
                Console.WriteLine("Enter number 1");
                int number1 = int.Parse(Console.ReadLine());
                Console.WriteLine("enter number 2");
                int number2 = int.Parse(Console.ReadLine());
                int add = number1 + number2;
                Console.WriteLine("Addision is "+ add);
                int sub = number1 - number2;
                Console.WriteLine("Substraction is"+ sub);
                int mul = number2 * number1;
                Console.WriteLine("Multiplication is"+  mul);
                int div = number1 / number2;
                Console.WriteLine("division is"+div);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"Error:{ex.Message}");
            }
            catch(OverflowException ex)
            {
                Console.WriteLine($"Error:{ex.Message}");
            }
            catch(FormatException ex)
            {
                Console.WriteLine($"Error:{ex.Message}");
            }
            finally 
            {
                Console.WriteLine("calculation done...");
            }
     

             
            
        }
    }
}
