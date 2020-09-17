using System;

namespace Gymnastics
{
    class Program
    {
        static void Main(string[] args)
        {
            string country = Console.ReadLine();
            string discipline = Console.ReadLine();
            double score = 0;

            if (country == "Russia")
            {
                switch (discipline)
                {
                    case "ribbon": score = 9.100 + 9.400; break;
                    case "hoop": score = 9.300 + 9.800; break;
                    case "rope": score = 9.600 + 9.000; break;
                }
            }
            else if (country == "Bulgaria")
            {
                switch (discipline)
                {
                    case "ribbon": score = 9.600 + 9.400; break;
                    case "hoop": score = 9.550 + 9.750; break;
                    case "rope": score = 9.500 + 9.400; break;

                }
            }
            else if (country == "Italy")
            {
                switch (discipline)
                {
                    case "ribbon": score = 9.200 + 9.500; break;
                    case "hoop": score = 9.450 + 9.350; break;
                    case "rope": score = 9.700 + 9.150; break;
                }
            }

            double pointsDiff = 20 - score;
            double percentDiff = (pointsDiff / 20) * 100;

            Console.WriteLine($"The team of {country} get {score:f3} on {discipline}.");
            Console.WriteLine($"{percentDiff:f2}%");
        }
    }
}
