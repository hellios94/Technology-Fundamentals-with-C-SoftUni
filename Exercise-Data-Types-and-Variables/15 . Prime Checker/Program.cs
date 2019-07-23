using System;

namespace _15_._Prime_Checker
{
    class Program
    {
        static void Main(string[] args)
        {
            int range = int.Parse(Console.ReadLine());
            for (int num = 2; num <= range; num++)
            {
                bool isPrime = true;
                for (int delimeter = 2; delimeter < num; delimeter++)
                {
                    if (num % delimeter == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                Console.WriteLine("{0} -> {1}", num, isPrime.ToString().ToLower());
            }

        }
    }
}
