using System;

namespace Message
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string message = "";

            for (int i = 0; i < n; i++)
            {
                string nums = Console.ReadLine();

                message += PrintLetter(nums);
            }

            Console.WriteLine(message);
        }

        public static char PrintLetter(string nums)
        {
            char letter = ' ';

            switch(nums[0])
            {
                case '2':
                    {
                        if(nums.Length == 3)
                        {
                            letter = 'c';
                        }
                        else if(nums.Length == 2)
                        {
                            letter = 'b';
                        }
                        else if(nums.Length == 1)
                        {
                            letter = 'a';
                        }

                        break;
                    }
                case '3':
                    {
                        if (nums.Length == 3)
                        {
                            letter = 'f';
                        }
                        else if (nums.Length == 2)
                        {
                            letter = 'e';
                        }
                        else if (nums.Length == 1)
                        {
                            letter = 'd';
                        }

                        break;
                    }
                case '4':
                    {
                        if (nums.Length == 3)
                        {
                            letter = 'i';
                        }
                        else if (nums.Length == 2)
                        {
                            letter = 'h';
                        }
                        else if (nums.Length == 1)
                        {
                            letter = 'g';
                        }

                        break;
                    }
                case '5':
                    {
                        if (nums.Length == 3)
                        {
                            letter = 'l';
                        }
                        else if (nums.Length == 2)
                        {
                            letter = 'k';
                        }
                        else if (nums.Length == 1)
                        {
                            letter = 'j';
                        }

                        break;
                    }
                case '6':
                    {
                        if (nums.Length == 3)
                        {
                            letter = 'o';
                        }
                        else if (nums.Length == 2)
                        {
                            letter = 'n';
                        }
                        else if (nums.Length == 1)
                        {
                            letter = 'm';
                        }

                        break;
                    }
                case '7':
                    {
                        if (nums.Length == 4)
                        {
                            letter = 's';
                        }
                        else if (nums.Length == 3)
                        {
                            letter = 'r';
                        }
                        else if (nums.Length == 2)
                        {
                            letter = 'q';
                        }
                        else if (nums.Length == 1)
                        {
                            letter = 'p';
                        }

                        break;
                    }
                case '8':
                    {
                        if (nums.Length == 3)
                        {
                            letter = 'v';
                        }
                        else if (nums.Length == 2)
                        {
                            letter = 'u';
                        }
                        else if (nums.Length == 1)
                        {
                            letter = 't';
                        }

                        break;
                    }
                case '9':
                    {
                        if (nums.Length == 4)
                        {
                            letter = 'z';
                        }
                        else if (nums.Length == 3)
                        {
                            letter = 'y';
                        }
                        else if (nums.Length == 2)
                        {
                            letter = 'x';
                        }
                        else if (nums.Length == 1)
                        {
                            letter = 'w';
                        }

                        break;
                    }
                case '0':
                    {
                        if (nums.Length == 3)
                        {
                            letter = ' ';
                        }

                        break;
                    }
            }

            return letter;
        }
    }
}
