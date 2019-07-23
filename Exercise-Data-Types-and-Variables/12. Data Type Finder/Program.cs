using System;

namespace _12._Data_Type_Finder
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            int num;
            double floatNum;
            bool boolean;
            char character;

            while(command != "END")
            {
                bool isInt = Int32.TryParse(command, out num);

                bool isDouble = double.TryParse(command, out floatNum);

                bool isBool = bool.TryParse(command, out boolean);

                bool isChar = char.TryParse(command, out character);

                if(isInt)
                {
                    Console.WriteLine($"{command} is integer type");
                }
                else if(isDouble)
                {
                    Console.WriteLine($"{command} is floating point type");
                }
                else if(isBool)
                {

                    Console.WriteLine($"{command} is boolean type");
                    
                }
                else if(isChar)
                {
                    Console.WriteLine($"{command} is character type");
                }
                else
                {
                    Console.WriteLine($"{command} is string type");
                }


                command = Console.ReadLine();
            }
        }
    }
}
