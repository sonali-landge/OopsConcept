using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcept
{
    internal class ReverseString
    {
        static void Main()
        {
            string str = "CODEMIND TECHNOLOGY";
            string Reverse_str = "";
                for (int i = str.Length-1; i >= 0; i--)
            {

                Reverse_str += str[i];
                
            }
            Console.WriteLine(Reverse_str);


        }

    }
}
