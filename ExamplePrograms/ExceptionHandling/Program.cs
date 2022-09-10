﻿using System;

namespace ExceptionHandling
{
    class Program
    {
     
      int result=0;

        public void division(int num1, int num2)
        {
            try
            {
                result = num1 / num2;
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Exception caught: {0}", e);
            }
            finally
            {
                Console.WriteLine("Result: {0}", result);
            }
        }
        static void Main(string[] args)
        {
            Program P = new Program();
            P.division(25, 0);
            Console.ReadKey();
        }
    }
}
