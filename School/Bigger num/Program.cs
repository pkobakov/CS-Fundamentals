using System;

namespace Bigger_num
{
    class Program
    {
        static void Main(string[] args)
        {
            int nOne = int.Parse(Console.ReadLine());
            int nTwo = int.Parse(Console.ReadLine());

            if (nOne>nTwo)
            {
                Console.WriteLine(nOne);
            }
            else
            {
                Console.WriteLine(nTwo);
            }
        }
    }
}
