using System;

namespace _17._Decrypting_Message
{
    class Program
    {
        static void Main(string[] args)
        {
            int key = int.Parse(Console.ReadLine());

            int n = int.Parse(Console.ReadLine());

            string message = "";

            for (int i = 0; i < n; i++)
            {
                char c = char.Parse(Console.ReadLine());

                message += DescriptingChars(key, c);
            }

            Console.WriteLine(message);
        }


        public static char DescriptingChars(int key, char c)
        {
            char result = ' ';

            int numericValue = 0;

            numericValue = (int)c + key;

            result = (char)numericValue;

            return result;
        }
    }
}
