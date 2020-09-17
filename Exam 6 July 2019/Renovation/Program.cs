using System;

namespace Renovation
{
    class Program
    {
        static void Main(string[] args)
        {
            int lenght = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int volume = lenght * width * 4;
            int percent = int.Parse(Console.ReadLine());
            double walls = Math.Ceiling((double)volume -(volume*percent/100));
          
            double sum = walls;
            string command = Console.ReadLine();

            while (command != "Tired!")
            {
                int litres = int.Parse(command);
                sum -= litres;

                if (sum < 0)
                {
                        Console.WriteLine($"All walls are painted and you have {Math.Abs(sum)} l paint left!");
                    return;
                }
                else if (sum == 0)
                {
                    Console.WriteLine($"All walls are painted! Great job, Pesho!");
                    return;
                }
                
                command = Console.ReadLine();
            }
            Console.WriteLine($"{sum} quadratic m left.");
        }
    }
}
