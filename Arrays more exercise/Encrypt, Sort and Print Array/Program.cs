using System;

namespace Encrypt__Sort_and_Print_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int arrayLength = int.Parse(Console.ReadLine());

            int[] sums = new int[arrayLength];

            for (int i = 0; i < arrayLength; i++)
            {
               
                string name = Console.ReadLine();


                int currSum = 0;
                
                for (int j = 0; j < name.Length; j++)
                {
                    if (name[j]=='a'|| name[j] == 'e' || name[j] == 'u' || name[j] == 'o' || name[j] == 'i' )
                    {
                        currSum += name[j] * name.Length;
                    }
                    else
                    {
                        currSum += name[j] / name.Length;
                    }
                }

                sums[i] = currSum;

               
            }

            Array.Sort(sums);

            for (int i = 0; i < sums.Length; i++)
            {
                Console.WriteLine(sums[i]);
            }
        }
    }
}
