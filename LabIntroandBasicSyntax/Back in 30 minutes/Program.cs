using System;

namespace Back_in_30_minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());

            int minutes = int.Parse(Console.ReadLine());

            After30Minutes(hours, minutes + 30);
        }

        public static void After30Minutes(int hours, int minutes)
        {
            if (minutes >= 60)
            {
                if (hours < 23)
                {
                    hours++;
                    minutes -= 60;
                }
                else if (hours == 23)
                {
                    hours = 0;
                    minutes -= 60;
                }
            }

            if(minutes < 10)
            {
                Console.WriteLine($"{hours}:0{minutes}");
            }
            else
            {
                Console.WriteLine($"{hours}:{minutes}");
            }
            
        }
    }
}
