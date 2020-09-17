using System;

namespace exam
{
    class Program
    {
        static void Main(string[] args)
        {
            int wins = 0;
            int loses = 0;
            int drawns = 0;


            for (int game = 1; game <= 3; game++)
            {
                string score = Console.ReadLine();
                int left = int.Parse(score.Split(':')[0]);
                int right = int.Parse(score.Split(':')[1]);
                if (left > right)
                {
                    wins++;
                }
                else if (left < right)
                {
                    loses++;
                }
                else if (right == left)
                {

                    drawns++;
                
                }


            }
            Console.WriteLine($"Team won {wins} games.");
            Console.WriteLine($"Team lost {loses} games.");
            Console.WriteLine($"Drawn games: {drawns}");

            

               

          

        }
    }
}
