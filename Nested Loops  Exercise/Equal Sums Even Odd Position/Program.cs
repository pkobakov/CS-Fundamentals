using System;

namespace Equal_Sums_Even_Odd_Position
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());

            for (int i = start; i <= end; i++)
            {
                int number = i;
                bool isEven = true;
               
                int evenSum = 0;
                int oddSum = 0;

                int temp = number;
                

                while (temp > 0)
                {
                  int digit = temp % 10;
                  temp /= 10;

                    if (isEven)
                    {
                        evenSum += digit;
                        isEven=false;

                    }
                    else 
                    {
                        oddSum += digit;
                        
                    }

                }

                if (oddSum == evenSum)
                {
                    Console.Write(number + " ");
                }
            }

       
        }
        
        
    }
}
