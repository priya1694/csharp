using System;
using System.Collections.Generic;

namespace List1
{
	class Program
	{
		static void Main(string[] args)
		{

			{
				List<int> intList = new List<int>() { 10, 20, 30, 40, 50 };

				//Accesing list elements using forach and forloop
				
				//using foreach
				foreach (var el in intList)
					Console.WriteLine(el);

				//using for loop
				for (int i = 0; i < intList.Count; i++)
					Console.WriteLine(intList[i]);

			}
		}
	}
}
