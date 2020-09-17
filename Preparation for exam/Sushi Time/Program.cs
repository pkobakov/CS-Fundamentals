using System;

namespace Sushi_Time
{
    class Program
    {
        static void Main(string[] args)
        {
            string sushiType = Console.ReadLine();
            string restorant = Console.ReadLine();
            double portions = double.Parse(Console.ReadLine());
            char symbol = char.Parse(Console.ReadLine());

            double orderPrice = 0;
            if (restorant == "Sushi Zone")
            {
                switch (sushiType)
                {
                    case "sashimi": orderPrice = portions * 4.99; break;
                    case "maki": orderPrice = portions * 5.29; break;
                    case "uramaki": orderPrice = portions * 5.99; break;
                    case "temaki": orderPrice = portions * 4.29; break;
                }
            }
            else if (restorant == "Sushi Time")
            {
                switch (sushiType)
                {
                    case "sashimi": orderPrice = portions * 5.49; break;
                    case "maki": orderPrice = portions * 4.69; break;
                    case "uramaki": orderPrice = portions * 4.49; break;
                    case "temaki": orderPrice = portions * 5.19; break;
                }
            }
            else if (restorant == "Sushi Bar")
            {
                switch (sushiType)
                {
                    case "sashimi": orderPrice = portions * 5.25; break;
                    case "maki": orderPrice = portions * 5.55; break;
                    case "uramaki": orderPrice = portions * 6.25; break;
                    case "temaki": orderPrice = portions * 4.75; break;
                }
            }
            else if (restorant == "Asian Pub")
            {
                switch (sushiType)
                {
                    case "sashimi": orderPrice = portions * 4.50; break;
                    case "maki": orderPrice = portions * 4.80; break;
                    case "uramaki": orderPrice = portions * 5.50; break;
                    case "temaki": orderPrice = portions * 5.50; break;
                }
            }
            else
            {
                Console.WriteLine($"{restorant} is invalid restaurant!");
                return;
            }
            if (symbol == 'Y')
            {
                double totalOrderPrice = orderPrice + (orderPrice * 0.2);

                Console.WriteLine($"Total price: { Math.Ceiling(totalOrderPrice)} lv.");
            }
            else
            {
                Console.WriteLine($"Total price: { Math.Ceiling(orderPrice)} lv.");
            }
            
        }
    }
}
