using System;

namespace New_House
{
    class Program
    {
        static void Main(string[] args)
        {
            string flower = Console.ReadLine();
            double flowersNum = double.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());
           
            double flowersSum = 0.0;
            double discount = 0.0;

            if (flower == "Roses")
            {
                flowersSum = flowersNum * 5.00;

                if (flowersNum > 80)
                {
                    discount = 0.1;
                    flowersSum = flowersSum - (flowersSum * discount);
                }

            }
            else if (flower == "Dahlias")
            {
                flowersSum = flowersNum * 3.80;
                if (flowersNum > 90)
                {
                    discount = 0.15;
                    flowersSum = flowersSum - (flowersSum * discount);
                }
            }
            else if (flower == "Tulips")
            {
                flowersSum = flowersNum * 2.80;
                if (flowersNum > 80)
                {
                    discount = 0.15;
                   flowersSum = flowersSum - (flowersSum * discount);
                }

            }
            else if (flower == "Narcissus")
            {
                flowersSum = flowersNum * 3.00;
                if (flowersNum < 120)
                {
                    discount = 0.15;
                    flowersSum = flowersSum + (flowersSum * discount);
                }

            }
            else if (flower == "Gladiolus")
            {
                flowersSum = flowersNum * 2.50;
                if (flowersNum < 80)
                {
                    discount = 0.20;
                    flowersSum = flowersSum + (flowersSum * discount);
                }
            }
            if (flowersSum <= budget)
            {
                Console.WriteLine($"Hey, you have a great garden with {flowersNum} {flower} and {budget - flowersSum:f2} leva left.");
            }
            else
            {

                Console.WriteLine($"Not enough money, you need {flowersSum - budget:f2} leva more.");
            }
        }

    }
}
