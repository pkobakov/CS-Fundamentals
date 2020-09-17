using System;
using System.Collections.Generic;

namespace Odd_Occurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split();
            Dictionary<string,int> counts = new Dictionary<string, int>();

            foreach (var word in words)
            {
                string lowerCase = word.ToLower();
                if (counts.ContainsKey(lowerCase))
                {
                    counts[lowerCase]++;
                }
                else
                {
                    counts.Add(lowerCase, 1); // "1" е началната стойност на даден елемент от речника;
                }
                
            }
            foreach (var pair in counts) //обхожда всяка двойка от речника;
            {
                if (pair.Value %2 != 0) //ако стойността на елемента четна;
                {
                    Console.Write(pair.Key + " ");
                }
            }

        }
    }
}
