using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Security.Cryptography.X509Certificates;

namespace P_rates
{
    class Program
    {
        static void Main(string[] args)
        {
           Dictionary<string, List <int>> populationGold = new Dictionary<string, List<int>>();

            while (true)
            {
                string sailCommand = Console.ReadLine();

                if (sailCommand == "Sail")
                {
                    break;
                }
                string[] populationAndGold = sailCommand.Split("||");
                string city = populationAndGold[0];
                int people = int.Parse(populationAndGold[1]);
                int gold = int.Parse(populationAndGold[2]);


                if (!populationGold.ContainsKey(city))
                {
                    populationGold.Add(city, new List<int> { people, gold });
                }

                else
                {
                    populationGold[city][0] += people;
                    populationGold[city][1] += gold;
                }
            }


            while (true)
            {
                string endCommand = Console.ReadLine();

                if (endCommand == "End")
                {
                    break;
                }

                string[] currentEvent = endCommand.Split("=>");
                string operation = currentEvent[0];
                

                if (operation == "Plunder")
                {
                    string city = currentEvent[1];
                    int people = int.Parse(currentEvent[2]);
                    int gold = int.Parse(currentEvent[3]);

                    populationGold[city][0]-= people;
                    populationGold[city][1] -= gold;

                    Console.WriteLine($"{city} plundered! {gold} gold stolen, {people} citizens killed.");
                    if (populationGold[city][0] <=0 || populationGold[city][1] <= 0)
                    {
                        Console.WriteLine($"{city} has been wiped off the map!");
                        populationGold.Remove(city);
                    }

                }

                else if (operation == "Prosper")
                {
                    string city = currentEvent[1];
                    int gold = int.Parse(currentEvent[2]);

                    if (gold<0)
                    {
                        Console.WriteLine($"Gold added cannot be a negative number!");
                        continue;
                    }

                    populationGold[city][1] += gold;

                    Console.WriteLine($"{gold} gold added to the city treasury. {city} now has {populationGold[city][1]} gold.");

                }
            }

            if (populationGold.Count == 0)
            {
                Console.WriteLine($"Ahoy, Captain! All targets have been plundered and destroyed!");

                return;
            }

            Console.WriteLine($"Ahoy, Captain! There are {populationGold.Count} wealthy settlements to go to: ");

            foreach (var kvp in populationGold.OrderByDescending(x => x.Value[1]).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{kvp.Key} -> Population: {kvp.Value[0]} citizens, Gold: {kvp.Value[1]} kg");
            }
        }
    }
}
