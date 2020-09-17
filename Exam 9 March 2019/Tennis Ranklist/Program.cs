using System;

namespace Tennis_Ranklist
{
    class Program
    {
        static void Main(string[] args)
        {
            int tours = int.Parse(Console.ReadLine());
            int points = int.Parse(Console.ReadLine());
            int wins = 0;
            int winnedPoints = 0; ;
            for (int tour = 1; tour <= tours; tour++)
            {
                string round = Console.ReadLine();
                if (round == "SF")
                {
                    points += 720;
                    winnedPoints += 720;
                }
                else if (round == "F" )
                {
                    points += 1200;
                    winnedPoints += 1200;

                }
                else if (round == "W")
                {
                    points += 2000;
                    winnedPoints += 2000;
                    wins++;
                }
            }
            int averagePoints = winnedPoints / tours;
            double percent = ((double)wins / tours)*100;
            Console.WriteLine($"Final points: {points}");
            Console.WriteLine($"Average points: {averagePoints}");
            Console.WriteLine($"{percent:F2}%");

        }
        
    }
}
