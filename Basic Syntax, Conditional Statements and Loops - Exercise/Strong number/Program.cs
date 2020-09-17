using System;

namespace Strong_number
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int tempNum = num;
            string stringNum = string.Empty;
            stringNum += num;
            int sum = 0;

            for (int i = 0; i < stringNum.Length; i++)
            {
                int currentDigit = tempNum % 10;
                tempNum = (tempNum - currentDigit) / 10;
                int factorial = 1;

                for (int k = 1; k <=currentDigit; k++)
                {
                    factorial *= k;
                }
                sum += factorial;
            }
            if (num == sum)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }   
        }
    }
}
