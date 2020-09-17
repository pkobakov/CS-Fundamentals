using System;

namespace Fishland
{
    class Program
    {
        static void Main(string[] args)
        {

            double skumpriaPrice = double.Parse(Console.ReadLine());
            double cacaPrice = double.Parse(Console.ReadLine());
            double palamudKg = double.Parse(Console.ReadLine());
            double safridKg = double.Parse(Console.ReadLine());
            double midiKg = double.Parse(Console.ReadLine());

            double palamudPrice = skumpriaPrice + skumpriaPrice * 0.60;
            double palamudSum = palamudPrice * palamudKg;
            double safridPrice = cacaPrice + cacaPrice * 0.80;
            double safridSum = safridPrice * safridKg;
            double midiSum = midiKg * 7.50;
            double total = palamudSum + safridSum + midiSum;
            
            Console.WriteLine($"{total:f2}");


            
        }
    }
}
