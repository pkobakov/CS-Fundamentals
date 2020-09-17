using System;

namespace Rectangle_of_10_x_10_Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            int row = 10;
            int coloumn = 10;

            for (int i = 0; i < row; i++)
            {
                for (int y = 0; y < coloumn; y++)
                {
                    Console.Write('*');
                }
                Console.WriteLine();
            }
            
        }

    }
}
