using System;

namespace _04._Centuries_to_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int centuries = int.Parse(Console.ReadLine());

            int years = TransformCenturiesToYears(centuries);

            int days = TransformYearsToDays(years);

            long hours = TransformDaysToHours(days);

            decimal minutes = TransformHoursToMinutes(hours);

            Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes");
        }


        public static int TransformCenturiesToYears(int centuries)
        {
            int years = 0;

            years = centuries * 100;

            return years;
        }

        public static int TransformYearsToDays(int years)
        {
            int days = 0;

            days = (int)(years * 365.2422);

            return days;
        }

        public static long TransformDaysToHours(int days)
        {
            long hours = 0;

            hours = days * 24;

            return hours;
        }

        public static decimal TransformHoursToMinutes(long hours)
        {
            decimal minutes = 0;

            minutes = hours * 60;

            return minutes;
        }
    }
}
