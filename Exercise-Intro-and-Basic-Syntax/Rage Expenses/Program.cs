using System;

namespace Rage_Expenses
{
    class Program
    {
        static void Main(string[] args)
        {
            int lostGames = int.Parse(Console.ReadLine());
            double priceOfHeadset = double.Parse(Console.ReadLine());
            double priceOfMouse = double.Parse(Console.ReadLine());
            double priceOfKeyboard = double.Parse(Console.ReadLine());
            double priceOfDisplay = double.Parse(Console.ReadLine());

            double priceOfRage = CalculateThePriceOfAllHeadsets(lostGames, priceOfHeadset) + CalculateThePriceOfAllMouses(lostGames, priceOfMouse)
                + CalculateThePriceOfAllKeyboards(lostGames, priceOfKeyboard) + CalculateThePriceOfAllDisplays(lostGames, priceOfDisplay);

            Console.WriteLine($"Rage expenses: {String.Format("{0:F2}", priceOfRage)} lv.");
        }

        public static double CalculateThePriceOfAllHeadsets(int lostGames, double price)
        {
            double countOfHeadsets = lostGames / 2;

            double priceOfAllHeadsets = Math.Floor(countOfHeadsets) * price;

            return priceOfAllHeadsets;
        }

        public static double CalculateThePriceOfAllMouses(int lostGames, double price)
        {
            double countOfMouses = lostGames / 3;

            double priceOfAllMouses = Math.Floor(countOfMouses) * price;

            return priceOfAllMouses;
        }

        public static double CalculateThePriceOfAllKeyboards(int lostGames, double price)
        {
            double countOfKeyboards = lostGames / 6;

            double priceOfAllKeyboards = Math.Floor(countOfKeyboards) * price;

            return priceOfAllKeyboards;
        }

        public static double CalculateThePriceOfAllDisplays(int lostGames, double price)
        {
            double countOfDisplays = lostGames / 12;

            double priceOfAllDisplays = Math.Floor(countOfDisplays) * price;

            return priceOfAllDisplays;
        }
    }
}
