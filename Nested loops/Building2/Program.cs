using System;

namespace Building2
{
    class Program
    {
        static void Main(string[] args)
        {
            int floor = int.Parse(Console.ReadLine());
            int rooms = int.Parse(Console.ReadLine());

            for (int i = floor; i >= 1; i--)
            {
                for (int j = 0; j < rooms; j++)
                {
                    if (floor == i)
                    {
                        Console.Write($"L{i}{j} ");
                    }
                    else if (floor % 2 == 0)
                    {
                        Console.Write($"O{i}{j} ");
                    }
                    else if (floor % 2 != 0 && floor != i)
                    {
                        Console.Write($"A{i}{j} ");
                    }
                }
                Console.WriteLine();
            }
        }

    }
}
