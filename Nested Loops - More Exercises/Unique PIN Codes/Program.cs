using System;

namespace Unique_PIN_Codes
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            int number3 = int.Parse(Console.ReadLine());

            for (int i = 2; i <= number1; i+=2)
            {
                for (int y = 1; y <= number2; y++)
                {
                    for (int z = 2; z <= number3; z+=2)
                    {
                        if (y == 2||y ==3||y==5||y==7)
                        {
                            Console.WriteLine($"{i} {y} {z}");
                        }
                        
                    }
                }
            }
        }
    }
}
