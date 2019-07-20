using System;

namespace _05._Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                IsSpecialNumber(i);
            }
        }


        public static void IsSpecialNumber(int num)
        {
            int sum = 0;
            int number = num;


            while(num != 0)
            {
                sum += num % 10;

                num = num / 10;
            }

            if(sum == 5 || sum == 7 || sum == 11)
            {
                Console.WriteLine($"{number} -> True");
            }
            else
            {
                Console.WriteLine($"{number} -> False");
            }
        }
    }
}
