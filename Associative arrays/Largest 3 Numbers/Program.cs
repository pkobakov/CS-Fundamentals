using System;
using System.Collections.Generic;
using System.Linq;

namespace Largest_3_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().
                             Split().
                             Select(int.Parse).
                             OrderByDescending(num => num).
                             ToList();

            if (nums.Count < 3)
            {
                Console.WriteLine(string.Join(" ", nums));
            }
            else
            {
                for (int i = 0; i <= 2; i++)
                {
                    Console.Write(nums[i] + " ");
                }
            }

                        

            
        }
    }
}
