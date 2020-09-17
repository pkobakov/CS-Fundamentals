using System;

namespace Basketball_Tournament
{
    class Program
    {
        static void Main(string[] args)
        {
            string tournament = Console.ReadLine();
            
            int win = 0;
            int lost = 0;

            while (tournament != "End of tournaments")
            {
                
                int games = int.Parse(Console.ReadLine());

                for (int game = 1; game <= games; game++)
                {
                    int team1 = int.Parse(Console.ReadLine());
                    int team2 = int.Parse(Console.ReadLine());
                    if (team1>team2)
                    {
                        win++;
                        int winpoints = team1 - team2;
                        Console.WriteLine($"Game {game} of tournament {tournament}: win with {winpoints} points.");
                    }
                    else if (team1<team2)
                    {
                        lost++;
                        int lostpoints = team2 - team1;
                        Console.WriteLine($"Game {game} of tournament {tournament}: lost with {lostpoints} points.");

                    }
                }
                tournament = Console.ReadLine();
            }
            double gamesCount = lost + win;
            double percntwins = (win / gamesCount) * 100;
            double percentlosts = (lost / gamesCount) * 100;

            Console.WriteLine($"{percntwins:F2}% matches win");
            Console.WriteLine($"{percentlosts:F2}% matches lost");
        }
    }
}
