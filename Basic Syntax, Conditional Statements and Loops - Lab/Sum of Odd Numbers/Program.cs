using System;

namespace Sum_of_Odd_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int oddNum = 1;

            for (int i = 0; i < n; i++)
            {
                sum += oddNum;
                Console.WriteLine(oddNum);
                oddNum += 2;
            }
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
b