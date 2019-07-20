using System;

namespace Vending_Machine
{
    class Program
    {
        static void Main(string[] args)
        {
            string money = Console.ReadLine();

            double allMoney = 0;

            while(money != "Start")
            {
                allMoney += CheckCoins(money);

                money = Console.ReadLine();
            }

            string products = Console.ReadLine();

            while(products != "End")
            {
                double price = GetPrice(products);

                if (price != 0 && allMoney - price >= 0)
                {
                    allMoney -= price;
                    Console.WriteLine($"Purchased {products.ToLower()}");
                }
                else if (price != 0 && allMoney - price < 0)
                {
                    Console.WriteLine("Sorry, not enough money");
                }

                products = Console.ReadLine();
            }

            Console.WriteLine($"Change: {String.Format("{0:F2}", allMoney)}");
        }

        public static double GetPrice(string product)
        {
            double price = 0;

            switch(product)
            {
                case "Nuts":
                    {
                        price = 2.0;

                        break;
                    }
                case "Water":
                    {
                        price = 0.7;

                        break;
                    }
                case "Crisps":
                    {
                        price = 1.5;

                        break;
                    }
                case "Soda":
                    {
                        price = 0.8;

                        break;
                    }
                case "Coke":
                    {
                        price = 1.0;

                        break;
                    }
                default:
                    {
                        Console.WriteLine("Invalid product");

                        break;
                    }
            }

            return price;
        }


        public static double CheckCoins (string coins)
        {
            double coin = 0;

            switch(coins)
            {
                case "0.1":
                    {
                        coin = double.Parse(coins);

                        break;
                    }
                case "0.2":
                    {
                        coin = double.Parse(coins);

                        break;
                    }
                case "0.5":
                    {
                        coin = double.Parse(coins);

                        break;
                    }
                case "1":
                    {
                        coin = double.Parse(coins);

                        break;
                    }
                case "2":
                    {
                        coin = double.Parse(coins);

                        break;
                    }
                default:
                    {
                        Console.WriteLine($"Cannot accept {coins}");

                        break;
                    }
            }

            return coin;
        }
    }
}
