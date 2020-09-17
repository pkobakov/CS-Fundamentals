using System;

namespace Hotel_Room
{
    class Program
    {
        static void Main(string[] args)
        {
            string mounth = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());

            
            double priceSt = 0.0;
            double priceAp = 0.0;


            if (mounth == "May" || mounth == "October")
            {
                priceSt = 50 * nights;
                priceAp = 65 * nights;

                if (nights > 7 && nights < 14 )
                {
                    priceSt = priceSt - (priceSt * 0.05);
                }
                else if (nights > 14)
                {
                    priceSt = priceSt - (priceSt * 0.30);
                    priceAp = priceAp - (priceAp * 0.10);
                }
            }
            else if (mounth == "June" || mounth == "September")
            {
                priceSt = 75.20 * nights;
                priceAp = 68.70 * nights;

                if (nights > 14)
                {
                    priceSt = priceSt - (priceSt * 0.20);
                    priceAp = priceAp - (priceAp * 0.10);
                }
            }
            else if (mounth == "July" || mounth == "August")
            {
                priceSt = 76.00 * nights;
                priceAp = 77.00 * nights;

                if (nights > 14)
                {
                    priceAp = priceAp - (priceAp * 0.10);

                }
            }
            Console.WriteLine($"Apartment: {priceAp:f2} lv.");

            Console.WriteLine($"Studio: {priceSt:f2} lv.");
        }
    }
}
