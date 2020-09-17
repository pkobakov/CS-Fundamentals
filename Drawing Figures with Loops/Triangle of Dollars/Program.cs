using System;

namespace Triangle_of_Dollars
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int row = 0; row < n; row++)
            {
                for (int y = 0; y < row+1; y++)
                {
                    Console.Write('$'+" ");
                }
                Console.WriteLine();
            }
        }
    }
}
