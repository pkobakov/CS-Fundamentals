using System;
using System.Linq;

namespace Zig_Zag_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] one = new int [n];
            int[] two = new int[n];

            for (int i = 0; i <n; i++)
            {
               int[]line = Console.ReadLine().Split().Select(int.Parse).ToArray() ;

                if (i%2==0)
                {
                    one[i] = line[1];
                    two[i] = line[0];
                }
                else
                {
                    one[i] = line[0];
                    two[i] = line[1];
                }

                
            }
            Console.WriteLine(string.Join(" ",two));
            Console.WriteLine(string.Join(" ", one));

        }
    }
}
