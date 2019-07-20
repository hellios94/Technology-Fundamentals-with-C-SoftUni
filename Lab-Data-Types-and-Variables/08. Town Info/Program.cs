using System;

namespace _08._Town_Info
{
    class Program
    {
        static void Main(string[] args)
        {
            string town = Console.ReadLine();

            long population = long.Parse(Console.ReadLine());

            decimal area = decimal.Parse(Console.ReadLine());

            string info = TownInfo(town, population, area);

            Console.WriteLine(info);
        }

        public static string TownInfo(string town, long population, decimal area)
        {
            string info = $"Town {town} has population of {population} and area {area} square km.";

            return info;
        }
    }
}
