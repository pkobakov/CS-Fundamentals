using System;

namespace Suitcases_Load
{
    class Program
    {
        static void Main(string[] args)
        {
            double trankCapacity = double.Parse(Console.ReadLine());
            int suitcasesCounter = 0;
            string command = Console.ReadLine();

            while (command != "End" || trankCapacity > 0)
            {
                if (command == "End")
                {
                    Console.WriteLine($"Congratulations! All suitcases are loaded!");
                    break;
                }
                double suitcaseValue = double.Parse(command);
                if (suitcasesCounter !=0 && suitcasesCounter % 3 == 0)
                {
                    suitcaseValue += suitcaseValue * 0.10;
                }
                trankCapacity -= suitcaseValue;
                if (trankCapacity <= 0)
                {
                    Console.WriteLine($"No more space!");
                    break;
                }
                command = Console.ReadLine();
                suitcasesCounter++;
            }
            Console.WriteLine($"Statistic: {suitcasesCounter} suitcases loaded.");
        }
    }
}
