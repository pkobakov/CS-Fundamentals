using System;

namespace Walking2
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            int sum = 0;

            while (command != "Going home")
            {
                int steps = int.Parse(command);
                sum += steps;
                if (sum < 10000)
                {

                }
                if (sum >= 10000)
                {
                    Console.WriteLine("Goal reached! Good job!");
                }

                command = Console.ReadLine();
            }
            if (command == "Going home")
            {
                int steps = int.Parse(command);
                sum += steps;

                if (sum < 10000)
                {
                    Console.WriteLine($"{10000 - sum} more steps to reach goal.");

                }
                else if (sum >= 10000)
                {
                    Console.WriteLine("Goal reached! Good job!");
                    
                }
        }   }
    }
}
