using System;

namespace Min_Number
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            int minNum = int.MaxValue;

            for (int i = 1; i <= n; i++)
            {
                int currenNum = int.Parse(Console.ReadLine());

                if (currenNum < minNum)
                {
                    minNum = currenNum;
                }

            }


            Console.WriteLine(minNum);



        }
    }
}
