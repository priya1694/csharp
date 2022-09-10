using System;

namespace ifelse
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                string gender = "Male";

                switch (gender)
                {
                    case "Male":
                        Console.WriteLine("male");
                        break;
                    case "Female":
                        Console.WriteLine("female");
                        break;
                    default:
                        Console.WriteLine("Default");
                        break;
                }

            }
        }
    }
}

