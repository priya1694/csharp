using System;
using System.Collections.Generic;
using System.Linq;

namespace List
{
	class Student
	{
		public int Id { get; set; }
		public string Name { get; set; }
	}
	class Program
    {
        static void Main(string[] args)
        {
			var primeNumbers = new List<int>();
			primeNumbers.Add(1);
			primeNumbers.Add(3);
			primeNumbers.Add(5);
			primeNumbers.Add(7);

			foreach( var i in primeNumbers)
            {
				Console.WriteLine(i);
            }

			Console.WriteLine("No of elements: " + primeNumbers.Count);

			var cities = new List<string>();
			cities.Add("New York");
			cities.Add("London");
			cities.Add("Mumbai");
			cities.Add("Chicago");

			foreach (var i in cities)
			{
				Console.WriteLine(i);
			}

			var students = new List<Student>() {
				new Student(){ Id = 1, Name="Bill"},
				new Student(){ Id = 2, Name="Steve"},
				new Student(){ Id = 3, Name="Ram"},
				new Student(){ Id = 4, Name="Abdul"}
			};

			//Using Language integrated Query(LINQ)
			var studNames = from s in students
							where s.Name == "Bill"
							select s;

			foreach (var student in studNames)
				Console.WriteLine(student.Id + ", " + student.Name);

			Console.WriteLine("No of elements: " + students.Count);
		}
	}

	
}
