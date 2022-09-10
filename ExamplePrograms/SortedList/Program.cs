using System;
using System.Collections.Generic;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
			//int,string
			SortedList<int, string> numbers = new SortedList<int, string>()
									{
										{3, "Three"},
										{5, "Five"},
										{1, "One"}
									};

			
		
			foreach (KeyValuePair<int, string> kvp in numbers)
				Console.WriteLine("key: {0}, value: {1}", kvp.Key, kvp.Value);

              //Add
			numbers.Add(6, "Six");
			numbers.Add(2, "Two");
			numbers.Add(4, "Four");

			//After Adding numbers
			foreach (var kvp in numbers)
				Console.WriteLine("key: {0}, value: {1}", kvp.Key, kvp.Value);


			//string,string
			SortedList<string, string> cities = new SortedList<string, string>()
											{
												{"London", "UK"},
												{"New York", "USA"}
											};
			foreach (var kvp in cities)
				Console.WriteLine("key: {0}, value: {1}", kvp.Key, kvp.Value);


			//Add
			cities.Add("Mumbai", "India");
			cities.Add("Johannesburg", "South Africa");

			//After Adding cities

			foreach (var kvp in cities)
				Console.WriteLine("key: {0}, value: {1}", kvp.Key, kvp.Value);
		}
	}
}

