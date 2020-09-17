using System;

namespace Darts
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            string zone = Console.ReadLine();
            int points = 301;
            int good = 0;
            int bad = 0;

            while (zone!="Retire" && points !=0)
            {
                int n = int.Parse(Console.ReadLine());

                if (zone == "Single")
                {
                    if (points>=n)
                    {
                        points -= n;
                        good++;
                    }
                    else
                    {
                        bad++;
                    }
                }
                else if (zone == "Double")
                {
                    if (points >= 2*n)
                    {
                        points = points - (2*n);
                        good++;
                    }
                    else 
                    {
                        bad++;
                    }
                }
                else if (zone == "Triple")
                {
                    if (points>=3*n)
                    {
                        points = points - (3*n);
                        good++;
                    }
                    else 
                    {
                        bad++;
                    }
                }
                else if (zone == "Retire")
                {
                    break;
                }
                zone = Console.ReadLine();
            }
            if (points == 0 )
            {
                Console.WriteLine($"{name} won the leg with {good} shots.");
            }
            else
            {
                Console.WriteLine($"{name} retired after {bad} unsuccessful shots.");
            }
        }
    }
}
