using System;
using System.Collections.Generic;

namespace Count_Chars_in_a_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            Dictionary<char, int> letters = new Dictionary<char, int>();
            for (int i = 0; i < text.Length; i++)
            {
           
                char letter = text[i];

                if (letter == ' ')
                {
                    continue;
                }

                if (letters.ContainsKey(letter))
                {
                    letters[letter]++;
                }

                else
                {
                    letters.Add(letter,1);
                }

            }
            foreach (var letter in letters)
            {
                Console.WriteLine($"{letter.Key} -> {letter.Value}");
            }


        }
    }
}
