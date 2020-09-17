using System;
using System.Collections.Generic;

namespace A_Miner_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            string metalType = Console.ReadLine();
            Dictionary<string, int> metals = new Dictionary<string, int>();

            while (metalType!="stop")
            {
                int quantity = int.Parse(Console.ReadLine());

                if (metals.ContainsKey(metalType))
                {
                   metals[metalType]+= quantity;
                }
                else
                {
                    metals.Add(metalType, quantity);
                }

                metalType = Console.ReadLine();
            }
            foreach (var pair in metals)
            {
                Console.WriteLine($"{pair.Key} -> {pair.Value}");
            }
        }
    }
}
