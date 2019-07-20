using System;

namespace Odd_Nums_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int oddNum = 1;

            int sum = 0;

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(oddNum);
                sum += oddNum;
                oddNum += 2;
            }

            Console.WriteLine($"Sum: {sum}");
        }
    }
}
