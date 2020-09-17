using System;

namespace Series
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int series = int.Parse(Console.ReadLine());
            double sum = 0;

            for (int i = 1; i <= series; i++)
            {
                string topic = Console.ReadLine();
                double price = double.Parse(Console.ReadLine());
                

                if (topic == "Thrones")
                {
                    price -= price * 0.5;
                    sum += price;
                }
                else if (topic == "Lucifer")
                {
                    price -= price * 0.4;
                    sum += price;
                }
                else if (topic == "Protector")
                {
                    price -= price * 0.3;
                    sum += price;
                }
                else if (topic == "TotalDrama")
                {
                    price -= price * 0.2;
                    sum += price;
                }
                else if (topic == "Area")
                {
                    price -= price * 0.1;
                    sum += price;
                }
                else
                {
                    sum += price;
                }

            }
            if (budget>=sum)
            {
                Console.WriteLine($"You bought all the series and left with {(budget-sum):f2} lv.");
            }
            else if (budget<sum)
            {
                Console.WriteLine($"You need {Math.Abs(sum-budget):f2} lv. more to buy the series!");
            }
        }
    }
}
