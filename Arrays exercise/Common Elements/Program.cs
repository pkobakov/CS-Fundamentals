using System;

namespace Common_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            string [] arrOne = Console.ReadLine().Split();
            string[] arrTwo = Console.ReadLine().Split();

            for (int i = 0; i < arrTwo.Length; i++)
            {
                for (int l = 0; l < arrOne.Length; l++)
                {
                    if (arrOne[l]==arrTwo[i])
                    {
                        Console.Write(arrTwo[i]+" ");
                    }
                }

            }
            Console.WriteLine();
        }
    }
}
