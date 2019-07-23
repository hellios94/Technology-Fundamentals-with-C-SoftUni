using System;

namespace _03._Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());

            int capacity = int.Parse(Console.ReadLine());

            Console.WriteLine(CalculteTheCourses(people, capacity));
        }


        public static int CalculteTheCourses(int people, int capacity)
        {
            decimal countOfCourses = Math.Ceiling((decimal)(people / (decimal)capacity));

            return (int)countOfCourses;
        }
    }
}
