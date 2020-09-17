using System;

namespace Fish_tank
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine());
            double volume = a * b * c;
            double litres = volume / 1000;
            
            double totalLitres = litres - (litres*(percent*0.01));
            
            Console.WriteLine($"{totalLitres:f3}");

        }
    }
}
