using System;

namespace constructors
{       
    class Program
        {
            public string model;
            public string color;
            public int year;

            public Program(string modelName, string colorName, int modelYear)
            {
                model = modelName;
                color = colorName;
                year = modelYear;
            }
            static void Main(string[] args)
            {
                Program Prog = new Program("aaaa", "red", 1972);
                Console.WriteLine(Prog.model + " " + Prog.color + " " + Prog.year);


            }
        }
    }
