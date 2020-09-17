using System;
using System.Globalization;
using System.Linq;

namespace Reverse_Array_of_strings
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] texts = Console.ReadLine().Split();
            

            for (int i = 0; i <texts.Length/2; i++)
            {
                string first = texts[i];
                string last = texts[texts.Length - i - 1];

                texts[i] = last;
                texts[texts.Length - i - 1] = first;
            }
            Console.WriteLine(string.Join(" ", texts));
        }

    }
}
