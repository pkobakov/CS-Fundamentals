using System;

namespace Baking_Competition
{
    class Program
    {
        static void Main(string[] args)
        {
            int participants = int.Parse(Console.ReadLine());

            double cookiesPrice = 1.50;
            double cakesPrice = 7.80;
            double wafflesPrice = 2.30;
            double totalSumForCharity = 0;

            
            int allBakery = 0;

            for (int i = 1; i <= participants; i++)
            {
                string name = Console.ReadLine();
                string type = Console.ReadLine();
                
                int cookies = 0;
                int cakes = 0;
                int waffles = 0;


                while (type!="Stop baking!")
                {
                    int count = int.Parse(Console.ReadLine());

                    if (type == "cookies")
                    {
                        cookies += count;
                       
                    }
                    else if (type == "cakes")
                    {
                        cakes += count;
                       
                    }
                    else if (type == "waffles")
                    {
                        waffles += count;
                        
                    }

                    type = Console.ReadLine();
                }

                allBakery += cookies + cakes + waffles;
                totalSumForCharity += (cookies * cookiesPrice) + (cakes * cakesPrice) + (waffles * wafflesPrice);
                Console.WriteLine($"{name} baked {cookies} cookies, {cakes} cakes and {waffles} waffles.");
            }
            
            Console.WriteLine($"All bakery sold: {allBakery}");
            Console.WriteLine($"Total sum for charity: {totalSumForCharity:f2} lv.");
        }
    }
}
