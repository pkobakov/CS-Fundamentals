using System;

namespace Cinema
{
    class Program
    {
        static void Main(string[] args)
        {

            //Premiere 12.00 лева.
            //Normal 7.50 лева.
            //Discount 5.00 лева.

            string type = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int coloumns = int.Parse(Console.ReadLine());
            double income = 0;
            if (type == "Premiere")
            {
                income = (rows * coloumns) * 12;

            }
            else if (type == "Normal")
            {
                income = (rows * coloumns) * 7.50;
            }
            else if (type == "Discount")
            {
                income = (rows * coloumns) * 5.00;
            }
            Console.WriteLine($"{income:f2} leva");
        }
        
    }
}
