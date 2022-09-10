using System;

namespace Interface
{
    interface IPolygon
    {
        void calculateArea(int l, int b);
    }

    class Rectangle : IPolygon
    {

      
        public void calculateArea(int l, int b)
        {
            int area = l * b;
            Console.WriteLine("Area of Rectangle: " + area);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            Rectangle r= new Rectangle();

            r.calculateArea(10, 20);

        }
    }
}

