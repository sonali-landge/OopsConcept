using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcept
{public class Vehical
    { public virtual void StartEngine()
        {
            Console.WriteLine("Vehical Engine Started");
        }
    }
    public class Car:Vehical
    {
        public override void StartEngine()
        {
            Console.WriteLine("Car Engine Started");

        }
    }public class Truck : Vehical
    {
        public override void StartEngine()
        {
            Console.WriteLine("Truck Engine Started");

        }
    }
    internal class dynamicPolymorphism
    { static void Main()
        {
           Vehical vehical1 = new Vehical();
           Vehical car1 = new Car();
           Vehical truck1 = new Truck();
           car1.StartEngine();
           truck1.StartEngine();   
        }
    }
}
