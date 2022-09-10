using System;
using System.Collections;

namespace HashTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable hash = new Hashtable();

            hash.Add("1", "Zara Ali");
            hash.Add("2", "Abida Rehman");
            hash.Add("3", "Joe Holzner");
            hash.Add("4", "Mausam Benazir Nur");
            hash.Add("5", "M. Amlan");
            hash.Add("6", "M. Arif");
            hash.Add("7", "Ritesh Saikia");

            if (hash.ContainsValue("Nuha Ali"))
            {
                Console.WriteLine("This student name is already in the list");
            }
            else
            {
                hash.Add("8", "Nuha Ali");
            }

            // Get a collection of the keys.
            ICollection key = hash.Keys;

            foreach (string k in key)
            {
                Console.WriteLine(hash[k]);
            }
            Console.ReadKey();
        }
    }
}
        
    

