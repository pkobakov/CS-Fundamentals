using System;

namespace Food_for_Pets
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            double totalfood = double.Parse(Console.ReadLine());
            double eatenbydog=0;
            double eatenbycat=0;
            double bisquit = 0;
            double totalfoodeaten = 0;

            for (int i = 1; i <=days; i++)
            {
                double dogfood = double.Parse(Console.ReadLine());
                double catfood = double.Parse(Console.ReadLine());
                double foodeatenperday = dogfood + catfood;
                eatenbydog += dogfood;
                eatenbycat += catfood;
                totalfoodeaten = eatenbydog+eatenbycat;

                if (i %3==0)
                {
                    bisquit += foodeatenperday * 0.10;
                }
            }
            double percenteaten = totalfoodeaten / totalfood * 100;
            double percenteatenbydog = eatenbydog/totalfoodeaten*100;
            double percenteatenbycat = eatenbycat/totalfoodeaten*100;

            Console.WriteLine($"Total eaten biscuits: {Math.Round(bisquit)}gr.");
            Console.WriteLine($"{percenteaten:f2}% of the food has been eaten.");
            Console.WriteLine($"{percenteatenbydog:f2}% eaten from the dog.");
            Console.WriteLine($"{percenteatenbycat:f2}% eaten from the cat.");
        }
    }
}
