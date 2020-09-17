using System;

namespace P06_TripExpenses
{
    class P06_TripExpenses
    {
        static void Main(string[] args)
        {
            int daysOfTrip = int.Parse(Console.ReadLine());
            double moneyLeft = 0.0;
            for (int i = 0; i < daysOfTrip; i++)
            {
                double dayLimit = 60 + moneyLeft;
                moneyLeft = 0;
                string input = Console.ReadLine();
                int products = 0;
                while ("Day over" != input)
                {
                    double price = double.Parse(input);
                    if (dayLimit - price >= 0)
                    {
                        dayLimit -= price;
                        products++;
                    }
                    else
                    {
                        input = Console.ReadLine();
                        continue;
                    }
                    if (dayLimit == 0)
                    {
                        break;
                    }
                    input = Console.ReadLine();
                }
                if ("Day over" == input)
                {
                    moneyLeft = Math.Abs(moneyLeft - dayLimit);
                    Console.WriteLine($"Money left from today: {moneyLeft:F2}. You've bought {products} products.");
                }
                else
                {
                    Console.WriteLine($"Daily limit exceeded! You've bought {products} products.");
                }
            }
        }
    }
}
