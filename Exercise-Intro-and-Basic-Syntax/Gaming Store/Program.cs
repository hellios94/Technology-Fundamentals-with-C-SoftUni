using System;

namespace Gaming_Store
{
    class Program
    {
        static void Main(string[] args)
        {
            double balance = double.Parse(Console.ReadLine());

            string game = Console.ReadLine();

            double spent = balance;

            while(game != "Game Time")
            {
                balance = BuingGame(game, balance);

                if(balance == 0)
                {
                    Console.WriteLine("Out of money!");
                    break;
                }

                game = Console.ReadLine();
            }

            if(balance > 0)
            {

                spent -= balance;
                Console.WriteLine($"Total spent: ${String.Format("{0:F2}", spent)}. Remaining: ${String.Format("{0:F2}", balance)}");
            }
        }


        public static double BuingGame(string name, double balance)
        {
            switch (name)
            {
                case "OutFall 4":
                    {
                        if (balance - 39.99 >= 0)
                        {
                            balance -= 39.99;
                            Console.WriteLine($"Bought {name}");
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive");
                        }

                        break;
                    }
                case "CS: OG":
                    {
                        if (balance - 15.99 >= 0)
                        {
                            balance -= 15.99;
                            Console.WriteLine($"Bought {name}");
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive");
                        }

                        break;
                    }
                case "Zplinter Zell":
                    {
                        if (balance - 19.99 >= 0)
                        {
                            balance -= 19.99;
                            Console.WriteLine($"Bought {name}");
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive");
                        }

                        break;
                    }
                case "Honored 2":
                    {
                        if (balance - 59.99 >= 0)
                        {
                            balance -= 59.99;
                            Console.WriteLine($"Bought {name}");
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive");
                        }

                        break;
                    }
                case "RoverWatch":
                    {
                        if (balance - 29.99 >= 0)
                        {
                            balance -= 29.99;
                            Console.WriteLine($"Bought {name}");
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive");
                        }

                        break;
                    }
                case "RoverWatch Origins Edition":
                    {
                        if (balance - 39.99 >= 0)
                        {
                            balance -= 39.99;
                            Console.WriteLine($"Bought {name}");
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive");
                        }

                        break;
                    }
                default:
                    {
                        Console.WriteLine("Not Found");

                        break;
                    }
            }

            return balance;
        }
    }
}
