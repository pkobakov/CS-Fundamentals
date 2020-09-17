using System;
using System.Collections.Generic;

namespace SoftUni_Parking
{
    class Program
    {

        static void Main(string[] args)
        {
            Dictionary<string, string> namePlatenumber = new Dictionary<string, string>();

            int commandsCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < commandsCount; i++)
            {
                string[] elemets = Console.ReadLine().Split();

                string command = elemets[0];
                string name = elemets[1];

                if (command == "register")
                {
                    string plateNumber = elemets[2];

                    if (!namePlatenumber.ContainsKey(name)) //ако НЕ съдържа, принтираме, че вече го има;
                    {
                        namePlatenumber[name] = plateNumber;
                        
                        Console.WriteLine($"{name} registered {plateNumber} successfully");
                    }

                    else
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {plateNumber}");
                    }
                }

                else
                {
                    if (!namePlatenumber.ContainsKey(name))
                    {

                        Console.WriteLine($"ERROR: user {name} not found");
                    }
                    else
                    {
                        namePlatenumber.Remove(name);
                        Console.WriteLine($"{name} unregistered successfully");
                    }
                }
            }
            foreach (var kvp in namePlatenumber)
            {
                Console.WriteLine($"{kvp.Key} => {kvp.Value}");
            }
            
        }
    }
}
