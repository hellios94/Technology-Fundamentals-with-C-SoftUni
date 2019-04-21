using System;

namespace _05._Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();

            string pass = Console.ReadLine();

            string password = "";

            int count = 0;

            for (int i = word.Length - 1; i >= 0; i--)
            {
                password += word[i];
            }

            while(pass != password && count < 4)
            {
                count++;

                if (count == 4)
                {
                    Console.WriteLine($"User {word} blocked!");
                    break;
                }

                Console.WriteLine("Incorrect password. Try again.");

                pass = Console.ReadLine();

               
            }

            if(count < 4)
            {
                Console.WriteLine($"User {word} logged in.");
            }
        }
    }
}
