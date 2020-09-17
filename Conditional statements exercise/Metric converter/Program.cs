using System;

namespace Metric_converter
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            string inputMetric = Console.ReadLine();
            string outputMetric = Console.ReadLine();

            if ("mm" == inputMetric)
            {
                number = number / 1000;
            }
            else if ("cm" == inputMetric)
            {
                number = number / 100;
            }
            if ("mm" == outputMetric)
            {
                number = number * 1000;
            }
            else if ("cm" == outputMetric)
            {
                number = number * 100;
            }
            Console.WriteLine($"{number:f3}");
        }
    }
}

