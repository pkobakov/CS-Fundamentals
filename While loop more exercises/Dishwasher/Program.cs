using System;

namespace Dishwasher
{
    class Program
    {
        static void Main(string[] args)
        {
            int bottlesDetergent = int.Parse(Console.ReadLine());

            string command = Console.ReadLine();
            int consumptionDishes = 0;
            int consumptionPots = 0;

            int dishes = 0;
            int pots = 0;

            int detergentLitres = bottlesDetergent * 750;
            int loading = 0;

            while (command != "End")

            {
                int washedVessels = int.Parse(command);
                loading++;

                if (loading %3 == 0)
                {
                    pots += washedVessels;
                    consumptionPots = washedVessels * 15;
                    detergentLitres -= consumptionPots;
                    
                }
                else
                {
                    dishes += washedVessels;
                    consumptionDishes = washedVessels * 5;
                    detergentLitres -= consumptionDishes;
                }
                if (detergentLitres < 0)
                {
                    Console.WriteLine($"Not enough detergent, {Math.Abs(detergentLitres)} ml. more necessary!");
                    return;
                }

                command = Console.ReadLine();

            }

            if (detergentLitres >= 0)
            {
                Console.WriteLine("Detergent was enough!");
                Console.WriteLine($"{dishes} dishes and {pots} pots were washed.");
                Console.WriteLine($"Leftover detergent {detergentLitres} ml.");
            }
            





        }
    }
}
