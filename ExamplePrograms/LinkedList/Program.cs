using System;
using System.Collections.Generic;

namespace LinkedList
{
    public class LinkedList
    {
        public static void Main(string[] args)
        {
              
            var names = new LinkedList<string>();
            names.AddLast("Sonoo Jaiswal");
            names.AddLast("Ankit");
            names.AddLast("Peter");
            names.AddLast("Irfan");
            names.AddFirst("John");  

              
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
