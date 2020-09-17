using System;

namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int group = int.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            string day = Console.ReadLine();

            double sum = 0;

            if (type =="Students")
            {
                switch (day)
                {
                    case "Friday": sum = group * 8.45; break;
                    case "Saturday": sum = group * 9.80; break;
                    case "Sunday": sum = group * 10.46; break;
                }
                if (group>=30)
                {
                    sum *= 0.85;
                }
            }
            else if (type == "Business")
            {
                if (group>=100)
                {
                    group -= 10;
                }
                switch (day)
                {
                    case "Friday":sum = group * 10.90; break;
                    case "Saturday": sum = group * 15.60; break;
                    case "Sunday":sum = group * 16; break;
                }
            }
            else if (type == "Regular")
            {
                switch (day)
                {
                    case "Friday": sum = group * 15; break;
                    case "Saturday": sum = group * 20; break;
                    case "Sunday": sum = group * 22.50; break;
                }
                if (group>=10&&group<=20)
                {
                    sum *= 0.95;
                }
            }
            Console.WriteLine($"Total price: {sum:f2}");
        }
    }
}
