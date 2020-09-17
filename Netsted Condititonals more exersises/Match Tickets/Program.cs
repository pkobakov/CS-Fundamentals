using System;

namespace Match_Tickets
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string category = Console.ReadLine();
            int persons = int.Parse(Console.ReadLine());
            double transport = 0;
            double ticketsPrice = 0;
            double moneyForTickets = 0;
            double moneyLeft = 0;
            

            if (persons>=1 && persons<=4)
            {
                transport = budget * 0.75;
            }
            else if (persons >= 5 && persons <= 9)
            {
                transport = budget * 0.60;
            }
            else if (persons >= 10 && persons <= 24)
            {
                transport = budget * 0.50;
            }
            else if (persons >= 24 && persons < 50)
            {
                transport = budget * 0.40;
            }
            else if (persons >=50)
            {
                transport = budget * 0.25;
            }

            moneyForTickets = budget - transport;

            if (category == "VIP")

                ticketsPrice = persons * 499.99; 
            else if (category == "Normal")
            {
                ticketsPrice = persons * 249.99;
            }

            moneyLeft= moneyForTickets - ticketsPrice;

            if (moneyForTickets>=ticketsPrice)
            {
                Console.WriteLine($"Yes! You have {moneyLeft:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {Math.Abs(moneyForTickets - ticketsPrice):f2} leva.");
            }
        }
    }
}
