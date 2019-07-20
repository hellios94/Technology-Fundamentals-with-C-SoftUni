using System;

namespace _07._Concat_Names
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = Console.ReadLine();
            string lastName = Console.ReadLine();
            string separator = Console.ReadLine();


            Console.WriteLine(String.Concat(firstName, separator, lastName));
        }
    }
}
