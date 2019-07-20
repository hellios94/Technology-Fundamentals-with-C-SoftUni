using System;

namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfPeople = int.Parse(Console.ReadLine());
            string typeOfPeople = Console.ReadLine();
            string day = Console.ReadLine();
            double price = 0;
            double totalPrice = 0;

            switch(day)
            {
                case "Friday":
                    {
                        if(typeOfPeople == "Students")
                        {
                            price = 8.45;
                        }

                        else if(typeOfPeople == "Business")
                        {
                            price = 10.90;
                        }

                        else if(typeOfPeople == "Regular")
                        {
                            price = 15;
                        }

                        break;
                    }
                case "Saturday":
                    {
                        if (typeOfPeople == "Students")
                        {
                            price = 9.80;
                        }

                        else if (typeOfPeople == "Business")
                        {
                            price = 15.60;
                        }

                        else if (typeOfPeople == "Regular")
                        {
                            price = 20;
                        }

                        break;
                    }

                case "Sunday":
                    {
                        if (typeOfPeople == "Students")
                        {
                            price = 10.46;
                        }

                        else if (typeOfPeople == "Business")
                        {
                            price = 16;
                        }

                        else if (typeOfPeople == "Regular")
                        {
                            price = 22.50;
                        }

                        break;
                    }
            }

            totalPrice = numOfPeople * price;

            Console.WriteLine($"Total Price: {String.Format("{0:F2}", Discount(typeOfPeople, numOfPeople, totalPrice, price))}");
        }


        public static double Discount (string type, int numOfPeople, double totalPrice, double price)
        {
            switch(type)
            {
                case "Students":
                    {
                        if(numOfPeople >= 30)
                        {
                            totalPrice -= totalPrice * 0.15;
                        }

                        break;
                    }
                case "Business":
                    {
                        if (numOfPeople >= 100)
                        {
                            totalPrice -= price * 10;
                        }

                        break;
                    }
                case "Regular":
                    {
                        if(numOfPeople >= 10 && numOfPeople <= 20)
                        {
                            totalPrice -= totalPrice * 0.05;
                        }

                        break;
                    }
            }

            return totalPrice;
        }
    }
}
