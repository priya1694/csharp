using System;
using System.Collections.Generic;
using System.Text;

namespace ExamplePrograms
{
    class LargestNumber
    {
        static void Main(string[] args)
        {
            int num1=10, num2=20, num3=30;
            if (num1 > num2)
            {
                if (num1 > num3)
                {
                    Console.Write("Number one is the largest!\n");
                }
                else
                {
                    Console.Write("Number three is the largest!\n");
                }
            }

            else if (num2 > num3)
            {
                Console.Write("Number two is the largest!\n");
            }
            else
            {
                Console.Write("Number three is the largest!\n");
            }
        }
        }
        }
    
