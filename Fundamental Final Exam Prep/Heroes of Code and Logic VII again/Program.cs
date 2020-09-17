using System;
using System.Collections.Generic;
using System.Linq;

namespace Heroes_of_Code_and_Logic_VII_again
{
    class Program
    {
        static void Main(string[] args)
        {
            int heroes = int.Parse(Console.ReadLine());
            Dictionary<string, List<int>> hero = new Dictionary<string, List<int>>();
            int HP = 0;
            int MP = 0;
            for (int i = 0; i < heroes; i++)
            {
                string[] heroInput = Console.ReadLine().Split();

                string heroName = heroInput[0];
                HP = int.Parse(heroInput[1]);
                MP = int.Parse(heroInput[2]);

                hero.Add(heroName, new List<int>(){HP,MP});
            }

            string command = Console.ReadLine();


            while (command != "End")
            {
                string[] commandElements = command.Split(" - ");
                string action = commandElements[0];
                string name = commandElements[1];
                int currentHP = hero[name][0];
                int currentMP = hero[name][1];

                switch (action)
                {
                    case "CastSpell":
                        int neededMP = int.Parse(commandElements[2]);
                        string spellName = commandElements[3];


                        if (currentMP >= neededMP)
                        {
                            currentMP -= neededMP;

                            Console.WriteLine($"{name} has successfully cast {spellName} and now has {currentMP} MP!");
                        }

                        else
                        {
                            Console.WriteLine($"{name} does not have enough MP to cast {spellName}!");
                        }

                        hero[name][1]=currentMP;

                        break;


                    case "TakeDamage":
                        int damage = int.Parse(commandElements[2]);
                        string attacker = commandElements[3];
                        
                            currentHP -= damage;

                            if (currentHP > 0)
                            {
                                Console.WriteLine($"{name} was hit for {damage} HP by {attacker} and now has {currentHP} HP left!"); 
                            }

                            else
                            {
                                Console.WriteLine($"{name} has been killed by {attacker}!");
                                hero.Remove(name); break;
                            }

                        hero[name][0] = currentHP;
                        break;

                    case "Recharge":
                        int amount = int.Parse(commandElements[2]);

                        currentMP += amount;

                        if (currentMP > 200)
                        {
                            Console.WriteLine($"{name} recharged for {200 - (currentMP - amount)} MP!");

                            currentMP = 200;
                        }

                        else
                        {
                            Console.WriteLine($"{name} recharged for {amount} MP!");
                        }

                        hero[name][1] = currentMP;
                        break;

                    case "Heal":
                        amount = int.Parse(commandElements[2]);
                        currentHP += amount;

                        if (currentHP > 100)
                        {
                            Console.WriteLine($"{name} healed for {100 - (currentHP - amount)} HP!");

                            currentHP = 100;
                        }

                        else
                        {
                            Console.WriteLine($"{name} healed for {amount} HP!");
                        }

                        hero[name][0] = currentHP;
                        break;
                }
               
                command = Console.ReadLine();
                
            }

            foreach (var item in hero.OrderByDescending(x => x.Value[0]).ThenBy(x => x.Key))
            {
                Console.WriteLine(item.Key);
                Console.WriteLine($" HP: {item.Value[0]}");
                Console.WriteLine($" MP: {item.Value[1]}");
            }
        }
    }
}
