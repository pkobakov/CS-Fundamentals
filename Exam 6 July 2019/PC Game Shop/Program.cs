using System;

namespace PC_Game_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            int soldgames = int.Parse(Console.ReadLine());
            int Hearthstone = 0;
            int Fornite = 0;
            int Overwatch = 0;
            int Others = 0;

            for (int i = 1; i <= soldgames; i++)
            {
                string name = Console.ReadLine();
                

                if (name == "Hearthstone")
                {
                    Hearthstone++;
                }
                else if (name == "Fornite")
                {
                    Fornite++;
                }
                else if (name == "Overwatch")
                {
                    Overwatch++;
                }
                else
                {
                    Others++;
                }
            }
            Console.WriteLine($"Hearthstone - {((double)Hearthstone/soldgames*100):f2}%");
            Console.WriteLine($"Fornite - {((double)Fornite / soldgames * 100):f2}%");
            Console.WriteLine($"Overwatch - {((double)Overwatch / soldgames * 100):f2}%");
            Console.WriteLine($"Others - {((double)Others / soldgames * 100):f2}%");
        }
    }
}
