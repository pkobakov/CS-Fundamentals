using System;

namespace Multiplication_Table_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int result = 0;
            if (b>10)
            {
                result = a * b;
                Console.WriteLine($"{a} X {b} = {result}");
            }
            else
            {
                for (int i = b; i <= 10; i++)
                {
                    result = a * i;
                    Console.WriteLine($"{a} X {i} = {result}");
                }
            }
           
           
        }
    }
}
