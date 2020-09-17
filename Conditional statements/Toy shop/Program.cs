using System;

namespace Toy_shop
{
    class Program
    {
        static void Main(string[] args)
        {
           double excursionPrice = double.Parse(Console.ReadLine());
            int puzzles = int.Parse(Console.ReadLine());
            int dolls = int.Parse(Console.ReadLine());
            int bears = int.Parse(Console.ReadLine());
            int minions = int.Parse(Console.ReadLine());
            int trucks = int.Parse(Console.ReadLine());

            double earnedMoneyBefDisc = puzzles * 2.60 + dolls * 3 + bears * 4.10 + minions * 8.20 + trucks * 2;
            int numberToys = puzzles + dolls + bears + minions + trucks;
            double moneyAfterFirstDisc = earnedMoneyBefDisc;
            if (numberToys >= 50)
            {
                moneyAfterFirstDisc = earnedMoneyBefDisc * 0.75;

            }

            double moneyAfterRent = moneyAfterFirstDisc * 0.9;

            if (moneyAfterRent >= excursionPrice)
            {

                Console.WriteLine($"Yes! {moneyAfterRent - excursionPrice:f2} lv left. ");
            }
            else
            {
                Console.WriteLine($"Not enough money! {excursionPrice - moneyAfterRent:f2} lv needed.");
            }
        }




    }
}
