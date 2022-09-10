using System;
using System.Collections;

namespace Stacks
{
    class Program
    {
        public static void Main(string[] args)
		{
			//LIFO
			Stack myStack = new Stack();

			//Pushing the elements
			myStack.Push(1);
			myStack.Push(2);
			myStack.Push(3);
			myStack.Push(4);

			Console.WriteLine("Number of elements in Stack: {0}", myStack.Count);

			//Popping the elements
			while (myStack.Count > 0)
		    Console.Write(myStack.Pop() + ",");

			Console.WriteLine();
			Console.WriteLine("Number of elements in Stack: {0}", myStack.Count);
		}
	}
}

