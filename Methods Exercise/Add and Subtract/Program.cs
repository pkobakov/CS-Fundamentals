using System;

namespace Add_and_Subtract
{
    class Program
    {
        static void Main(string[] args)
        {

            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            Subtrack(num1, num2, num3);
        }
        static int Sum(int num1, int num2)
        {

            int result = num1 + num2;
            return result;
        }
        static void Subtrack(int num1, int num2, int num3)
        {

            int sumResult = Sum(num1, num2);
            int subtrackResult = sumResult - num3;
            Console.WriteLine(subtrackResult);
        }
    }
}
