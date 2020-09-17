﻿using System;
using System.Threading;

namespace Printing_Triangle
{
    class Program
    {
        static void PrintTriangle(int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();


        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                PrintTriangle(1,i);
            }
            for (int i = n-1; i >= 1; i--)
            {
                PrintTriangle(1, i);
            }
          
        }
    }
}
