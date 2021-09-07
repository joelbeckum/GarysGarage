namespace Garage
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
            modelS.Drive();
            mx410.Drive();
            ram1500.Drive();
        }
    }
}

