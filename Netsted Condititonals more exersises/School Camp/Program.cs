using System;

namespace School_Camp
{
    class Program
    {
        static void Main(string[] args)
        {
            string season = Console.ReadLine();
            string groupType = Console.ReadLine();
            int students = int.Parse(Console.ReadLine());
            int nights = int.Parse(Console.ReadLine());
            double price = 0;
            string sport = "";


            if (season == "Spring")
            {
                switch (groupType)
                {
                    case "boys": sport = "Tennis"; price = students*nights * 7.20; break;
                    case "girls": sport = "Athletics"; price = students*nights * 7.20; break;
                    case "mixed": sport = "Cycling"; price = students*nights * 9.50; break;
                }
            }
            else if (season == "Summer")
            {
                switch (groupType)
                {
                    case "boys": sport ="Football" ; price = students*nights * 15.00; break;
                    case "girls": sport = "Volleyball"; price = students*nights * 15.00; break;
                    case "mixed": sport = "Swimming"; price = students*nights * 20.00; break;
                }
            }
            else if (season == "Winter")
            {
                switch (groupType)
                {
                    case "boys": sport = "Judo"; price =students*nights * 9.60; break;
                    case "girls": sport = " Gymnastics"; price = students*nights * 9.60; break;
                    case "mixed": sport = "Ski"; price = students* nights * 10.00; break;
                }
            }
            if (students >= 50)
            {
                price *=0.50;
            }
            else if (students >= 20)
            {
                price *=0.85;
            }
            else if (students >= 10)
            {
                price *=0.95;
            }

            Console.WriteLine($"{sport} {price:f2} lv.");
        }
    }
}
