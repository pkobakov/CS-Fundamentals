using System;

namespace ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double num1 = 0;
            double num2 = 0;
            double num3 = 0;
            
            for (int currentnum = 1; currentnum <=n; currentnum++)
            {
            int num = int.Parse(Console.ReadLine());
               

                if (num %2 == 0)
                {
                    num1++;
                   
                }
                if (num %3 == 0)
                {
                    num2++;
                }
                if (num %4 == 0)
                {
                    num3++;
                }

            }

            double p1 = (num1 / n) * 100;
            double p2 = (num2/ n) * 100;
            double p3 = (num3 / n) * 100;
            
            
            Console.WriteLine($"{p1:f2}%");
            Console.WriteLine($"{p2:f2}%");
            Console.WriteLine($"{p3:f2}%");

        }
    }
}
