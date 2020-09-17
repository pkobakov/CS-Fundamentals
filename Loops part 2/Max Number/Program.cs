using System;

namespace Max_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int maxNum = int.MinValue;

            for (int i = 1; i <= n; i++)
            {
                int currenNum = int.Parse(Console.ReadLine());

                if (currenNum>maxNum)
                {
                   maxNum = currenNum;
                }
             
            }


            Console.WriteLine(maxNum);

        }
    }
}
