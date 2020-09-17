using System;

namespace nums10_100_divided_3
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {
                
                if (i %3==0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
