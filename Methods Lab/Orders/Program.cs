using System;

namespace Orders
{
    class Program
    {
        static void Main()
        {
            string product = Console.ReadLine();
            double pieces = double.Parse(Console.ReadLine());
            OrderCalculation(product,pieces);
          

        }
        static void OrderCalculation(string product, double pieces)
        {
            double sum = 0;
            switch (product)
            {
                case "coffee": sum = pieces*1.50;break;
                case "water": sum = pieces * 1.00; break;
                case "coke": sum = pieces * 1.40; break;
                case "snacks": sum = pieces * 2.00; break;
                default: break;
            }

            Console.WriteLine($"{sum:f2}");  
        }



    }
}
