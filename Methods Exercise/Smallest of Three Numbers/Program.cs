using System;

namespace Smallest_of_Three_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int minNum = SmallestNumber(a, b, c);
            Console.WriteLine(minNum);
          
        }
       static int SmallestNumber(int a, int b, int c)
        {
            return Math.Min(Math.Min(a,b),c);
        }
    }
}
