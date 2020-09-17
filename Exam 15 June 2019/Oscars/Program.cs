using System;

namespace Oscars
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            double academypoints = double.Parse(Console.ReadLine());
            int jury = int.Parse(Console.ReadLine());
            double neededpoints = 1250.5;
            double sumpoints = 0;
            
            for (int memberofjury = 1; memberofjury <= jury; memberofjury++)
            {
                
                string nameofjury = Console.ReadLine();
                double jurypoints = double.Parse(Console.ReadLine());
                int namelengh = nameofjury.Length;
               
                sumpoints = namelengh * jurypoints / 2;
                academypoints+=sumpoints;
               

                if (neededpoints <= academypoints)
                {
                    Console.WriteLine($"Congratulations, {name} got a nominee for leading role with {academypoints:f1}!");
                    return;
                }
                
            }
            Console.WriteLine($"Sorry, {name} you need {(neededpoints - academypoints):f1} more!");
        }
    }
}
