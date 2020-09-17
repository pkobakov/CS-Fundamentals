using System;

namespace World_swiming_record
{
    class Program
    {
        static void Main(string[] args)
        {
            double recordTime = double.Parse(Console.ReadLine());
            double distanceInMetres = double.Parse(Console.ReadLine());
            double timeInSeconds = double.Parse(Console.ReadLine());

            double totalSeconds = distanceInMetres * timeInSeconds;
            double delaySeconds = Math.Floor(distanceInMetres / 15) * 12.5;

            double totalSecondsTime = totalSeconds+delaySeconds;

            if (totalSecondsTime <= recordTime)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {totalSecondsTime:f2} seconds.");

               
            }
            else
            {
                Console.WriteLine($"No, he failed! He was {totalSecondsTime - recordTime:F2} seconds slower.");

            }
        }
    }
}
