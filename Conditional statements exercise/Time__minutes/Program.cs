using System;

namespace Time__minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int startHours = int.Parse(Console.ReadLine());
            int startMinutes = int.Parse(Console.ReadLine());
            int timeInMin = startHours * 60 + startMinutes;
            int timePlus15 = timeInMin + 15;
            int finalHours = timePlus15 / 60;
            int finalMin = timePlus15 % 60;
            if (finalHours >= 24)
            {
                finalHours = finalHours - 24;
            }
            if (finalMin < 10)
            {
                Console.WriteLine($"{finalHours}:0{finalMin}");
            }
            else
            {
                Console.WriteLine($"{finalHours}:{finalMin}");
            }
        }
    }
}