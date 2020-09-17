using System;

namespace Football_results_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int win = 0;
            int loss = 0;
            int drawn = 0;
            
            for (int game = 1; game <= 3; game++)
            {
                string result = Console.ReadLine();
                char score1 = result[0];
                char score2 = result[2];
                if (score1 > score2)
                {
                    win++;
                }
                else if (score1 < score2)
                {
                    loss++;
                }
                else if (score1 == score2)
                {
                    drawn++;
                
                }       
            }
            Console.WriteLine($"Team won {win} games.");
            Console.WriteLine($"Team lost {loss} games.");
            Console.WriteLine($"Drawn games: {drawn}");
            
        }
    }
}
