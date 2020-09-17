using System;

namespace Cruise_games
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int gamesCount = int.Parse(Console.ReadLine());

            double volleyballPoints = 0;
            int volleyballCounter = 0;

           double tennisPoints = 0;
            int tennisCounter = 0;

            double badmintonPoints = 0;
            int badmintonCounter = 0;

            for (int currentGame = 1; currentGame <= gamesCount; currentGame++)
            {
                string gameName = Console.ReadLine();
                double gamePoints = int.Parse(Console.ReadLine());
                
                if (gameName == "volleyball")
                {
                    gamePoints *= 1.07; //повишаване с 7%
                    volleyballPoints += gamePoints;
                    volleyballCounter++;
                }
                else if (gameName == "tennis")
                {
                    gamePoints *= 1.05; //повишаване с 5%
                    tennisPoints += gamePoints;
                    tennisCounter++;
                }
                else if (true)
                {
                    gamePoints *= 1.02; //повишаване с 2%
                    badmintonPoints += gamePoints;
                    badmintonCounter++;
                }
            }
            double totalPoints = volleyballPoints + tennisPoints + badmintonPoints;

            double averageVolleyball = volleyballPoints / volleyballCounter;
            double averageTennis = tennisPoints / tennisCounter;
            double averageBadminton = badmintonPoints / badmintonCounter;

            if (averageVolleyball >= 75 && averageTennis >= 75 && averageBadminton >= 75)
            {
                Console.WriteLine($"Congratulations, {name}! You won the cruise games with {Math.Floor(totalPoints)} points.");
            }
            else
            {

                Console.WriteLine($"Sorry, {name}, you lost. Your points are only {Math.Floor(totalPoints)}.");
            }


        }
    }
}
