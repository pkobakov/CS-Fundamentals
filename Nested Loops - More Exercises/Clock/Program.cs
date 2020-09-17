using System;

namespace Clock
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 24; i++)
            {
                for (int mm = 0; mm <= 59; mm++)
                {
                    Console.WriteLine($"{i} : {mm}");
                }
            }
        }
    }
}
