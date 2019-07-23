using System;

namespace _05.Print_Part_Of_ASCII
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());

            int end = int.Parse(Console.ReadLine());

            string result = "";

            for (int i = start; i <= end; i++)
            {
                result += PrintChar(i) + " ";
            }

            Console.WriteLine(result.TrimEnd());
        }

        public static char PrintChar(int n)
        {
            char c = ' ';

            c = (char)n;

            return c;
        }
    }
}
