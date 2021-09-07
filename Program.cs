﻿namespace Garage
{
    class Program
    {
        static void Main(string[] args) 
        {
            Zero fxs = new Zero()
            {
                MainColor = "electric blue",
                MaximumOccupancy = 1
            };
            Tesla modelS = new Tesla()
            {
                MainColor = "fire engine red",
                MaximumOccupancy = 5
            };
            Cessna mx410 = new Cessna()
            {
                MainColor = "white",
                MaximumOccupancy = 4
            };
            Ram ram1500 = new Ram()
            {
                MainColor = "steel grey",
                MaximumOccupancy = 4
            };

            fxs.Drive();
            fxs.Turn("right");
            fxs.Stop();
            modelS.Drive();
            modelS.Turn("right");
            modelS.Stop();
            mx410.Drive();
            mx410.Turn("right");
            mx410.Stop();
            ram1500.Drive();
            ram1500.Turn("right");
            ram1500.Stop();
        }
    }
}

