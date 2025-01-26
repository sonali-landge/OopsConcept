using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcept
{
    internal class AppendStrToStrBuilder
    {
        static void Main()
        {
            StringBuilder sb=new StringBuilder();
            sb.Append("Hello ");
            sb.Append("How ");
            sb.Append("are ");
            sb.Append("you");
            Console.WriteLine(sb.ToString());
            sb.Replace("Hello", "Hey");
            Console.WriteLine(sb.ToString());
            // Hey how are you
            //now remove "how"
            sb.Remove(4, 3);
            Console.WriteLine(sb.ToString());
        }
    }
}
