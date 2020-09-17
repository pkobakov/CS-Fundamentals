using System;
using System.Collections.Generic;
using System.Linq;

namespace Battle_Manager
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<int>> roll = new Dictionary<string, List<int>>();

            while (true)
            {
                string [] input = Console.ReadLine().Split(':');
                string command = input[0];

                if (command == "Results")
                {
                    break;
                }

                else if (command == "Add")
                {
                    string name = input[1];
                    int health = int.Parse (input[2]);
                    int energy = int.Parse(input[3]);

                    if (!roll.ContainsKey(name))
                    {
                        roll.Add(name, new List<int>{health,energy});
                    }

                    roll[name][0] += health;

                }

                else if (command == "Attack")
                {
                    string attackName = input[1];
                    string defenderName = input[2];
                    int damage = int.Parse(input[3]);

                    if (roll.ContainsKey(attackName) && roll.ContainsKey(defenderName))
                    {
                        roll[defenderName][0] -= damage;

                        if (roll[defenderName][0] <= 0)
                        {
                            roll.Remove(defenderName);

                            Console.WriteLine($"{defenderName} was disqualified!");
                        }

                        roll[attackName][0] -= damage;

                        if (roll[attackName][0] <= 0)
                        {
                            roll.Remove(attackName);

                            Console.WriteLine($"{attackName} was disqualified!");

                        }
                    }
                }

                else if (command == "Delete")
                {

                    string name = input[1];

                    if (roll.ContainsKey(name))
                    {
                        roll[name].Clear();
                    }

                    else if (name == "All")
                    {
                        roll.Clear();
                    }
                }
            }

            Console.WriteLine($"People count: {roll.Count}");

            foreach (var name in roll.OrderByDescending(x=>x.Value[0]).ThenBy(x=>x.Key))
            {
                Console.WriteLine($"{name.Key} - {name.Value[0]} - {name.Value[1]}");
            }
        }
    }
}
