using System;

namespace Sum_Digits
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int number = n;
            while (number > 0)
            {
                sum += number % 10;
                number = number / 10;
            }

            Console.WriteLine(sum);
        }
    }
}
