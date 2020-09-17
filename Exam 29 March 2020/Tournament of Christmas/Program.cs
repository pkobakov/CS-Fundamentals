using System;

namespace Tournament_of_Christmas
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int win = 0;
            int loss = 0;
            double donations = 0;

            for (int currentDay = 1; currentDay <= days; currentDay++)
            {
                string sport = Console.ReadLine();
                int dayWins = 0;
                int dayLosses = 0;
                double dayDonations = 0;
                while (sport != "Finish")
                {
                    string result = Console.ReadLine();

                    if (result == "win")
                    {
                        dayWins++;
                        win++;
                        dayDonations += 20;
                    }
                    else if (result == "lose")
                    {
                        dayLosses++;
                        loss++;
                    }
                    sport = Console.ReadLine();
                }
                if (sport == "Finish")
                {
                    if (dayWins> dayLosses)
                    {
                        dayDonations += dayDonations * 0.10;
                        donations += dayDonations;
                    }
                    else
                    {
                        donations += dayDonations;
                    }
                }
            }
            if (win>loss)
            {
                donations += donations * 0.20;
                Console.WriteLine($"You won the tournament! Total raised money: {donations:f2}");
            }
            else if (win<loss)
            {
                Console.WriteLine($"You lost the tournament! Total raised money: {donations:f2}");
            }
        }
    }
}
