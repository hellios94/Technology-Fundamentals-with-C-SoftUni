using System;

namespace _14._Floating_Equality
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1 = double.Parse(Console.ReadLine());

            double num2 = double.Parse(Console.ReadLine());

            Console.WriteLine(CompareTwoDobleNums(num1, num2));
        }


        public static bool CompareTwoDobleNums(double num1, double num2)
        {

            if(Math.Abs(num1 - num2) < 0.000001)
            {
                return true;
            }

            return false;
        }
    }
}
