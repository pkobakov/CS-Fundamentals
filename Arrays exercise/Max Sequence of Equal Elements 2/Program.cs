using System;
using System.Linq;

namespace Max_Sequence_of_Equal_Elements_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int length = 1;
            int maxLength = 1;
            int number = array[0];

            for (int i = 1; i < array.Length; i++)
            {
                int nextNum = array[i - 1];
                int currentNum = array[i];

                if (currentNum==nextNum)
                {
                    length++;

                    if (length > maxLength)
                    {
                        maxLength = length;
                        number = currentNum;
                    }
                }
                else
                {
                    length = 1;
                }
                
            }

            for (int i = 0; i < maxLength; i++)
            {
                Console.Write(number +" ");
            }


            Console.WriteLine();

        }
    }
}
