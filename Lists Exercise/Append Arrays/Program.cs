namespace _07_AppendArrays
{
    using System;
    using System.Collections.Generic;
    using System.Linq;


    public class AppendArrays
    {
        public static void Main()
        {
            List<string>numbers = Console.ReadLine()
                .Split('|', StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            numbers.Reverse();

            List<int> splittedNumbers = new List<int>();
            List<int> list = new List<int>();

            for (int i = 0; i < numbers.Count; i++)
            {
                splittedNumbers = numbers[i].Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

                for (int k = 0; k < splittedNumbers.Count;k++)
                {
                    list.Add(splittedNumbers[k]);
                }
            }

            Console.WriteLine(string.Join(" ", list));
        }
    }
}