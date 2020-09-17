using System;

namespace Sea_Trip
{
    class Program
    {
        static void Main(string[] args)
        {
            double food = double.Parse(Console.ReadLine());
            double souvenirs = double.Parse(Console.ReadLine());
            double hotel = double.Parse(Console.ReadLine());
            int days = 3;
            double distance = 420;
            double fuelConsumption = distance /100 *7;
           
            double fuelCosts = fuelConsumption * 1.85;
            double foodAndSouvenirsExpenses = days * food + days * souvenirs;

            double firstDay = hotel * 0.9;
            double secondDay = hotel * 0.85;
            double thirdDay = hotel * 0.8;
            double totalHotelCosts = firstDay + secondDay + thirdDay;

            double total = fuelCosts + foodAndSouvenirsExpenses + totalHotelCosts;
            Console.WriteLine($"Money needed: {total:f2}");

        }
    }
}
