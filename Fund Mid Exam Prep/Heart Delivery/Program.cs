using System;
using System.Linq;

namespace Heart_Delivery
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] neighborhood = Console.ReadLine().Split('@', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            string command = Console.ReadLine();
            int startIndex = 0;
            int currentIndex = startIndex;
            int sumOfhouses = 0;

            while (command!="Love!")
            {
                string[] elements = command.Split();
                string action = elements[0];
                int steps = int.Parse(elements[1]);
                currentIndex += steps;

                if (currentIndex > neighborhood.Length-1)
                {
                    currentIndex = startIndex;

                }
                
                if (neighborhood[currentIndex] <= 0)
                {
                        Console.WriteLine($"Place {currentIndex} already had Valentine's day.");                       
                }
                else
                {
                        neighborhood[currentIndex] -= 2;

                        if (neighborhood[currentIndex] <= 0)
                        {
                            Console.WriteLine($"Place {currentIndex} has Valentine's day.");
                        }
                       
                }
                command = Console.ReadLine();
            }
            Console.WriteLine($"Cupid's last position was {currentIndex}.");

            for (int i = 0; i < neighborhood.Length; i++)
            {

                if (neighborhood[i] == 0)
                {
                   sumOfhouses++;
                }
              
            }
            if (neighborhood.Length == sumOfhouses) 
            {

                Console.WriteLine("Mission successful.");
            }
           
            Console.WriteLine($"Cupid has failed {neighborhood.Length-sumOfhouses} places.");
        }
    }
}
