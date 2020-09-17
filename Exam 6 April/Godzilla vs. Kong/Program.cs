using System;

namespace Godzilla_vs._Kong
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            double clothingPrice = double.Parse(Console.ReadLine());

            double decoration = budget * 0.1;
            double totalclothing = clothingPrice * n;
            if (n>150)
            {
              totalclothing =totalclothing - (totalclothing * 0.10);
                
            }

            double total = decoration + totalclothing;
            if (total>budget)
            {
               double needed = total-budget;
                Console.WriteLine($"Not enough money!");
                Console.WriteLine($"Wingard needs {needed:f2} leva more.");
            }
            else
            {
                double left = budget - total;
                Console.WriteLine($"Action!");
                Console.WriteLine($"Wingard starts filming with {left:f2} leva left.");
            }
            
        }
    }
}
я