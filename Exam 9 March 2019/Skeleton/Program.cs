using System;

namespace Skeleton
{
    class Program
    {
        static void Main(string[] args)
        {
            double min =         double.Parse(Console.ReadLine());
            double sec =         double.Parse(Console.ReadLine());
            double lengh =       double.Parse(Console.ReadLine());
            double secsPer100m = double.Parse(Console.ReadLine());

            double minInSecs = min * 60;
            double totalSecs = minInSecs + sec;
            double timeDecrease = lengh / 120;
            double realTime = timeDecrease*2.5;
            double MarinTime = (lengh / 100) * secsPer100m - realTime;

            

            if (MarinTime<=totalSecs)
            {
                Console.WriteLine("Marin Bangiev won an Olympic quota!");
                Console.WriteLine($"His time is {MarinTime:F3}.");
            }
            else
            {
                Console.WriteLine($"No, Marin failed! He was {Math.Abs(MarinTime-totalSecs):f3} second slower.");
            }

           





        }
    }
}
