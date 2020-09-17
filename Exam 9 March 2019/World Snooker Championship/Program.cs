using System;

namespace World_Snooker_Championship
{
    class Program
    {
        static void Main(string[] args)
        {
            string round = Console.ReadLine();
            string ticketType = Console.ReadLine();
            int ticketCount = int.Parse(Console.ReadLine());
            char photo = char.Parse(Console.ReadLine());

            double ticketsPrice = 0;

            if (round == "Quarter final")
            {

                switch (ticketType)
                {
                    case "Standard": ticketsPrice = ticketCount * 55.50; break;
                    case "Premium": ticketsPrice = ticketCount * 105.20; break;
                    case "VIP": ticketsPrice = ticketCount * 118.90; break;

                }
            }
            else if (round == "Semi final")
            {

                switch (ticketType)
                {
                    case "Standard": ticketsPrice = ticketCount * 75.88; break;
                    case "Premium": ticketsPrice = ticketCount * 125.22; break;
                    case "VIP": ticketsPrice = ticketCount * 300.40; break;

                }
            }
            else if (round == "Final")
            {

                switch (ticketType)
                {
                    case "Standard": ticketsPrice = ticketCount * 110.10; break;
                    case "Premium": ticketsPrice = ticketCount * 160.66; break;
                    case "VIP": ticketsPrice = ticketCount * 400; break;

                }
            }
            if (photo == 'Y' && ticketsPrice <=2500)
            {
                double photoPrice = ticketCount * 40;
                ticketsPrice += photoPrice;

            }

            else if (ticketsPrice > 2500 && ticketsPrice <= 4000)
            {
                ticketsPrice = ticketsPrice - (ticketsPrice * 0.1);

                if (photo=='Y')
                {
                    double photoPrice = ticketCount * 40;
                    ticketsPrice += photoPrice;
                }

            }
            else if (ticketsPrice > 4000)
            {

                ticketsPrice = ticketsPrice - (ticketsPrice * 0.25);
            }
            Console.WriteLine($"{ticketsPrice:f2}");
        }
    }
}
