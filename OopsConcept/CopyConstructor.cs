using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcept
{
    public class CopyConstructorExample
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string NameNew{ get; set; }
        public int AgeNew { get; set; }

        public CopyConstructorExample(string name,int age)
        {
            Name= name;
            Age= age;
        }


        public CopyConstructorExample(CopyConstructorExample copyex )
        {
            NameNew = copyex.Name;
            AgeNew = copyex.Age;
        }

        public void DisplayInfo()
        {
            Console.WriteLine("name is " + NameNew);
            Console.WriteLine("age is " + AgeNew);
        }

    }
    internal class CopyConstructor
    {
        static void Main()
        {
            CopyConstructorExample example = new CopyConstructorExample("Sonali", 23);
            CopyConstructorExample copyex = new CopyConstructorExample(example);

            example.DisplayInfo();
            copyex.DisplayInfo();

        }

    }


}
