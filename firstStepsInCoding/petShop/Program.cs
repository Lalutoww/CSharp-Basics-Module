﻿using System;

namespace petShop
{
    class Program
    {
        static void Main(string[] args)
        {
            int dogFood = int.Parse(Console.ReadLine());
            int catFood = int.Parse(Console.ReadLine());
            double sum = dogFood * 2.50 + catFood * 4;
            Console.WriteLine(sum + " lv.");
        }
    }
}

