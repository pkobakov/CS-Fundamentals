using System;

namespace Game_Number_Wars
{
    class Program
    {
        static void Main(string[] args)
        {
            string nameA = Console.ReadLine();
            string nameB = Console.ReadLine();
            string command = Console.ReadLine();
            int totalPointsA = 0;
            int totalPointsB = 0;
            int totalPoints1 = 0;
            int totalPoints2 = 0;


            while (command != "End of game")
            {
                string command2 = Console.ReadLine();

                int cardA = int.Parse(command);
                int cardB = int.Parse(command2);

                if (cardA > cardB)
                {
                    int pointsA = cardA - cardB;
                    totalPointsA += pointsA;
                }
                else if (cardB > cardA)
                {
                    int pointsB = cardB - cardA;
                    totalPointsB += pointsB;
                }
                else if (cardA == cardB)
                {

                    command = Console.ReadLine();
                    command2 = Console.ReadLine();
                    int card1 = int.Parse(command);
                    int card2 = int.Parse(command2);

                    if (card1 > card2)
                    {
                        int points1 = card1 - card2;
                        totalPoints1 += points1;
                        Console.WriteLine($"Number wars!");
                        Console.WriteLine($"{nameA} is winner with { totalPointsA} points");
                        return;
                    }
                    else if (card2 > card1)
                    {
                        int points2 = card2 - card1;
                        totalPoints2 += points2;
                        Console.WriteLine($"Number wars!");
                        Console.WriteLine($"{nameB} is winner with {totalPointsB} points");
                        return;

                    }
                   
                }
                command = Console.ReadLine();
            }
         
            Console.WriteLine($"{nameA} has {totalPointsA} points");
            Console.WriteLine($"{nameB} has {totalPointsB} points");
        }
    }
}
