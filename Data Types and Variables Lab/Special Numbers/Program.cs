using System;

namespace Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int num = 1; num <= n; num++)
            {
                int sum = 0;
                int number = num;

                while (number>0)
                {
                    sum +=number% 10;
                    number = number / 10;
                }
                
                bool isSpecial = sum == 5 || sum == 7 || sum == 11;
                Console.WriteLine($"{num} -> {isSpecial}");
            }
        }
    }
}
