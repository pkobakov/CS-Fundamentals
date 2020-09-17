using System;

namespace Yard_greening
{
    class Program
    {
        static void Main(string[] args)
        {
            double metres = double.Parse(Console.ReadLine());
            double price = metres*7.61;
            double discount = price * 0.18;
            double totalPrice = price - discount;
            Console.WriteLine($"The final price is: {totalPrice:f2} lv.");
            Console.WriteLine($"The discount is: {discount:f2} lv.");

            
        }
    }
}
