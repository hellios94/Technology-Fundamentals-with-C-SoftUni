using System;

namespace _08._Beer_Kegs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double maxVolume = 0;

            string maxVolumeModel = "";

            for (int i = 0; i < n; i++)
            {
                string model = Console.ReadLine();

                double r = double.Parse(Console.ReadLine());

                int h = int.Parse(Console.ReadLine());

                double volume = VolumeOfKegs(r, h);

                if(volume > maxVolume)
                {
                    maxVolume = volume;
                    maxVolumeModel = model;
                }
            }

            Console.WriteLine(maxVolumeModel);
        }


        public static double VolumeOfKegs(double r, int h)
        {
            double volume = Math.PI * Math.Pow(r, 2) * h;

            return volume;
        }
    }
}
