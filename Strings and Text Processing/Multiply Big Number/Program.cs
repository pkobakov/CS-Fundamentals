using System;
using System.Numerics;
using System.Text;

namespace Multiply_Big_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string bigNum = Console.ReadLine();
            int smallNum = int.Parse(Console.ReadLine());

            if (smallNum == 0)
            {
                Console.WriteLine(0); // умножение с 0 дава 0;
                return;
            }

            while (bigNum[0] == '0')
            {
                bigNum = bigNum.Substring(1);
            }
            StringBuilder sb = new StringBuilder();
            int reminder = 0;

            for (int i = bigNum.Length-1; i >= 0 ; i++)
            {
                int result = int.Parse(bigNum[i].ToString()) * smallNum + reminder; // char bigNum[i] от string bigNum се преобразува в string, тк ASCII стойността е различна;
                reminder = 0;

                if (result>9)
                {
                    reminder = result / 10;
                    result = result % 10;
                }

                sb.Append(result);
            }

            if (reminder!=0)
            {
                sb.Append(reminder);
            }
            StringBuilder final = new StringBuilder();

            for (int i = sb.Length-1;i>=0; i--)
            {
                final.Append(sb[i]);
            }
            Console.WriteLine();
        }
    }
}
