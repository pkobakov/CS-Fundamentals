using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string cruiseType = Console.ReadLine();
            string cabinType = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());

            double finalSum = 0;
            

            if (cruiseType == "Mediterrian")
            {
                switch (cabinType)
                {
                    case "standard cabin": finalSum = 27.50 * 4 * nights; break;
                    case "cabin with balcony": finalSum = 30.20 * 4 * nights; break;
                    case "apartment": finalSum = 40.50 * 4 * nights; break;

                }
            }
            else if (cruiseType == "Adriatic")
            {
                switch (cabinType)
                {
                    case "standard cabin": finalSum = 22.99 * 4 * nights; break;
                    case "cabin with balcony": finalSum = 25.00 * 4 * nights; break;
                    case "apartment": finalSum = 34.99 * 4 * nights; break;
                }
            }
            else if (cruiseType == "Aegean")
            {
                switch (cabinType)
                {
                    case "standard cabin": finalSum = 23.00 * 4 * nights; break;
                    case "cabin with balcony": finalSum = 26.60 * 4 * nights; break;
                    case "apartment": finalSum = 39.80 * 4 * nights; break;
                }
              
            }
            if (nights > 7)
            {
                double totalSum = finalSum - (finalSum * 0.25);

                Console.WriteLine($"Annie's holiday in the {cruiseType} sea costs {totalSum:f2} lv.");
            }



        }
}   }   
