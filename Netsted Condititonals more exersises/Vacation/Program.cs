using System;

namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string destination = "";
            string accommodation = "";
            double price = 0;

            if (budget <= 1000)
            {
                accommodation = "Camp";

                switch (season)
                {
                    case "Summer":destination = "Alaska"; price = budget * 0.65;break;
                    case "Winter":destination = "Morocco"; price = budget * 0.45;break;
                }
            }
            else if (budget>1000 && budget<=3000)
            {
                accommodation = "Hut";
                switch (season)
                {
                    case "Summer": destination = "Alaska"; price = budget * 0.80; break;
                    case "Winter": destination = "Morocco"; price = budget * 0.60; break;
                }
            }
            else if (budget > 3000)
            {
                accommodation = "Hotel";
                switch (season)
                {
                    case "Summer": destination = "Alaska"; price = budget * 0.90; break;
                    case "Winter": destination = "Morocco"; price = budget * 0.90; break;
                }
            }
            Console.WriteLine($"{destination} - {accommodation} - {price:f2}");
        }
    }
}
