using System;

namespace Triples_of_Latin_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                for (int k = 0; k < n; k++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        char frst = (char)('a' + i);
                        char snd = (char)('a'+k);
                        char trd = (char)('a'+j);
                        Console.WriteLine($"{frst}{snd}{trd}");
                    }
                }
            }
        }
    }
}
