using System;

namespace Padawan_Equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            double priceOfLightSaber = double.Parse(Console.ReadLine());
            double priceOfRobe = double.Parse(Console.ReadLine());
            double PriceOfBelt = double.Parse(Console.ReadLine());

            double totalPrice = GetPriceOfAllLightSabers(priceOfLightSaber, students) + GetPriceOfAllRobes(priceOfRobe, students)
                + GetPriceOfAllBelts(PriceOfBelt, students);

            if(money - totalPrice < 0)
            {
                Console.WriteLine($"Ivan Cho will need {String.Format("{0:F2}", Math.Abs(money - totalPrice))}lv more.");
            }
            else
            {
                Console.WriteLine($"The money is enough - it would cost {String.Format("{0:F2}", totalPrice)}lv.");
            }
        }


        public static double GetPriceOfAllLightSabers(double price, int countOfStudents)
        {

            double countOfAllLightSabers = Math.Ceiling(countOfStudents + (countOfStudents * 0.1));

            double totalPrice = countOfAllLightSabers * price;

            return totalPrice;
        }

        public static double GetPriceOfAllRobes(double price, int countOfStudents)
        {
            double totalPrice = countOfStudents * price;

            return totalPrice;
        }

        public static double GetPriceOfAllBelts(double price, int countOfAllStudents)
        {
            double discount = countOfAllStudents / 6;

            double countOfBelts = countOfAllStudents - (Math.Floor(discount));

            double totalPrice = countOfBelts * price;

            return totalPrice;
        }
    }
}


