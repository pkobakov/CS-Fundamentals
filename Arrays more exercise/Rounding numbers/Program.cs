using System;
using System.Linq;

namespace Rounding_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] nums = Console.ReadLine().Split().Select(double.Parse).ToArray();

            for (int i = 0; i < nums.Length; i++)
            {
                double roundedNum = Math.Round(nums[i], MidpointRounding.AwayFromZero);

                Console.WriteLine($"{nums[i]} => {roundedNum}");

            }
        }
    }
}
