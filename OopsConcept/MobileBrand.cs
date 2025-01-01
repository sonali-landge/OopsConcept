using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcept
{
    internal class MobileBrand
    {   static void Main()
        {

            string[] Mobile_brand = { "Apple", "Samsung", "OnePlus", "Oppo", "Vivo", "Sony", "Nokia" };
            foreach (string brand in Mobile_brand)
            {
                Console.WriteLine("Mobile Brands name is " + brand);
            }
        }
    }
}
