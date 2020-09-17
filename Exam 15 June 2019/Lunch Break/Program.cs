using System;

namespace Lunch_Break
{
    class Program
    {
        static void Main(string[] args)
        {
            string serial = Console.ReadLine();
            int serialtiming = int.Parse(Console.ReadLine());
            int breaktiming = int.Parse(Console.ReadLine());

            double timeforlunch = (double)breaktiming * 1 / 8;
            double timeforrest = (double)breaktiming * 1 / 4;
            double remainingtime = breaktiming - timeforlunch - timeforrest;
            if (remainingtime>=serialtiming)
            {
                double disposaltime = remainingtime - serialtiming;
                Console.WriteLine($"You have enough time to watch {serial} and left with {Math.Ceiling(disposaltime)} minutes free time.");
            }
            else
            {
                double neededtime = serialtiming - remainingtime;
                Console.WriteLine($"You don't have enough time to watch {serial}, you need {Math.Ceiling(neededtime)} more minutes.");
            }
        }

    }
}