using System;

namespace National_Court
{
    class Program
    {
        static void Main(string[] args)
        {
           byte efficiensy1 = byte.Parse(Console.ReadLine());
           byte efficiensy2 = byte.Parse(Console.ReadLine());
           byte efficiensy3 = byte.Parse(Console.ReadLine());
           int  peopleCount = int.Parse(Console.ReadLine());

            int totalEfficiensy = (int)(efficiensy1+efficiensy2+efficiensy3);
            int hours = 0;

            while (peopleCount>0)
            {
                peopleCount -= totalEfficiensy;
                hours++;
                if ((hours%4)==0)
                {
                    hours++;
                }

            }

            Console.WriteLine($"Time needed: {hours}h.");

        }
    }
}
