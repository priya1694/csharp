using System;
using System.Collections.Generic;

namespace Lists
{
	class Program
	{
		static void Main(string[] args)
		{
			{
				string[] cities = new string[3] { "Mumbai", "London", "New York" };

				var popularCities = new List<string>();

				
				popularCities.AddRange(cities);

				var favouriteCities = new List<string>();

				 
				favouriteCities.AddRange(cities);

				Console.WriteLine(popularCities.Count);
				Console.WriteLine(favouriteCities.Count);

			}
		}
	}
}

