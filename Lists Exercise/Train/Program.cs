using System;
using System.Linq;
using System.Collections.Generic;

namespace Train
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int>train = Console.ReadLine().Split().Select(int.Parse).ToList();
            int maxCapacity = int.Parse(Console.ReadLine());

            string command = Console.ReadLine();

            while (command!="end")
            {
                string[] elements = command.Split();
                if (elements[0] == "Add")
                {
                    int newWagonWithPassengers = int.Parse(elements[1]);
                    train.Add(newWagonWithPassengers);
                    
                }
                else
                {
                    int passengers = int.Parse(elements[0]);

                    for (int i = 0; i < train.Count; i++)
                    {
                        if (train[i]+passengers<=maxCapacity)
                        {
                            train[i] += passengers;
                            break;

                        }
                       
                    }

                }

                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(' ', train));
        }
    }
}
