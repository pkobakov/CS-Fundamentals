using System;

namespace Series_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string serial = Console.ReadLine();
            int seasons = int.Parse(Console.ReadLine());
            int series = int.Parse(Console.ReadLine());
            double cleartiming = double.Parse(Console.ReadLine());

            double adverttiming = cleartiming * 0.20;
            double totaltiming = adverttiming + cleartiming;
            double addedtiming = seasons * 10;

            double fulltiming = totaltiming * series * seasons + addedtiming;

            Console.WriteLine($"Total time needed to watch the {serial} series is {Math.Floor(fulltiming)} minutes.");


        }

    }
}
