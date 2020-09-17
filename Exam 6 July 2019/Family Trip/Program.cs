using System;

namespace Family_Trip
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int nights = int.Parse(Console.ReadLine());
            double price = double.Parse(Console.ReadLine());
            int percent = int.Parse(Console.ReadLine());
            double pricepernights = nights * price;
            double additionals = budget * percent/100;
            

            if (nights>7)
            {
                pricepernights *= 0.95;
            }

            double sum = pricepernights + additionals;
            if (sum<=budget)
            {
                Console.WriteLine($"Ivanovi will be left with {(budget-sum):f2} leva after vacation.");
            }
            else
            {
                Console.WriteLine($"{(sum-budget):f2} leva needed.");
            }
           
        }
    }
}
