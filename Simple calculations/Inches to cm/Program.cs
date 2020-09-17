using System;

namespace Inches_to_cm
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double inchesToCm = a * 2.54;

            Console.WriteLine(inchesToCm);
        }
    }
}
