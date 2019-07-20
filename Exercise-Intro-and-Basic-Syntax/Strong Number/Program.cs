using System;

namespace Strong_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string nums = Console.ReadLine();

            long num = long.Parse(nums);

            long sumOfAll = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                long sum = 0;

                sumOfAll += Factoriel(int.Parse(nums[i].ToString()), sum);
            }

            if(sumOfAll == num)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }


        public static long Factoriel(int n, long sum)
        {
            

            if(n == 0)
            {
                return 1;
            }

            sum += n * Factoriel(n - 1, sum);

            return sum;
        }
    }
}
