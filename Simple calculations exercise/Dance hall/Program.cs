using System;

namespace Dance_hall
{
    class Program
    {
        static void Main(string[] args)
        {
            double L = double.Parse(Console.ReadLine());
            double W = double.Parse(Console.ReadLine());
            double A = double.Parse(Console.ReadLine());
            double areaHall = (L*100)*(W*100);
            double areaWardrope = (A*100)*( A*100);
            double areaBench = areaHall / 10;
            double freeSpace = areaHall - areaWardrope - areaBench;

            double dancers = freeSpace / (40 + 7000);
            double totalDancers = Math.Floor(dancers);
            Console.WriteLine(totalDancers);




        }
    }
}
