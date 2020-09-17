using System;

namespace Water_Overflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int tankCapacity = 255;
            byte lines = byte.Parse(Console.ReadLine());
            ushort totalLitres = 0;

            for (int i = 0; i < lines; i++)
            {
                ushort liters = ushort.Parse(Console.ReadLine());

                if (totalLitres+liters>tankCapacity)
                {
                    Console.WriteLine("Insufficient capacity!");
                    
                }
                else
                {
                    totalLitres += liters;
                }
            }
            Console.WriteLine(totalLitres);
        }
    }
}
