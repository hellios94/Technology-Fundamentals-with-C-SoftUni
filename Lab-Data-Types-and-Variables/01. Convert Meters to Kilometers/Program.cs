using System;

namespace _01._Convert_Meters_to_Kilometers
{
    class Program
    {
        static void Main(string[] args)
        {
            int meters = int.Parse(Console.ReadLine());

            decimal kilometers = (decimal)meters / (decimal)1000;

            Console.WriteLine($"{String.Format("{0:F2}", kilometers)}");
        }
    }
}
