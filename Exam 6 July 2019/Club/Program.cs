using System;

namespace Club
{
    class Program
    {
        static void Main(string[] args)
        {
            double revenue = double.Parse(Console.ReadLine());
            string coktail = Console.ReadLine();
            double totalorder = 0;
            

            while (coktail!= "Party!")
            {
                int price = coktail.Length;
                int n = int.Parse(Console.ReadLine());

                int order = price * n;
                totalorder += order;

                if (order%2 != 0)
                {
                    totalorder -= order * 0.25;
                }
                if (revenue <= totalorder)
                {
                    Console.WriteLine($"Target acquired.");
                    Console.WriteLine($"Club income - {totalorder:f2} leva.");
                    return;
                }
               
                coktail = Console.ReadLine();
            }

            Console.WriteLine($"We need {(revenue-totalorder):f2} leva more.");
            Console.WriteLine($"Club income - {totalorder:f2} leva.");
        }
    }
}
