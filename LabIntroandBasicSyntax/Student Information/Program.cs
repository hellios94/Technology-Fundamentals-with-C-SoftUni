﻿using System;

namespace Student_Information
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();

            int age = int.Parse(Console.ReadLine());

            double grade = double.Parse(Console.ReadLine());


            Console.WriteLine($"Name: {name}, Age: {age}, Grade: {String.Format("{0:F2}", grade)}");
        }
    }
}
