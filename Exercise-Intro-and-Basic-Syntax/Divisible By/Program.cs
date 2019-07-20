using System;

namespace Divisible_By
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            if (IsDivisible(10, num))
            {
            }

            else
            {
                if(IsDivisible(7, num))
                {
                }

                else
                {
                    if(IsDivisible(6, num))
                    {

                    }
                    else
                    {
                        if(IsDivisible(3, num))
                        {

                        }
                        else
                        {
                            if(IsDivisible(2, num))
                            {

                            }
                            else
                            {
                                Console.WriteLine("Not divisible");
                            }
                        }
                    }
                }
            }
        }


        public static bool IsDivisible (int n, int num)
        {
            if(num % n == 0)
            {
                Console.WriteLine($"The number is divisible by {n}");
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
