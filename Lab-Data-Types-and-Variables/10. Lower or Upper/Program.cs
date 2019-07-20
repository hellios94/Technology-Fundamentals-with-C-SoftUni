using System;

namespace _10._Lower_or_Upper
{
    class Program
    {
        static void Main(string[] args)
        {
            char character = char.Parse(Console.ReadLine());

            if(IsUpper(character))
            {
                Console.WriteLine("upper-case");
            }
            else
            {
                Console.WriteLine("lower-case");
            }
        }


        public static bool IsUpper(char c)
        {
            bool result = Char.IsUpper(c);

            return result;
        }
    }
}
