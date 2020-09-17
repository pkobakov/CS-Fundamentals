using System;
using System.Collections.Generic;
using System.Linq;

namespace _09.Legendary_Farming
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> keyMaterials = new Dictionary<string, int>();

            Dictionary<string, int> junkMaterials = new Dictionary<string, int>();

            keyMaterials["motes"]  = 0;
            keyMaterials["fragments"] = 0; //даваме първоначална стойност 0, защото по условие нулевите  стойности също се изпиват накрая;
            keyMaterials["shards"] = 0;

            bool hasToBreak = false;

            while (!hasToBreak)
            {
                string[] materials = Console.ReadLine().ToLower().Split(); //променяме главните букви, тк изхода трябва да е с малки;
                
                hasToBreak = false;

                for (int i = 0; i < materials.Length; i+=2) // през 2, защото материалите се подават като двойка (материал, к-во);
                {
                    int quantity = int.Parse(materials[i]);
                    string material = materials[i+1];
                    

                    if (material == "motes")
                    {
                        keyMaterials[material]+= quantity;

                        if (keyMaterials[material]>=250)
                        {
                            Console.WriteLine($"Dragonwrath obtained!");
                            keyMaterials[material] -= 250; // по условие остава само остатъка;
                            hasToBreak = true;
                            break;
                        }
                    }
                    else if (material == "fragments")
                    {

                        keyMaterials[material] += quantity;

                        if (keyMaterials[material] >= 250)
                        {
                            Console.WriteLine($"Valanyr obtained!");
                            keyMaterials[material] -= 250; // по условие остава само остатъка;
                            hasToBreak = true;
                            break;
                        }
                    }
                    else if (material == "shards")
                    {

                        keyMaterials[material] += quantity;

                        if (keyMaterials[material] >= 250)
                        {
                            Console.WriteLine($"Shadowmourne obtained!");
                            keyMaterials[material] -= 250; // по условие остава само остатъка;
                            hasToBreak = true;
                            break;
                        }
                    }
                    else
                    {
                        if (!junkMaterials.ContainsKey(material))
                        {
                            junkMaterials[material] = 0;
                        }

                        junkMaterials[material] += quantity;
                    }
                }

                keyMaterials = keyMaterials.OrderByDescending(x => x.Value).ThenBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);

                junkMaterials = junkMaterials.OrderByDescending(x => x.Value).ThenBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);

                foreach (var pair in keyMaterials)
                {
                    Console.WriteLine($"{pair.Key}: {pair.Value}");
                }

                foreach (var pair in junkMaterials)
                {
                    Console.WriteLine($"{pair.Key}: {pair.Value}");
                }
            }
        }
    }
}