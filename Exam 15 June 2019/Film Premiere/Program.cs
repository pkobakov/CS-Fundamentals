using System;

namespace Film_Premiere
{
    class Program
    {
        static void Main(string[] args)
        {
            string movie = Console.ReadLine();
            string menu = Console.ReadLine();
            double tickets = double.Parse(Console.ReadLine());
            double bill = 0;

            if (movie == "John Wick")
            {
                switch (menu)
                {
                    case "Drink": bill = tickets * 12; break;
                    case "Popcorn": bill = tickets * 15; break;
                    case "Menu": bill = tickets * 19; break;

                }
            }
            else if (movie == "Star Wars")
            {
                switch (menu)
                {
                    case "Drink": bill = tickets * 18; break;
                    case "Popcorn": bill = tickets * 25; break;
                    case "Menu": bill = tickets * 30; break;
                }
                if (tickets >= 4)
                {
                    bill -= bill * 0.3;
                }
            }
            else if (movie == "Jumanji")
            {
                switch (menu)
                {
                    case "Drink": bill = tickets * 9; break;
                    case "Popcorn": bill = tickets * 11; break;
                    case "Menu": bill = tickets * 14; break;
                }
                if (tickets == 2)
                {
                    bill -= bill * 0.15;
                }
            }
            Console.WriteLine($"Your bill is {bill:f2} leva.");
        }
    }
}
