using System;

namespace Garage
{
    public class Zero : Vehicle
    {
        public double BatteryKWh { get; set; }

        public void ChargeBattery()
        {
            // method definition omitted
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
