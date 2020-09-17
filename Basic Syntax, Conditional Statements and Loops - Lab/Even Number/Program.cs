using System;

namespace Even_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            while (n!=0)
            {
                if (n % 2 == 0)
                {
                    Console.WriteLine($"The number is: {Math.Abs(n)}");
                }
                else
                {
                    Console.WriteLine($"Please write an even number.");
                }
                n = int.Parse(Console.ReadLine());
            }
        }
    }
}
