using System;

namespace Flowers
{
    class Program
    {
        static void Main(string[] args)
        {
            int hrisantems = int.Parse(Console.ReadLine());
            int roses = int.Parse(Console.ReadLine());
            int tulips = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            char holiday = char.Parse(Console.ReadLine());

            double totalHrisantems = 0;
            double totalRoses = 0;
            double totalTulips = 0;
            double totalFlowersPrice = 0;

            if (season == "Spring" || season == "Summer")
            {
                totalHrisantems = 2.00 * hrisantems;
                totalRoses = 4.10 * roses;
                totalTulips = 2.50 * tulips;

                totalFlowersPrice = totalRoses + totalHrisantems + totalTulips;
            }
            else if (season == "Autumn" || season == "Winter")
            {
                totalHrisantems = 3.75 * hrisantems;
                totalRoses = 4.50 * roses;
                totalTulips = 4.15 * tulips;
                totalFlowersPrice = totalRoses + totalHrisantems + totalTulips;
            }

            if (holiday == 'Y')
            {
                totalHrisantems = totalHrisantems + (totalHrisantems * 0.15);
                totalRoses = totalRoses + (totalRoses * 0.15);
                totalTulips = totalTulips + (totalTulips * 0.15);

                totalFlowersPrice = totalRoses + totalHrisantems + totalTulips;

            }

            if (season == "Spring" && tulips > 7)
            {
                totalFlowersPrice = totalFlowersPrice - (totalFlowersPrice * 0.05);
            }
            else if (season == "Winter" && roses >= 10)
            {
                totalFlowersPrice = totalFlowersPrice - (totalFlowersPrice * 0.10);
            }

            int totalFlowers = hrisantems + roses + tulips;

            if (totalFlowers>20)
            {
                totalFlowersPrice = totalFlowersPrice - (totalFlowersPrice * 0.20);
            }

            totalFlowersPrice += 2;

            Console.WriteLine($"{totalFlowersPrice:f2}");

        }
    }
}
