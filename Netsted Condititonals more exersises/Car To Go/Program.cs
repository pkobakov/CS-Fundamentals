﻿using System;

namespace Car_To_Go
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string carClass = "";
            string carType = "";
            double price = 0;
            if (budget <= 100)
            {
                carClass = "Economy class";
                switch (season)
                {
                    case "Summer": carType = "Cabrio";price = budget * 0.35; break;
                    case "Winter": carType = "Jeep"; price = budget * 0.65; break;
                }
            }
            else if (budget > 100 && budget <= 500)
            {
                carClass = "Compact class";
                switch (season)
                {
                    case "Summer": carType = "Cabrio"; price = budget * 0.45; break;
                    case "Winter": carType = "Jeep"; price = budget * 0.80; break;
                }
            }
            else if (budget > 500)
            {
                carClass = "Luxury class";
                switch (season)
                {
                    case "Summer": carType = "Jeep"; price = budget * 0.90; break;
                    case "Winter": carType = "Jeep"; price = budget * 0.90; break;
                }
            }
            Console.WriteLine(carClass);
            Console.WriteLine($"{carType} - {price:f2}");
        }
    }
}
