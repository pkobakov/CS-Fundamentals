using System;

namespace Bike_race
{
    class Program
    {
        static void Main(string[] args)
        {
            double juniors = double.Parse(Console.ReadLine());
            double seniors = double.Parse(Console.ReadLine());
            string trailType = Console.ReadLine();

            double feeJuniors = 0;
            double feeSeniors = 0;
           

            if (trailType=="trail")
            {
                feeJuniors = juniors * 5.50;
                feeSeniors = seniors * 7.00;
            }
            else if (trailType=="cross-country")
            {
                feeJuniors = juniors * 8.00;
                feeSeniors = seniors * 9.50;
            }
            else if(trailType == "downhill")
            {
                feeJuniors = juniors * 12.25;
                feeSeniors = seniors * 13.75;

            }
            else if(trailType == "road")
            { 

                feeJuniors = juniors * 20;
                feeSeniors = seniors * 21.50;

            }

            double totalFee = feeJuniors + feeSeniors;

            double totalParticipants = juniors + seniors;

            if (trailType =="cross-country")
            {
                if (totalParticipants>=50)
                {
                    totalFee = totalFee - (totalFee * 0.25);
                }
                
            }

            double final = totalFee - (totalFee * 0.05);

            Console.WriteLine($"{final:f2}");
        }
    }
}
