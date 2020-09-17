using System;

namespace Fitness_Center
{
    class Program
    {
        static void Main(string[] args)
        {
            int clients = int.Parse(Console.ReadLine());
            int backs = 0;
            int legs = 0;
            int chest = 0;
            int abs = 0;
            int shakes = 0;
            int bars = 0;
            int workout = 0;
            int protein = 0;


            for (int client = 1; client <= clients; client++)
            {
                string activity = Console.ReadLine();

                if (activity == "Back")
                {
                    backs++;
                    workout++;
                }
                else if (activity == "Legs")
                {
                    legs++;
                    workout++;
                }
                else if (activity == "Chest")
                {
                    chest++;
                    workout++;
                }
                else if (activity == "Abs")
                {
                    abs++;
                    workout++;
                }
                else if (activity == "Protein shake")
                {
                    shakes++;
                    protein++;
                }
                else if (activity == "Protein bar")
                {
                    bars++;
                    protein++;
                }
            }
            Console.WriteLine($"{backs} - back");
            Console.WriteLine($"{chest} - chest");
            Console.WriteLine($"{legs} - legs");
            Console.WriteLine($"{abs} - abs");
            Console.WriteLine($"{shakes} - protein shake");
            Console.WriteLine($"{bars} - protein bar");
            double percentworkout = ((double)workout / clients) * 100;
            double percentprotein = ((double)protein / clients) * 100;
            Console.WriteLine($"{percentworkout:f2}% - work out");
            Console.WriteLine($"{percentprotein:f2}% - protein");
        }
    }
}