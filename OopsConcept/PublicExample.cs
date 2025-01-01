using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcept
{   public class Person
    {
        public string FirstName{get; set;}
        public string LastName{get; set;}
        public void Show()
        {
            Console.WriteLine("First name is "+FirstName);
            Console.WriteLine("Last name is "+LastName);


        }
        public void Display()
        {
            Console.WriteLine("Full Name is "+FirstName +" "+LastName);

        }
    }
    public class PublicExample
    {
        static void Main()
        {
            Person obj = new Person();
            obj.FirstName = "Sonali";
            obj.LastName = "Landge";
            obj.Show();
            obj.Display();

        }
    }
}
