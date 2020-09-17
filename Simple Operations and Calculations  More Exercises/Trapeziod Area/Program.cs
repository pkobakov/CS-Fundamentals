using System;

namespace Trapeziod_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            double b = double.Parse(Console.ReadLine());
            double b1 = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());
            double area = (b+b1) * h / 2;

            Console.WriteLine($"{area:f2}");

        }
    }
}
