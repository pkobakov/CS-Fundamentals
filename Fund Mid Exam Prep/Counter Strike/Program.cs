using System;
using System.Runtime.CompilerServices;

namespace Counter_Strike
{
    class Program
    {
        static void Main(string[] args)
        {
            int initialEnergy = int.Parse(Console.ReadLine());
            int win = 0;
            string input = Console.ReadLine();
            while (input != "End of battle" || initialEnergy <= 0)
            {
                int distance = int.Parse(input);
                if (initialEnergy>=distance)
                {
                    initialEnergy -= distance;
                    win++;
                    if ((win%3)==0)
                    {
                        initialEnergy += win;
                    }
                }
                else
                {
                    Console.WriteLine($"Not enough energy! Game ends with {win} won battles and { initialEnergy} energy");
                    return;
                }
                input = Console.ReadLine();
            }

            Console.WriteLine($"Won battles: {win}. Energy left: {initialEnergy}");
        }
    }
}
