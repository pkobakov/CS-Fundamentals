using System;

namespace Alcohol_Market
{
    class Program
    {
        static void Main(string[] args)
        {
            double whiskeyPrice = double.Parse(Console.ReadLine());
            double beerLittres = double.Parse(Console.ReadLine());
            double wineLittres = double.Parse(Console.ReadLine());
            double rakiaLittres = double.Parse(Console.ReadLine());
            double whiskeyLittres = double.Parse(Console.ReadLine());

            double rakiaPerLittre = whiskeyPrice/2;
            double winePerLitter = rakiaPerLittre - (0.4 * rakiaPerLittre);
            double beerPerLitter = rakiaPerLittre - (0.8 * rakiaPerLittre);

            double totalRakia = rakiaLittres * rakiaPerLittre;
            double totalWine = wineLittres * winePerLitter;
            double totalBeer = beerLittres * beerPerLitter;
            double totalWhiskey = whiskeyPrice*whiskeyLittres;

            double total =  totalRakia + totalWine + totalBeer + totalWhiskey;

            Console.WriteLine($"{total:f2}");



        }
    }
}
