using System;

namespace Sum_of_Two_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int lower = int.Parse(Console.ReadLine());
            int upper = int.Parse(Console.ReadLine());
            int magic = int.Parse(Console.ReadLine());

            int combiBroyach = 0;
            bool hasCombo = false;

            for (int i = lower; i <= upper; i++)
            {
                for (int k = lower; k <= upper; k++)
                {
                    int sum = i + k;
                    combiBroyach++;


                    if (sum == magic)
                    {
                        Console.WriteLine($"Combination N:{combiBroyach} ({i} + {k} = {sum})");
                        hasCombo = true;
                        break;
                    }
                    
                }
                if (hasCombo)
                {
                    break;
                }
                
            }
            if (!hasCombo)
            {
                Console.WriteLine($"{combiBroyach} combinations - neither equals {magic}");
            }

        }
    }
}
