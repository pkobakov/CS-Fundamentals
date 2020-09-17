using System;

namespace _2D_Rectangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double L = Math.Abs(x - x2);
            double W = Math.Abs(y - y2);

            double area = L * W;
            double perim = (L + W) * 2;
            Console.WriteLine($"{area:f2}");
            Console.WriteLine($"{perim:f2}");
        }
    }
}
