using System;

namespace Name_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int maxpoints = int.MinValue;
            string winner = "";

            while (name!="Stop")
            {
               int points = 0;

                for (int i = 0; i < name.Length; i++)
                {
                    int n = int.Parse(Console.ReadLine());

                    if (n == name[i])
                    {
                        points += 10;
                    }
                    else
                    {
                        points += 2;
                    }
                   
                }
                if (points >= maxpoints)
                {
                    maxpoints = points;
                    winner = name;
                }

                name = Console.ReadLine();
            }

            Console.WriteLine($"The winner is {winner} with {maxpoints} points!");

        }
    }
}
