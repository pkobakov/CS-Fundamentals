using System;

namespace Energy_Booster
{
    class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine();
            string set = Console.ReadLine();
            int setCount = int.Parse(Console.ReadLine());

            double price = 0;

            if (fruit == "Watermelon")
            {
                switch (set)
                {
                    case "small": price  = 2*56;break;
                    case "big":price = 5 * 28.70; break;
                }
                price *= setCount;
            }
            else if (fruit == "Mango")
            {
                switch (set)
                {
                    case "small": price = 2 * 36.66; break;
                    case "big": price = 5 * 19.60; break;
                }
                price *= setCount;
            }
            else if (fruit == "Pineapple")
            {
                switch (set)
                {
                    case "small": price = 2 * 42.10; break;
                    case "big": price = 5 * 24.80; break;
                }
                price *= setCount;
            }
            else if (fruit == "Raspberry")
            {
                switch (set)
                {
                    case "small": price = 2 * 20; break;
                    case "big": price = 5 * 15.20; break;
                }
                price *= setCount;
            }
            if (price >=400 && price<=1000)
            {
                price *= 0.85;
            }
            else if (price>1000)
            {
                price *= 0.50;
            }
            Console.WriteLine($"{price:f2} lv.") ;

        }
    }
}
