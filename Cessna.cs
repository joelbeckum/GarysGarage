using System;

namespace Garage
{
    public class Cessna : Vehicle, IGasVehicle
    {
        public double CurrentTankPercentage { get; set; } = 0.0;

        public void RefuelTank()
        {
            Console.WriteLine("Cessna is fueled up and ready to fly!");
            CurrentTankPercentage = 100.0;
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

