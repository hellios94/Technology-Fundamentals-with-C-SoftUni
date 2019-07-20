using System;

namespace Multiplication_Table_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            int start = int.Parse(Console.ReadLine());

            if(start <= 10)
            {
                for (int i = start; i <= 10; i++)
                {
                    Console.WriteLine($"{num} X {i} = {num * i}");
                }
            }
            else
            {
                Console.WriteLine($"{num} X {start} = {num * start}");
            }
            
        }
    }
}
