using System;

namespace Shopping
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int videocards = int.Parse(Console.ReadLine());
            int processors = int.Parse(Console.ReadLine());
            int rams = int.Parse(Console.ReadLine());
            double videocardsPrice = videocards * 250;
            double processorsPrice = processors*(videocardsPrice * 0.35);
            double ramsPrice = rams*(videocardsPrice * 0.10);

            double sum = videocardsPrice+processorsPrice+ramsPrice ;

            if (videocards>processors)
            {
                sum -= sum * 0.15;
            }
            if (budget>=sum)
            {
                Console.WriteLine($"You have {(budget-sum):f2} leva left!");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {Math.Abs(sum-budget):f2} leva more!");
            }

        }
    }
}

