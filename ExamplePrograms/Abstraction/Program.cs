using System;

namespace Abstraction
{
   abstract class MotorBike
    {
        public abstract void Vehicles();
    }

    class SportsBike : MotorBike
    {
        public override void Vehicles()
        {
            Console.WriteLine("Sports Bike");
        }

    }

    class MountainBike : MotorBike
    { 
        public override void Vehicles()
        {
            Console.WriteLine("Mountain Bike");
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            // create an object of SportsBike class
            SportsBike s1 = new SportsBike();
            s1.Vehicles();

            // create an object of MountainBike class
            MountainBike m1 = new MountainBike();
            m1.Vehicles();

            Console.ReadLine();
        }
    }
}   


