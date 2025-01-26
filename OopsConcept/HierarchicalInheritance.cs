using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcept { 
  class Shape1
    {   public string Color=" ";
        public void DisplayDetails()
        {
            Console.WriteLine(Color);
        }
    }
    class Rectangle1 : Shape1
    {  public Rectangle1(string color)
        {
            Color = color;
        }
    }
    class Circle1 : Shape1
    {  public Circle1(string color)
        {
            Color = color;
        }
    }
    internal class HierarchicalInheritance
    {  public static void Main()
        {
            Rectangle1 r = new Rectangle1("Black");
            Circle1 c = new Circle1("White");
            Console.WriteLine("color of rectangle is ");
            r.DisplayDetails();
            Console.WriteLine("color of Circle is");
            c.DisplayDetails();
        }
    }
}
