using System;

namespace exam3
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int lenght = int.Parse(Console.ReadLine());
            int hight = int.Parse(Console.ReadLine());

            int volume = width * lenght * hight;
            
            int compsVolume = 0;
            
            int space = 0;

            string command = Console.ReadLine();

            while (command !="Done")
            {
                int computers = int.Parse(command);

                compsVolume += computers;


                if (space <= compsVolume)
                {
                    Console.WriteLine($"No more free space! You need {compsVolume-volume} Cubic meters more.");
                }
             
                command = Console.ReadLine();

            }
            if (space > compsVolume)
            {
                Console.WriteLine($"{volume-compsVolume} Cubic meters left.");
            }


        }
    }
}
