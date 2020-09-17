using System;

namespace Top_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            PrintTopNum(n);
        }
        static void PrintTopNum(int n)
        {
            for (int i = 0; i < n; i++)
            {
                int current = i;
                int digitsSum = 0;
                bool isDivided = false;
                bool hasOddDigit = false;

                while (current > 0)
                {

                    int digit = current % 10;
                    digitsSum += digit;

                    if (digit%2 != 0)
                    {
                        hasOddDigit = true;
                    }

                    current /= 10;
                   
                }
                if (digitsSum % 8 == 0)
                {

                    isDivided=true;
                }
                if (isDivided == true && hasOddDigit == true)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
