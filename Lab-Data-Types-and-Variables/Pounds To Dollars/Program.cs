using System;

namespace Pounds_To_Dollars
{
    class Program
    {
        static void Main(string[] args)
        {
            double pounds = double.Parse(Console.ReadLine());

            Console.WriteLine(String.Format("{0:F3}", TransformPoundsToDollars(pounds)));
        }


        public static double TransformPoundsToDollars(double pound)
        {
            double dollar = 0;

            dollar = pound * 1.31;

            return dollar;
        }
    }
}
