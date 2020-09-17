using System;

namespace Mountain_Run
{
    class Program
    {
        static void Main(string[] args)
        {
            double record = double.Parse(Console.ReadLine());
            int distance = int.Parse(Console.ReadLine());
            double secondspermetre= double.Parse(Console.ReadLine());

            double time1 = distance * secondspermetre;
            double realdistance = Math.Floor((double)distance / 50);
            double time2 =  realdistance * 30;
            double totaltime = time1 + time2;
            if (totaltime>=record)
            {
                Console.WriteLine($"No! He was {totaltime-record:f2} seconds slower.");
            }
            else
            {
                Console.WriteLine($"Yes! The new record is {totaltime:f2} seconds.");
            }
        }
    }
}
