using System;

namespace _04.BackIn30Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());

            int minutes = int.Parse(Console.ReadLine());

            int result = minutes + 30;

            if(result > 59)
            {
                hours++;
                if(hours > 23)
                {
                    hours = 0;
                }
                result -= 60;
            }

            if(result < 10)
            {
                Console.WriteLine($"{hours}:0{result}");
            }
            else
            {
                Console.WriteLine($"{hours}:{result}");
            }
        }
    }
}
