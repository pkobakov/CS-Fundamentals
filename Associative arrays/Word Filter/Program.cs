using System;
using System.Linq;

namespace Word_Filter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] fruits = Console.ReadLine().Split().Where(letters=>letters.Length%2==0).ToArray();
            for (int i = 0; i < fruits.Length; i++)
            {
                Console.WriteLine(fruits[i]);
            }
           
        }
    }
}
