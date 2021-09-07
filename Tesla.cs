using System;

namespace Garage
{
    public class Tesla : Vehicle, IElectricVehicle
    {
        public double CurrentChargePercentage { get; set; } = 0.0;

        public void ChargeBattery()
        {
            Console.WriteLine("Tesla is fully charged!");
            CurrentChargePercentage = 100.0;
        }

        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Tesla zips by with barely a noise! Foosh!");
        }

        public override void Stop()
        {
            Console.WriteLine("The Tesla glides silently to a stop.");
        }
    }
}
