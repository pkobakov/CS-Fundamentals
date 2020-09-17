using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;

namespace Heroes_of_Code_and_Logic_VII
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, List<int>> heroes = new Dictionary<string, List<int>>();

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                string[] heroData = input.Split();

                string name = heroData[0];
                int HP = int.Parse(heroData[1]);
                int MP = int.Parse(heroData[2]);

                heroes.Add(name, new List<int> { HP, MP });
            }

            string command = Console.ReadLine();

            while (command != "End")
            {
                string[] elements = command.Split(" - ", StringSplitOptions.RemoveEmptyEntries);
                string action = elements[0];



                if (action == "CastSpell")
                {
                    string name = elements[1];
                    int points = int.Parse(elements[2]);
                    string castSpell = elements[3];

                   

                    if (heroes[name][1] - points >= 0)
                    {
                        heroes[name][1] -= points;
                        Console.WriteLine($"{name} has successfully cast {castSpell} and now has {heroes[name][1]} MP!");
                    }

                    else
                    {
                        Console.WriteLine($"{name} does not have enough MP to cast {castSpell}!");
                    }

                }

                else if (action == "TakeDamage")
                {
                    string name = elements[1];
                    int damage = int.Parse(elements[2]);
                    string attacker = elements[3];

                    
                    heroes[name][0] -= damage;

                    if (heroes[name][0] > 0)
                    {
                        Console.WriteLine($"{name} was hit for {damage} HP by {attacker} and now has {heroes[name][0]} HP left!");
                    }

                    else
                    {
                        Console.WriteLine($"{name} has been killed by {attacker}!");
                        heroes.Remove(name);
                    }

                }
                else if (action == "Recharge")
                {
                    string name = elements[1];
                    int amount = int.Parse(elements[2]);

                    if (heroes[name][1] + amount > 200)
                    {

                        amount = 200 - heroes[name][1];
                      
                       
                    }
                    Console.WriteLine($"{name} recharged for {amount} MP!");
                    heroes[name][1]+= amount;
                }

                else if (action == "Heal")
                {
                    string name = elements[1];
                    int amount = int.Parse(elements[2]);

                    if (heroes[name][0] + amount > 100)
                    {
                        amount = 100 - heroes[name][0];
                    }

                    heroes[name][0] += amount;
                    Console.WriteLine($"{name} healed for {amount} HP!");
                }

                command = Console.ReadLine();
            }

            var sorted = heroes.OrderByDescending(h => h.Value[0]).ThenBy(h=>h.Key);

            foreach (var hero in sorted)
            {
                Console.WriteLine(hero.Key);
                Console.WriteLine($"  HP: {hero.Value[0]}");
                Console.WriteLine($"  MP: {hero.Value[1]}");
            }

        }
    }a
}
