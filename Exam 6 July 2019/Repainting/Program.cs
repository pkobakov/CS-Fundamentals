using System;

namespace Repainting
{
    class Program
    {
        static void Main(string[] args)
        {
            int nailon = int.Parse(Console.ReadLine());
            int paint = int.Parse(Console.ReadLine());
            int detergent = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());

            double nailonsum = (nailon+2) * 1.50;
            double tenpercentpaint = paint * 0.10;
            double paintsum = (paint+tenpercentpaint) * 14.50;
            double detergentsum = detergent * 5.00;
            double bags = 0.40;
            double sumMaterials = nailonsum + paintsum + detergentsum+bags;

            double workers= hours * (sumMaterials*0.30);
            double total = sumMaterials + workers;

            Console.WriteLine($"Total expenses: {total:f2} lv.");
        }
    }
}
