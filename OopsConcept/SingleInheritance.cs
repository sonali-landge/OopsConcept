using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcept
{
    class Person1
    {
        public string Name;
        public int Age;
  
    }
    class Student : Person1
    {
        public Student(String name,int age) {
            Name = name;
            Age = age;
        }
        public void Display()
        {
            Console.WriteLine("student name and age is:"+ Name +" "+ Age);

        }
    }
    internal class SingleInheritance
    {
        public static void Main()
        {
            Student student = new Student("sonali", 23);
            student.Display();

        }
    }
}
