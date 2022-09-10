using System;

namespace Inheritance
{
   
        class student
        {
            public string name = "Priya";
           
            public void Message()
            {
                Console.WriteLine("Hello i'm Priya Kowshik");
            }
        }
    

        class student1 : student 
        {
            public string lN = "Kowshik";  
        }

    class Program
    { 
            static void Main(string[] args)
            {
                
                student s = new student();
                s.Message();
              Console.WriteLine(s.name+ " " + s.lN);
            }
        }
    }

