using System;

namespace Multiply_by_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            double sum = 0;

            while (number >= 0)
            {
               
                sum = number * 2;
                Console.WriteLine($"Result: {sum:f2}");
                number = double.Parse(Console.ReadLine());
            }
            if (number < 0)
            {
                Console.WriteLine($"Negative number!");
                
            }

        }
    }
}
