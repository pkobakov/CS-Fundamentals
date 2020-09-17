using System;
using System.Linq;

namespace Array_Rotation
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int rotations = int.Parse(Console.ReadLine());

            for (int i = 0; i < rotations; i++)
            {

                int last = nums[0];

                int [] temp = new int [nums.Length];

                for (int k = 1; k < nums.Length; k++)
                {
                    temp[k - 1] = nums[k];
                }
                temp[temp.Length - 1] = last;
                nums = temp;
            }

            Console.WriteLine(string.Join(" ", nums));


       
        }
    }
}
