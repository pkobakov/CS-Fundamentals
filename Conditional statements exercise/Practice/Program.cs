using System;

namespace World_swiming_record
{
    class Program
    {
        static void Main(string[] args)
        {
            double recordInSec = double.Parse(Console.ReadLine());
            double metres = double.Parse(Console.ReadLine());
            double secondsFormetre = double.Parse(Console.ReadLine());
            double time = metres * secondsFormetre;
            double additionalTime = Math.Floor(metres / 15) * 12.5;

            double totalTime = additionalTime + time;

            if (recordInSec > totalTime)
            {
                Console.WriteLine($"yes{totalTime:F2}");
            }
            else
            {
                Console.WriteLine($"No!{totalTime - recordInSec:f2}");
            }
        }   
    }
}
