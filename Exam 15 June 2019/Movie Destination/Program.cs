using System;

namespace Movie_Destination
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string destination = Console.ReadLine();
            string season = Console.ReadLine();
            int days = int.Parse(Console.ReadLine());
            double expenses = 0;

            if (season == "Summer")
            {
                switch (destination)
                {
                   
                    case "Sofia": expenses =  12500 * (double)days; break;
                    case "London": expenses = 20250 * (double)days; break;
                    case "Dubai": expenses =  40000 * (double)days;  break;
                }
            }
            else if (season == "Winter")
            {
                switch (destination)
                {
                    case "Sofia": expenses = 17000 * (double)days; break;
                    case "London": expenses = 24000 *(double)days; break;
                    case "Dubai": expenses = 45000 * (double)days; break;
                }
            }
            if (destination=="Dubai")
            {
                expenses -= expenses * 0.3;
            }
            else if (destination=="Sofia")
            {
                expenses += expenses * 0.25;
            }
            if (budget>=expenses)
            {
                double budgetleft = budget - expenses;
                Console.WriteLine($"The budget for the movie is enough! We have {budgetleft:f2} leva left!");
            }
            else
            {
                double neededmoney = expenses - budget;
                Console.WriteLine($"The director needs {neededmoney:f2} leva more!");
            }

        }
    }
}
