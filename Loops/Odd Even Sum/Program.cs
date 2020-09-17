using System;

namespace Odd_Even_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            
            int sumEven = 0;
            int sumOdd = 0;

            for (int i = 1; i <= n; i ++)
            {
                if (i%2==0)
                {
                    sumEven += int.Parse(Console.ReadLine());

                }
                else
                {
                    sumOdd += int.Parse(Console.ReadLine());
                }
            }
            if ((sumEven - sumOdd) == 0)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {Math.Abs(sumEven)}");
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {Math.Abs(sumEven-sumOdd)}");
            }

        }
            
            
        
    }
}
