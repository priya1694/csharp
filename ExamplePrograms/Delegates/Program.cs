using System;

namespace Delegates
{
   
    public delegate int Mydelegate(int x, int y);
    class sample
    {
        public static int rectangle(int a, int b)
        {

            return a * b;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("My simple Delegate Program");
            Mydelegate mdl = new Mydelegate(sample.rectangle);
            Console.WriteLine("The Area of rectangle is {0}", mdl(4, 5));
            
        }
    }
}
