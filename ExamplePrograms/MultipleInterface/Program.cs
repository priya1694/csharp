using System;

namespace MultipleInterface
{
    interface A
    {
        void Hello();
    }

    interface B
    {
        void Hello();
    }

    class Test : A, B
    {
        public void Hello()
        {
            Console.WriteLine("Hello to all");
        }
    }

    public class interface1
    {
        public static void Main()
        {
            Test Obj1 = new Test();
            Obj1.Hello();
        }
    }
}
