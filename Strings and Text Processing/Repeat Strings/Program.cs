using System;
using System.Text;

namespace Repeat_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split();

            StringBuilder stringOfwords = new StringBuilder();

            foreach (var currentWord in words)
            {
                int count = currentWord.Length;

                for (int i = 0; i < count; i++)
                {
                    stringOfwords.Append(currentWord);
                }
            }

            Console.WriteLine(stringOfwords);
        }
    }
}
