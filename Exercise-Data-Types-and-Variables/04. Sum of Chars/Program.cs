using System;

namespace _04._Sum_of_Chars
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                char c = char.Parse(Console.ReadLine());

                sum += NumOfChar(c);
            }

            Console.WriteLine($"The sum equals: {sum}");
        }


        public static int NumOfChar(char c)
        {
            int numOfChar = 0;

            numOfChar = (int)c;

            return (numOfChar);
        }
    }
}
