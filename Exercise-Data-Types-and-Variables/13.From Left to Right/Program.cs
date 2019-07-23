using System;
using System.Linq;

namespace _13.From_Left_to_Right
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());


            for (int i = 0; i < rows; i++)
            {

                var nums = Console.ReadLine().Split(' ').ToArray();


                bool isLeftBigger = CompareNums(nums[0], nums[1]);

                if(isLeftBigger)
                {
                   Console.WriteLine(SumNumbers(nums[0]));
                }
                else
                {
                    Console.WriteLine(SumNumbers(nums[1]));
                }
                    
            }
        }

        public static decimal SumNumbers(string n)
        {
            decimal sum = 0;


            if (int.Parse(n) < 0)
            {
                for (int i = 1; i <= n.Length - 1; i++)
                {
                    sum += decimal.Parse(n[i].ToString());
                }
            }
            else
            {
                for (int i = 0; i <= n.Length - 1; i++)
                {
                    sum += decimal.Parse(n[i].ToString());
                }
            }
            return Math.Abs(sum);
        }

        public static bool CompareNums(string left, string right)
        {
            decimal num1 = decimal.Parse(left);

            decimal num2 = decimal.Parse(right);

            if(num1 > num2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
