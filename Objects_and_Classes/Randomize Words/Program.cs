using Microsoft.VisualBasic;
using System;
using System.Linq;

namespace Randomize_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            string [] word = Console.ReadLine().Split(' ').ToArray();
            Random rand = new Random();

            for (int position = 0; position < word.Length; position++)
            {
                int position2 = rand.Next(word.Length);

              string randomElement = word[position2];
                string element = word[position];

                word[position2] = element;
                word[position] = randomElement;

            }
                Console.WriteLine(string.Join(Environment.NewLine,word));
        }
    }
}