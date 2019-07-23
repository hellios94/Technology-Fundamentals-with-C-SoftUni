using System;

namespace _07._Water_Overflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double allWater = 0;

            for (int i = 0; i < n; i++)
            {
                double litters = double.Parse(Console.ReadLine());

                allWater = PourWaterTank(litters, allWater);
            }

            Console.WriteLine(allWater);
        }

        public static double PourWaterTank(double litters, double waterInTank)
        {
            if (waterInTank + litters > 255)
            {
                Console.WriteLine("Insufficient capacity!");
            }
            else
            {
                waterInTank += litters;
            }

            return waterInTank;
        }
    }
}
