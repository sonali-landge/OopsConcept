using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcept
{
    internal class SearchNameInArr
    {
        static void Main()
        {
            string[] names = { "Alice", "Bob", "Charlie", "David", "Emily" };
            Console.WriteLine("Enter Name to search");
            string searchName=Console.ReadLine();
            bool isFound=Array.Exists(names,i=>i.Equals(searchName, StringComparison.OrdinalIgnoreCase));
            if (isFound)
            {
                Console.WriteLine(searchName + " is found");
            }
            else {
                Console.WriteLine(searchName + " is not found");
            }
            //using IndexOf: it finds index 
            //int finder = Array.IndexOf(names, searchName);
            //if (finder >= 0)
            //{
            //    Console.WriteLine("find");
            //}
        }
    }
}
