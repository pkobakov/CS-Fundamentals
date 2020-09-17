using System;
using System.Linq;

namespace EncryptSortAndPrintArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int names = int.Parse(Console.ReadLine());

            int[] sums = new int[names];

            char[] vowels = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };



            for (int i = 0; i < names; i++)
            {
                string name = Console.ReadLine(); //четем име

                int currSum = 0;


                for (int j = 0; j < name.Length; j++) //обхождаме името
                {
                    bool isMatch = false;

                    for (int k = 0; k < vowels.Length; k++) //дали даден индекс (буква) е гласна
                    {
                        if (name[j] == vowels[k]) 
                        {
                            isMatch = true;
                            break;
                        }
                    }
                    if (isMatch == true)
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