using System;

namespace _02._Sum_Digits
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            Console.WriteLine(SumOfDigits(num));
        }


        public static int SumOfDigits(int num)
        {
            int sum = 0;

            while (num != 0)
            {
                sum += num % 10;

                num /= 10;
            }

            return sum;
        }

    }
}
