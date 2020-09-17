using System;

namespace Passed
{
    class Program
    {
        static void Main(string[] args)
        {
            double score = double.Parse(Console.ReadLine());
            if (score>=3)
            {
                Console.WriteLine("Passed!");
            }
        }
    }
}