using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcept
{
    internal class DictionaryAssignment
    {
        public static void Main()
        {
            Dictionary<int, string> dictionary = new Dictionary<int, string>();
            dictionary.Add(1, "A");
            dictionary.Add(2, "B");
            dictionary.Add(3, "C");
            dictionary.Add(4, "D");
            dictionary.Add(5, "E");
            dictionary.Add(6, "F");
            dictionary.Add(7, "G");
            dictionary.Add(8, "H");
            dictionary.Add(9, "I");
            dictionary.Add(10, "J");
            foreach (var KVP in dictionary)
            {
                Console.WriteLine($"{KVP.Key}:{KVP.Value}");
               
            }
            dictionary[4] = "Sonali";
            Console.WriteLine("Dictionary after modifying element with key 4:");
            foreach (var KVP in dictionary)
            {
                Console.WriteLine($"{KVP.Key}:{KVP.Value}");

            }
            dictionary.Remove(3);
            Console.WriteLine("Dictionary after removing element with key 2:");
            foreach (var KVP in dictionary)
            {
                Console.WriteLine($"{KVP.Key}:{KVP.Value}");

            }

            Console.WriteLine("Checking if key 9 exists:");
            if (dictionary.ContainsKey(9))
            {
                Console.WriteLine($"Key 9exists with value: {dictionary[7]}");
            }
            else
            {
                Console.WriteLine("Key 9 does not exist.");
            }

            dictionary.Clear();
            Console.WriteLine("after clearing all elements:");
            Console.WriteLine("Count: " + dictionary.Count);


        }
    }
}
