using System;

namespace Pet_shop
{
    class Program
    {
        static void Main(string[] args)
        {
            int dogs = int.Parse(Console.ReadLine());
            int animals = int.Parse(Console.ReadLine());
            double expensDogs = dogs * 2.50;
            double expensAnimals = animals * 4.00;
            double expenses = expensDogs+expensAnimals;
            Console.WriteLine($"{expenses:f2} lv.");

        }
    }
}
