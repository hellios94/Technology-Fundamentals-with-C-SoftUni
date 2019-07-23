using System;

namespace _09._Spice_Must_Flow
{
    class Program
    {
        static void Main(string[] args)
        {
            int yield = int.Parse(Console.ReadLine());

            int days = 0;

            int totalamount = 0;

            while(yield >= 100)
            {
                days++;

                totalamount += CalculateTheAmountOfSpices(yield);

                yield -= 10;
            }

            if(totalamount >= 26)
            {
                totalamount -= 26;
            }

            Console.WriteLine(days);
            Console.WriteLine(totalamount);
        }


        public static int CalculateTheAmountOfSpices(int yield)
        {
            int amount = 0;

            amount = yield - 26;
           
            return amount;
        }
    }
}
