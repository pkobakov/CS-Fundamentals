using System;
using System.Linq;

namespace Equal_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] firstArray = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] secondArray = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int sum = 0;
           

            for (int i = 0; i < firstArray.Length; i++)
            {
                int currentFirstArray = firstArray[i];
                int currentSecondArray = secondArray[i];

                if (currentFirstArray != currentSecondArray)
                {
                    Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
                    return;
                }
                else
                {
                    sum += currentFirstArray;
                }

            }
            Console.WriteLine($"Arrays are identical. Sum: {sum}");



        }
    }
}
