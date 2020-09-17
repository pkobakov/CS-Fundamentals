using System;
using System.Security.Cryptography;

namespace Print_Part_of_the_ASCII_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            for (int i = a; i <= b; i++)
            {
                char symbol = (char)(i);
                Console.Write(symbol+" ");
            }
        }
    }
}
