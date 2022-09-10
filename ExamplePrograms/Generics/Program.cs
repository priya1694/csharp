using System;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
			//string
			DataStore<string> str = new DataStore<string>();
			str.Data = "Hello World!";
			Console.WriteLine(str.Data);

			//int
			DataStore<int> ist = new DataStore<int>();
			ist.Data = 100;
			Console.WriteLine(ist.Data);

			//int,string
			KeyValuePair<int, string> vp = new KeyValuePair<int, string>();
			vp.Key = 100;
			vp.Value = "Hundred";
			Console.WriteLine(vp.Key + ", " + vp.Value);

			//string,string
			KeyValuePair<string, string> vp2 = new KeyValuePair<string, string>();
			vp2.Key = "IT";
			vp2.Value = "Information Technology";
			Console.WriteLine(vp2.Key + ", " + vp2.Value);
		}
	}

	class DataStore<T>
	{
		public T Data { get; set; }
	}

	class KeyValuePair<TKey, TValue>
	{
		public TKey Key { get; set; }
		public TValue Value { get; set; }
	}
}

