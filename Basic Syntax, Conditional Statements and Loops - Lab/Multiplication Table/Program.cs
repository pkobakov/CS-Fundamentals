using System;

namespace Multiplication_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int result = 0;
            for (int i = 1; i <= 10; i++)
            {
                result = i * n;
                Console.WriteLine($"{n} X {i} = {result}");
            }
        }
    }
}
