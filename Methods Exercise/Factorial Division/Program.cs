using System;

namespace Factorial_Division
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1 = double.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());

            FactorialDivision(num1, num2);
        }
        static void FactorialDivision(double num1,double num2)
        {
            double factorialNum1 = 1;
            double factorialNum2 = 1;
            double factorialDivision = 0;

            for (int i = 1; i <= num1; i++)
            {
                factorialNum1 *= i;
            }
            
            for (int i = 1; i <= num2; i++)
            {
                factorialNum2 *= i;
            }
            

            factorialDivision = factorialNum1 / factorialNum2;
            Console.WriteLine($"{factorialDivision:f2}");

        }
    }
}
