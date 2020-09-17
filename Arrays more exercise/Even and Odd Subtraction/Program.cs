using System;
using System.Linq;

namespace Even_and_Odd_Subtraction
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] source = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int evenSum = 0;
            int oddSum = 0;
            int result = 0;
            for (int i = 0; i < source.Length; i++)
            {

                if (source[i]%2==0)
                {
                    evenSum += source[i];
                }
                else
                {
                    oddSum += source[i];
                }

    

            }
           result = evenSum - oddSum;

            Console.WriteLine( result);

        }
    }
}
