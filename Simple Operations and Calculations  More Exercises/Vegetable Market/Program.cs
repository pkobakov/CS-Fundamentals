using System;

namespace Vegetable_Market
{
    class Program
    {
        static void Main(string[] args)
        {
             double priceVegs = double.Parse(Console.ReadLine());
             double priceFruits = double.Parse(Console.ReadLine());
             int kgVegs = int.Parse(Console.ReadLine());
             int kgFruits = int.Parse(Console.ReadLine());

            double totalVegs = priceVegs * kgVegs;
            double totalFruits = priceFruits * kgFruits;
            double totalBGN = totalVegs + totalFruits;
            double totalEUR = totalBGN / 1.94;

            Console.WriteLine($"{totalEUR:f2}");


        }
    }
}
