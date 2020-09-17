using System;

namespace Character_Multiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
          

            Console.WriteLine(CharMultiplier(input[0], input[1]));
        }
        static int CharMultiplier(string first, string second)
        {
            int sum = 0;
            string shortest = string.Empty;
            string longest = string.Empty;

            if (first.Length>second.Length)
            {
                shortest = second;
                longest = first;
            }

            else
            {
                shortest = first;
                longest = second;
            }

            for (int i = 0; i < shortest.Length; i++)
            {

                sum += shortest[i] * longest[i];

            }

            for (int i = shortest.Length; i < longest.Length; i++)
            {
                sum += longest[i];
            }

            return sum;
        
        }
    }
}
