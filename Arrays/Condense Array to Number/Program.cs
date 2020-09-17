using System;
using System.Linq;

namespace Condense_Array_to_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for (int i = 0; i < numbers.Length; i++)
            {
                int number = numbers[i]; 
            }

            while (numbers.Length!=1)
            { 
                int[] newNumbers = new int[numbers.Length - 1];
            
                for (int i = 0; i < newNumbers.Length; i++)
                {
                    newNumbers[i] = numbers[i] + numbers[i + 1];

                }

                numbers = newNumbers;
            }
            
            Console.WriteLine(string.Join(" ", numbers));

        }
    }
}
