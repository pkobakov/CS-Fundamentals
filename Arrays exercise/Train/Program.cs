using System;

namespace Train
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] train = new int[n];
            int passengers = 0;

            for (int i = 0; i < train.Length; i++)
            {
                train[i] = int.Parse(Console.ReadLine());
                passengers += train[i];
            }

            Console.WriteLine(string.Join(" ", train));
            Console.WriteLine(passengers);
        }
    }
}
