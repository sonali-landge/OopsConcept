using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcept
{
    abstract class Shape
    {
        public abstract double CalculateArea();
        public virtual void Display()
        {
            Console.WriteLine("This is a Shape class");
        }
    }
    class Rectangle:Shape
    {
        private double length;
        private double width;
        public Rectangle(double Length, double Width)
        {
          length= Length;
          width= Width;

        }
        public override double CalculateArea()
        {
            return length * width;
        }
        public override void Display()
        {
            Console.WriteLine("Area of Rectangle ");
        }
    }
    class Circle : Shape
    {
        private double radius;
        private double PI = 3.14;
        public Circle(double Radius)
        {
            radius = Radius;


        }
        public override double CalculateArea()
        {
            return PI * radius * radius;
        }
        public override void Display()
        {
            Console.WriteLine("Area of Circle is");
        }
    }
   

    internal class AbstractClassExample
    {
        static void Main()
        {
            Shape rectangle = new Rectangle(10,20);
            Shape circle = new Circle(10);

            rectangle.Display();
            double Area_Of_Rectangle=rectangle.CalculateArea();
            Console.WriteLine(Area_Of_Rectangle);
            circle.Display();
            double Area_Of_Circle=circle.CalculateArea();
            Console.WriteLine(Area_Of_Circle);


        }

    }
}
