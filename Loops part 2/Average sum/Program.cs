using System;

namespace Average_sum
{
    class Program
    {
        static void Main(string[] args)
        {


            double n = double.Parse(Console.ReadLine());
            double sum = 0;
            for (int i = 1; i <= n; i++)
            {
               
                int num = int.Parse(Console.ReadLine());
                sum += num;

                
            }

            double average = sum / n;
            Console.WriteLine($"{average:f2}");
        }
    }
}
