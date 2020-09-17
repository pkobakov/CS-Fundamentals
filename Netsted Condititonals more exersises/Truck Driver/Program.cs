using System;

namespace Truck_Driver
{
    class Program
    {
        static void Main(string[] args)
        {
            string season= Console.ReadLine();
            int km = int.Parse(Console.ReadLine());
            double sum = 0;
            // Пролет / Есен Лято Зима
            
            // 5000 < км на месец <= 10000 0.95 лв./ км 1.10 лв./ км 1.25 лв./ км
            //10000 < км на месец <= 20000    1.45 лв./ км – за който и да е сезон
          
            if (km <= 5000)
            {
                switch (season)
                {
                    case "Spring":
                    case "Autumn":sum = km * 0.75; break;
                    case "Summer":sum = km * 0.90; break;
                    case "Winter":sum = km * 1.05; break;
                }
            }
            else if (km >5000 && km <= 10000 )
            {
                switch (season)
                {
                    case "Spring":
                    case "Autumn":sum = km * 0.95 ;break;
                    case "Summer":sum = km * 1.10;break;
                    case "Winter":sum = km * 1.25; break;
                }
            }
            else if (km > 10000)
            {
                switch (season)
                {
                    case "Spring":
                    case "Autumn":
                    case "Summer":
                    case "Winter":sum = km * 1.45; break;
                }
                
            }
            sum *= 4;
            sum =sum-(sum* 0.10);

            Console.WriteLine($"{sum:f2}");
        }
    }
}
