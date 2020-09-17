using System;

namespace Math_Power
{
    class Program
    {
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());
            double power = double.Parse(Console.ReadLine());
            Console.WriteLine(Power(num, power));

        }
        static double Power(double num, double power) 
        {
           double result = 0;

            result = Math.Pow(num, power);
            return result;
        }
    }
}
