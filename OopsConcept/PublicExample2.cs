using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcept
{
    public class PublicExample2
    {
        static void Main()
        {
            Person obj1 = new Person();
            obj1.FirstName = "Monali";
            obj1.LastName = "Landge";
            obj1.Show();
            obj1.Display();
        }
    }
}
