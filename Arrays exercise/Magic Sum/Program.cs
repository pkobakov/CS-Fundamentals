using System;
using System.Linq;

namespace Magic_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] number = Console.ReadLine()
                  .Split()
                  .Select(int.Parse)
                  .ToArray();
            int magicSum = int.Parse(Console.ReadLine());

            for (int i = 0; i < number.Length; i++)
            {
                for (int j = i+1; j < number.Length; j++)
                {
                    if (number[i]+number[j]==magicSum)
                    {
                        Console.WriteLine($"{number[i]} {number[j]}");
                    }
                }
            }
        }
    }
}
