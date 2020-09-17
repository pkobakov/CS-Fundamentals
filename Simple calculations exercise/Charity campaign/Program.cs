using System;

namespace Charity_campaign
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int staff = int.Parse(Console.ReadLine());
            int cakes = int.Parse(Console.ReadLine());
            int goff = int.Parse(Console.ReadLine());
            int panCakes = int.Parse(Console.ReadLine());

            double incCakes = 45 * cakes;
            double incGoff = 5.80 * goff;
            double incPan = 3.20 * panCakes;

            double incPerDay = (incCakes + incGoff + incPan)*staff;
            double totalInc = incPerDay * days;
            double diff = totalInc/8;

            double expenses = totalInc - diff;

            Console.WriteLine($"{ expenses:f2}");

        }
    }
}
