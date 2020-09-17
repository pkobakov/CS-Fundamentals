using System;

namespace Moving
{
    class Program
    {
        static void Main(string[] args)
        {
          
            int width = int.Parse(Console.ReadLine());
            int  lenght = int.Parse(Console.ReadLine());
            int hight = int.Parse(Console.ReadLine());

            string command = Console.ReadLine(); 

            int  volume = width * lenght * hight;
            
            int volumeComps = 0; 

            while (command != "Done")
            {
                int comps = int.Parse(command);
                volumeComps += comps;

                if (volumeComps >= volume)
                {
                    Console.WriteLine($"No more free space! You need {volumeComps - volume} Cubic meters more."); break;
                }

                command = Console.ReadLine(); 
            }
            if (volumeComps < volume)
            {
                Console.WriteLine($"{volume - volumeComps} Cubic meters left.");
            }


        }




    }
    
}
