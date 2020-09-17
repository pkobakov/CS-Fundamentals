using System;
using System.Linq;

namespace Rounding_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] nums = Console.ReadLine().Split().Select(double.Parse).ToArray();
            

            for (int i = 0; i < nums.Length; i++)
            {
                double number = nums[i];
                double  rounded = Math.Round(number, MidpointRounding.AwayFromZero);
                Console.WriteLine($"{(decimal)number} => {(decimal)rounded}");
            }
        }
    }
}
