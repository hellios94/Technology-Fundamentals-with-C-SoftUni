    using System;

    namespace Triangle_of_numbers
    {
        class Program
        {
            static void Main(string[] args)
            {
                int n = int.Parse(Console.ReadLine());

                for (int i = 1; i <= n; i++)
                {
                    Console.WriteLine(LineOfNums(i));
                }
            }


            public static string LineOfNums(int n)
            {
                string line = "";

                for(int i = 0; i < n; i++)
                {
                    line += n + " ";
                }


                return line.TrimEnd();

            }
        }
    }
