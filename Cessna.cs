using System;

namespace Garage
{
    public class Cessna : Vehicle
    {
        public double FuelCapacity { get; set; }

        public void RefuelTank()
        {
            // method definition omitted
        }

        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Cessna flashes by you like a hurricane. Zoooooom!");
        }

        public override void Turn(string direction)
        {
            Console.WriteLine($"The Cessna banks gracefully to the {direction}.");
        }

        public override void Stop()
        {
            Console.WriteLine("As it lands on the runway, the Cessna slowly rolls to a stop.");
        }
    }
}

