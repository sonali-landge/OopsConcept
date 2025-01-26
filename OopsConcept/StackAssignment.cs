using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcept
{
    internal class StackAssignment
    { 
        public static void Main()
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);

            Console.WriteLine("after adding elements:");

            foreach (var ele in stack)
            {
                Console.WriteLine(ele);
            }
            int removeElement = stack.Pop();

            Console.WriteLine($"Removed element: {removeElement}");

            Console.WriteLine("after removing an element:");

            foreach (var ele in stack)
            {
                Console.WriteLine(ele);
            }
        }
    }
}
