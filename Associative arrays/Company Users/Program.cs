using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;

namespace Company_Users
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> company = new Dictionary<string, List<string>>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "End")
                {
                    break;
                }

                string[] elements = input.Split(" -> ");
                string name = elements[0];
                string ID = elements[1];

                if (!company.ContainsKey(name))
                {
                    company.Add(name, new List<string>());
                    company[name].Add(ID);
                }

                // проверявам записаните ID на конкретна компания;

                if (!company[name].Contains(ID)) // !!!!!!!
                {
                    company[name].Add(ID);
                }
            }

            foreach (var kvp in company.OrderBy(kvp=>kvp.Key))
            {
                Console.WriteLine(kvp.Key);
                foreach (var id in kvp.Value)
                {
                    Console.WriteLine($"-- {id}");
                }

            }
            
        }
    }
}
