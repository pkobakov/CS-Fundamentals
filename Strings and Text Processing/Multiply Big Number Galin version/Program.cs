using System;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;

namespace Multiply_Big_Number_Galin_version
{
    class Program
    {
        static void Main(string[] args)
        {
            string bigNum = Console.ReadLine();
            int multiplier = int.Parse(Console.ReadLine());

            StringBuilder builder = new StringBuilder();
            int inMind = 0;

            for (int i = bigNum.Length-1 ; i >= 0; i--)
            {
                int lastDigit = int.Parse(bigNum[i].ToString());
                int result = lastDigit * multiplier + inMind; //пример: 9*9+0=>81+0;
                builder.Append(result % 10); //добавяме последното число 1;
                inMind = result / 10; // 8;
            }

            if (inMind != 0)
            {
                builder.Append(inMind);
            }

            string finalResult = string.Join("", builder.ToString().Reverse()).TrimStart('0');

            if (finalResult == string.Empty)
            {
                Console.WriteLine(0);
                return;
            }

            else
            {
                Console.WriteLine(finalResult);
            }

        }
    }
}
split