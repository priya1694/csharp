using System;
using System.Collections.Generic;

namespace Queues
{
    class Program
    {
        static void Main(string[] args)
		{
			//FIFO
			Queue<string> str = new Queue<string>();
			str.Enqueue("H");
			str.Enqueue("e");
			str.Enqueue("l");
			str.Enqueue("l");
			str.Enqueue("o");

			//Total elements count
			Console.WriteLine("Total elements: {0}", str.Count); 

			//To remove the elements
			while (str.Count > 0)
				Console.WriteLine(str.Dequeue()); 

			//count at the end (after removing)
			Console.WriteLine("Total elements: {0}", str.Count); 
		}
	}
}

