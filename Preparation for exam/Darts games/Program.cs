using System;

namespace Darts_games
{
    class Program
    {
        static void Main(string[] args)
        {
            int startingPoints = int.Parse(Console.ReadLine());
            int gameCounter = 0;
            
            int currentPoints = startingPoints;
            int sumOfPoints = 0;

            while (currentPoints>0)
            {
                gameCounter++;
                string sector = Console.ReadLine();
               

                if (sector == "bullseye")
                {
                    Console.WriteLine($"Congratulations! You won the game with a bullseye in {gameCounter} moves!");
                    return;
                }

                int points = int.Parse(Console.ReadLine());

                if (sector == "number section")
                {
                     currentPoints -= points;
                }
                else if (sector == "double ring")
                {
                    currentPoints -= points * 2;
                }
                else if (sector == "triple ring")
                {
                    currentPoints -= points * 3;
                }
                if (currentPoints == 0)
                {
                    Console.WriteLine($"Congratulations! You won the game in {gameCounter} moves!");
                }
                else if (currentPoints<0)
                {
                    Console.WriteLine($"Sorry, you lost. Score difference: {Math.Abs(currentPoints)}.");
                }
            }
            
           
        }
    }
}
