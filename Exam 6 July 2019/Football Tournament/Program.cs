using System;

namespace Football_Tournament
{
    class Program
    {
        static void Main(string[] args)
        {
            string team = Console.ReadLine();
            int games = int.Parse(Console.ReadLine());
            int points = 0;
            int win = 0;
            int loss = 0;
            int drawn = 0;

            if (games == 0 )
            {
                Console.WriteLine($"{team} hasn't played any games during this season.");
                return;
            } 

            for (int i = 1; i <= games; i++)
            {
                char result = char.Parse(Console.ReadLine());
                

                if (result == 'W')
                {
                    win++;
                    points += 3;
                }
                else if (result == 'D')
                {
                    drawn++;
                    points += 1;
                }
                else if (result== 'L')
                {
                    loss++;
                    
                }
            }
            Console.WriteLine($"{team} has won {points} points during this season.");
            Console.WriteLine("Total stats:");
            Console.WriteLine($"## W: {win}");
            Console.WriteLine($"## D: {drawn}");
            Console.WriteLine($"## L: {loss}");
            Console.WriteLine($"Win rate: {((double)win/games*100):f2}%");
        }
    }
}
