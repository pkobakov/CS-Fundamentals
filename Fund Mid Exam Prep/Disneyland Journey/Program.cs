using System;

namespace Disneyland_Journey
{
    class Program
    {
        static void Main(string[] args)
        {
            int price = int.Parse(Console.ReadLine());
            int monthsForSaving = int.Parse(Console.ReadLine());

            double monthlySavings = 0;

            for (int i = 1; i <= monthsForSaving; i++)
            {
             

                if ((i % 3) == 0)
                {
                    monthlySavings -= monthlySavings * 0.16;
               
                    
                }
                if ((i % 4) == 0)
                {
                    double bonus = monthlySavings * 0.25; 
                    monthlySavings += bonus;
                }

                monthlySavings += price * 0.25;

            }
            if (monthlySavings >= price)
            {
                double moneyForSouvenirs = monthlySavings - price;
                Console.WriteLine($"Bravo! You can go to Disneyland and you will have {(moneyForSouvenirs):f2}lv. for souvenirs.");
            }
            else
            {
                Console.WriteLine($"Sorry. You need {(price - monthlySavings):f2}lv. more.");
            }
        }
    }
}
