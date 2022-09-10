using System;

namespace MultipleObjects
{
    class Program
    {
        string color = "blue";
        string color1 = "red";
        static void Main(string[] args)
        {
            {
                Program myObj1 = new Program();
                Program myObj2 = new Program();
                Console.WriteLine(myObj1.color);
                Console.WriteLine(myObj2.color1);
            }
        }
    }
    }

