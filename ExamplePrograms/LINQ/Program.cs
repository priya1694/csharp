using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ
{
    class Demo
    {
        static void Main(string[] args)
        {
            List<int> intnums = new List<int>();

            intnums.Add(10);
            intnums.Add(11);
            intnums.Add(12);
            intnums.Add(13);
            intnums.Add(14);

            var IndexOfEvenNumber = intnums.Select((num, index) => new
            {
                Numbers = num,
                IndexPosition = index
            }).Where(n => n.Numbers % 2 == 0).Select(result => new
            {
              Number = result.Numbers,
              IndexPosition = result.IndexPosition
            });

            foreach (var value in IndexOfEvenNumber)
            {
                Console.WriteLine(value.IndexPosition + " , " + value.Number);
            }
        }
    }
}
    

