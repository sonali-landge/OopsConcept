using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcept
{
   
    public class ParameterizedConstructorExample
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public ParameterizedConstructorExample(string name,int age)
        { 
           Name=name ;
           Age= age ;
        } 
        public  void DisplayInfo()
        {
            Console.WriteLine("name is " + Name);
            Console.WriteLine("age is "+ Age);  
        }

    }



    internal class ParameterizedConstructor
    {
        static void Main()
        {
            ParameterizedConstructorExample example = new ParameterizedConstructorExample("Sonali",23);
            example.DisplayInfo();  

        }

    }
}
