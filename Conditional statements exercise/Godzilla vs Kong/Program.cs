using System;

namespace Godzilla_vs_Kong
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int statists = int.Parse(Console.ReadLine());
            double costumePrice = double.Parse(Console.ReadLine());
            double decorPrice = budget * 0.1;
            double totalCostumePrice = statists * costumePrice;

            double costumePriceAfterDisc = 0;
            double total = costumePriceAfterDisc + decorPrice;
            if (statists > 150)
            {
                totalCostumePrice = totalCostumePrice * 0.9;
               
            }
            double totalsum = totalCostumePrice + decorPrice;

            if (budget >= totalsum)
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {budget - totalsum:f2} leva left.");

            }
            else
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {totalsum - budget:f2} leva more.");

            }

                

        }
        
    }
}
