using System;

namespace Garage
{
    public class Zero : Vehicle, IElectricVehicle
    {
        public double CurrentChargePercentage { get; set; } = 0.0;

        public void ChargeBattery()
        {
            Console.WriteLine("Zero is fully charged!");
            CurrentChargePercentage = 100.0;
        }

        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Zero screams past with an electric squeel! Weeown!");
        }

        public override void Turn(string direction)
        {
            Console.WriteLine($"The Zero cuts sharply to the {direction}!");
        }

        public override void Stop()
        {
            Console.WriteLine("With a screech of tires, the Zero comes to an abrupt stop!");
        }
    }
}
