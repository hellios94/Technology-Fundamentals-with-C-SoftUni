using System;

namespace Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();

            string pass = Console.ReadLine();

            string password = Password(username);

            int tries = 1;

            while(pass != password)
            {
                tries++;

                if (tries > 4)
                {
                    break;
                }
                Console.WriteLine("Incorrect password. Try again.");

                pass = Console.ReadLine();
                
            }

            if(tries > 4)
            {
                Console.WriteLine($"User {username} is blocked!");
            }
            else
            {
                Console.WriteLine($"User {username} logged in.");
            }
        }

        public static string Password (string username)
        {
            string password = "";
            for(int i = username.Length - 1; i >= 0; i--)
            {
                password += username[i];
            }
            return password;
        }
    }
}
