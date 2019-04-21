using System;

namespace _03._Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string type = Console.ReadLine();

            string day = Console.ReadLine();

            double price = 0;

            double total = 0;

            switch (day)
            {
                case "Friday":
                    {
                        switch(type)
                        {
                            case "Students":
                                {
                                    price = 8.45;

                                    break;
                                }
                            case "Business":
                                {
                                    price = 10.90;

                                    break;
                                }
                            case "Regular":
                                {
                                    price = 15;

                                    break;
                                }
                        }

                        break;
                    }
                case "Saturday":
                    {
                        switch (type)
                        {
                            case "Students":
                                {
                                    price = 9.80;

                                    break;
                                }
                            case "Business":
                                {
                                    price = 15.60;

                                    break;
                                }
                            case "Regular":
                                {
                                    price = 20;

                                    break;
                                }
                        }

                        break;
                    }
                case "Sunday":
                    {
                        switch (type)
                        {
                            case "Students":
                                {
                                    price = 10.46;

                                    break;
                                }
                            case "Business":
                                {
                                    price = 16;

                                    break;
                                }
                            case "Regular":
                                {
                                    price = 22.50;

                                    break;
                                }
                        }

                        break;
                    }
            }

            total = n * price;

            if(type == "Students" && n >= 30)
            {
                total -= total * 0.15;
            }
            else if (type == "Business" && n >= 100)
            {
                total -= 10 * price;
            }
            else if (type == "Regular" && n >= 10 && n <= 20)
            {
                total -= total * 0.05;
            }

            Console.WriteLine($"Total price: {total}");
        }
    }
}
