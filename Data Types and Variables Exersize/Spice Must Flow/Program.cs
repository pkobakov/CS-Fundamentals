using System;

namespace Spice_Must_Flow
{
    class Program
    {
        static void Main(string[] args)
        {
            int startingYield = int.Parse(Console.ReadLine());
            int day = 0;
            
            int consumption = 26;
            int leaving = 0;
            if (startingYield<100)
            {
                Console.WriteLine(day);
                Console.WriteLine(leaving);
                return;
            }
            while (startingYield >=100)
            {
                int yield = startingYield;
                yield -= consumption;
                leaving += yield;
                startingYield -= 10;
                day++;

            }
            leaving -= consumption;
            Console.WriteLine(day);
            Console.WriteLine(leaving);
        }
    }
}
