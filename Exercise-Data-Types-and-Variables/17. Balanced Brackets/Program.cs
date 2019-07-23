using System;

namespace _17._Balanced_Brackets
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int count = 0;

            for (int i = 0; i < n; i++)
            {
                string command = Console.ReadLine();

                if (command == "(")
                {
                    count++;
                }
                else if (command == ")")
                {
                    count--;
                }

                if(count < 0)
                {
                    break;
                }
            }

            if(count == 0)
            {
                Console.WriteLine("BALANCED");
            }
            else
            {
                Console.WriteLine("UNBALANCED");
            }
        }
    }
}
