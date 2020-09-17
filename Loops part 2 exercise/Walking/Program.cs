using System;

namespace Walking
{
    class Program
    {
        static void Main(string[] args)
        {

            string comand = Console.ReadLine();
            int sum = 0;

            while (comand != "Going home")
            {
                int steps = int.Parse(comand);
                sum += steps;
                if (sum < 10000)
                {

                }
                if(sum >= 10000)
                {
                    Console.WriteLine("Goal reached! Good job!");break;
                }
                comand = Console.ReadLine();
            }
            if (comand == "Going home")
            {
                comand = Console.ReadLine();
                int steps = int.Parse(comand);
                sum += steps;

                if (sum < 10000)
                {
                    Console.WriteLine($"{10000 - sum} more steps to reach goal.");
                }
                else if (sum >= 10000)
                {
                    Console.WriteLine("Goal reached! Good job!");
                }
            }
            
        }

    }
}
