using System;

namespace _06._Reversed_Chars
{
    class Program
    {
        static void Main(string[] args)
        {
            string chars = "";

            for (int i = 0; i < 3; i++)
            {
                char c = char.Parse(Console.ReadLine());

                chars += c + " ";
            }

            Console.WriteLine(ReverseChars(chars.TrimEnd()));
        }


        public static string ReverseChars(string chars)
        {
            string reversedChars = "";

            for (int i = chars.Length - 1; i >= 0; i--)
            {
                reversedChars += chars[i];
            }

            return reversedChars;
        }
    }
}
