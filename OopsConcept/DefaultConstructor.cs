using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcept
{

    public class DefaultConstrutorExample
    {
        public int Value;
        public DefaultConstrutorExample()
        {
            Value = 10;
        }
        public void DisplayVal()
        {
            Console.WriteLine(Value);
        }
        
    }
    internal class DefaultConstructor
    {
        static void Main()
        {
            DefaultConstrutorExample example = new DefaultConstrutorExample();
            example.DisplayVal();
        }
    }
}
