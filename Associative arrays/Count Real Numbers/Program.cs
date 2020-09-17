using System;
using System.Collections.Generic;
using System.Linq;

namespace Count_Real_Numbers //колко пъти се среща дадено число
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split().Select(double.Parse).ToArray(); // числата се подават като масив;

            var keysCount = new SortedDictionary<double, int>(); // колко пъти е срещнато дадено число (double е срещнато int пъти);

            foreach (var key in numbers) 
            {
                if (!keysCount.ContainsKey(key)) // ако числото (ключа) до момента го няма, се добавя за пръв път;
                {
                    keysCount[key] = 1; // number e key;
                }
                else
                {
                    keysCount[key]++;
                }
             
            
            }
            foreach (var pair in keysCount)
            {
                Console.WriteLine($"{pair.Key} -> {pair.Value}");
            }

        }
    }
}
