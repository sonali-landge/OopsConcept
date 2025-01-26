using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcept
{
    class NegativeNumberException:Exception
    {
        public string customMessage;
        public NegativeNumberException() 
        {
            customMessage = "Negative number is not allowed";
        }
    }internal class Exceptionhandling2
    {public static void Main()
        { try
            {
                Console.WriteLine("please enter positive number ");
                int num = int.Parse(Console.ReadLine());
                if (num < 0)
                {
                    throw new NegativeNumberException();

                }
                Console.WriteLine("You entered" + num);
            }
            catch (FormatException ex)
            {
                Console.WriteLine($"Error..Invalid Input:{ex.Message}");
            }
            catch (NegativeNumberException ex)
            {
                Console.WriteLine($"Error..:{ex.Message}");
            }
            finally
            {
                Console.WriteLine("Program execution finished");
            }
        }
    }
}
