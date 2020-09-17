using System;

namespace Pounds_to_Dollars
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal pound = decimal.Parse(Console.ReadLine());
            decimal dollars = pound * (decimal)1.31;
            Console.WriteLine($"{dollars:f3}");
        }
    }
}
