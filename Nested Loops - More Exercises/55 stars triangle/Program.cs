using System;

namespace _55_stars_triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 10; i++)
            {
                for (int z = 1; z <=i; z++)
                {
                    Console.Write('*');
                }
                Console.WriteLine();
            }
            
        }

    }
}
