using System;

namespace Ski_vacation
{
    class Program
    {
        static void Main(string[] args)
        {

            int days = int.Parse(Console.ReadLine());
            string room = Console.ReadLine();
            string feedback = Console.ReadLine();
            double sumNights = 0;
            int nighs = days - 1;
            if (room == "room for one person")
            {
                sumNights = 18 * nighs;
            }
            else if (room == "apartment")
            {
                if (days < 10)
                {
                    sumNights = (25 * nighs) * 0.7;
                }
                else if (days >= 10 && days <= 15)
                {
                    sumNights = (25 * nighs) * 0.65;
                }
                else if (days > 15)
                {
                    sumNights = (25 * nighs) * 0.5;
                }
            }
            else if (room == "president apartment")
            {
                if (days < 10)
                {
                    sumNights = (35 * nighs) * 0.9;
                }
                else if (days >= 10 && days <= 15)
                {
                    sumNights = (35 * nighs) * 0.85;
                }
                else if (days > 15)
                {
                    sumNights = (35 * nighs) * 0.8;
                }
            }
            if (feedback == "positive")
            {
                sumNights = sumNights * 1.25;
            }
            else if (feedback == "negative")
            {
                sumNights = sumNights * 0.9;
            }

            Console.WriteLine($"{sumNights:f2}");
        }
    }
}
