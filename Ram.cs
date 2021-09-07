using System;

namespace Garage
{
    public class Ram : Vehicle, IGasVehicle
    {
        public double CurrentTankPercentage { get; set; } = 0.0;

        public void RefuelTank()
        {
            Console.WriteLine("Ram is all fueled up!");
            CurrentTankPercentage = 100.0;
        }

        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Ram tears past you through the dirt! Grrowwnn!");
        }
    }
}
