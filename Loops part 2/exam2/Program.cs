using System;

namespace exam2
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int hours = int.Parse(Console.ReadLine());
            int person = int.Parse(Console.ReadLine());
            string dayTime = Console.ReadLine();

            double price = 0;
            double firstDiscountPrice = 0;
            double secondDiscountPrice = 0;


            double totalPrice = 0;

            if (month == "march" || month == "april" || month == "may")
            {
                switch (dayTime)
                {
                    case "day": price = 10.50; break;
                    case "night": price = 8.40; break;

                }


            }
            else if (month == "june" || month == "july" || month == "august")
            {
                switch (dayTime)
                {
                    case "day": price = 12.60; break;
                    case "night": price = 10.20; break;

                }

            }
            if (person<4)
            {

                totalPrice = (price * hours) * person;

                Console.WriteLine($"Price per person for one hour: {price:f2}");
                Console.WriteLine($"Total cost of the visit: {totalPrice:f2}");

                
            }
            if (person >= 4 && hours<5)
            {
                firstDiscountPrice = price - (price * 0.1);
                totalPrice = (firstDiscountPrice * hours) * person;

                Console.WriteLine($"Price per person for one hour: {firstDiscountPrice:f2}");
                Console.WriteLine($"Total cost of the visit: {totalPrice:f2}");

            }
            if (person >=4 && hours >= 5)
            {
                firstDiscountPrice = price - (price * 0.1);
                secondDiscountPrice = firstDiscountPrice - (firstDiscountPrice * 0.5);
                totalPrice = (secondDiscountPrice * hours) * person;

                Console.WriteLine($"Price per person for one hour: {secondDiscountPrice:f2}");
                Console.WriteLine($"Total cost of the visit: {totalPrice:f2}");

            }


            


            
            
        }


    }
}
