using System;

namespace _12._Refactor_Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            int sum = 0;
            int num = 0;
            bool isSpecialNum = false;
            for (int lastDigit = 1; lastDigit <= count; lastDigit++)
            {
                num = lastDigit;
                while (lastDigit > 0)
                {
                    sum += lastDigit % 10;
                    lastDigit = lastDigit / 10;
                }
                isSpecialNum = (sum == 5) || (sum == 7) || (sum == 11);
                Console.WriteLine("{0} -> {1}", num, isSpecialNum);
                sum = 0;
                lastDigit = num;
            }

        }
    }
}
