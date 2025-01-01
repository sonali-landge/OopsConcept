using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcept
{
    class ConstExample1
    {
        public const string str1= "Constat";
        public int Number=10;
       
        

        public void printConstat()
        {
           

            Console.WriteLine("num is " + Number);
           
            Console.WriteLine("string is " + str1);
            
        }

    }

    internal class ConstExample
    {
        static void Main()
        {
            ConstExample1 example1 = new ConstExample1();    
            example1.printConstat();

        }
    }
}
