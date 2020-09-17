using System;

namespace Tennis_equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double tennisRocketPrice = double.Parse(Console.ReadLine());
            int tennisRocketsCount = int.Parse(Console.ReadLine());
            int sneackers = int.Parse(Console.ReadLine());
            double totalRocketsPrice = tennisRocketsCount * tennisRocketPrice;
            double sneackersPrice = tennisRocketPrice / 6;
            double totalSneackersPrice = sneackers * sneackersPrice;
            double restEquipmentPrice = (totalRocketsPrice+totalSneackersPrice)*0.2;

            double totalPriceBeforeDiscount = totalRocketsPrice + totalSneackersPrice + restEquipmentPrice;

            double DjokoPrice = totalPriceBeforeDiscount / 8;
            double sponsorsPrice = totalPriceBeforeDiscount * 7 / 8;

            Console.WriteLine($"Price to be paid by Djokovic {Math.Floor(DjokoPrice)}");
            Console.WriteLine($"Price to be paid by sponsors {Math.Ceiling(sponsorsPrice)}");

        }
    }
}
