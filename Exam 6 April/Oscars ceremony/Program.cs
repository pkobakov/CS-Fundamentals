using System;

namespace Oscars_ceremony
{
    class Program
    {
        static void Main(string[] args)
        {
            double rent = double.Parse(Console.ReadLine());

            double trophy = rent - (rent * 0.3);
            double catering = trophy - (trophy * 0.15);
            double sound = 0.5 * catering;

            double total = rent + trophy + catering + sound; 
            Console.WriteLine($"{total:f2}");
        }
    }
}
