using System;

namespace Journey
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string type = "";
            string destination = "";
            double percentage = 0.0;

            if (budget <= 100)
            {
                if (season == "summer")
                {
                    type = "Camp";
                    percentage = 0.3;
                    
                }
                else if (season == "winter")
                {
                    type = "Hotel";
                    percentage = 0.7;
                    
                }
            }
            else if (budget <= 1000)
            {
                if (season == "summer")
                {
                    type = "Camp";
                    percentage = 0.4;
                }
                else if (season == "winter")
                {
                    type = "Hotel";
                    percentage = 0.8;
                }
            }
            else if (budget > 1000)
            {
                type = "Hotel";
                percentage = 0.9;
            }
            double totalSum = budget * percentage;

            if (totalSum <= 100)
            {
                destination = "Bulgaria";
            }
            else if (totalSum <= 1000)
            {
                destination = "Balkans";
            }
            else
            {
                destination = "Europe";
            }
            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{type} - {totalSum:f2}");
        }
        
    }
}
