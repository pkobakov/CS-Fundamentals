using System;

namespace Supplies_for_School
{
    class Program
    {
        static void Main(string[] args)
        {
            int pens = int.Parse(Console.ReadLine());
            int markers = int.Parse(Console.ReadLine());
            double litres = double.Parse(Console.ReadLine());
            int percent = int.Parse(Console.ReadLine());

            double sumpens = pens * 5.80;
            double summarkers = markers * 7.20;
            double sumlitres = litres * 1.20;

            double sumofall = sumpens + summarkers + sumlitres;
            double total = sumofall - (sumofall * percent/100);
            Console.WriteLine($"{total:f3}");
        }
    }
}
