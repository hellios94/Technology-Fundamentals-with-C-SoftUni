using System;

namespace Reverse_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();

            Console.WriteLine(Reverse(str));
        }

        public static string Reverse(string str)
        {
            string text = "";

            for (int i = str.Length - 1; i >= 0; i--)
            {
                text += str[i];
            }

            return text;
        }
    }
}
