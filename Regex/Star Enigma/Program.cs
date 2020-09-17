using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Star_Enigma
{
    class Program
    {
        static void Main(string[] args)
        {
            int messageCount = int.Parse(Console.ReadLine()); //четем бр. съобщения;
            string firstPattern = @"[STARstar]"; // определяме съвпадението, по което ще се отделят буквите STARstar;

            List<string> attacked = new List<string>();
            List<string> destroyed = new List<string>();


            for (int i = 1; i <= messageCount; i++)
            {
                string message = Console.ReadLine();//четем текущото съобщение;

                MatchCollection lettersMatched = Regex.Matches(message, firstPattern); // маркираме всички съвпадения;

                int lettersCount = lettersMatched.Count; // броим колко общо съвпадения има; 

                string newMessage = "";// създаваме ново празно съобщение, което ще се попълни с букви с нови стойности, изчислени както е по условие;

                foreach (var letter in message)
                {
                    newMessage += (char)(letter - lettersCount); // минава се през всяка буква от съобщението и се обновява като се намалява стойността й с броят съвпадения;
                }


                string planetPattern = @"@(?<planetName>[A-Za-z]+)[^@\-!:>]*:(?<population>[0-9]+)[^\@\-!:>]*!(?<type>A|D)![^\@\-!:>]*->(?<soldiers>[0-9]+)";

                Match planetElements = Regex.Match(newMessage, planetPattern);

                if (planetElements.Success)
                {
                    string planetName = planetElements.Groups["planetName"].Value;
                    string type = planetElements.Groups["type"].Value;

                    if (type == "A")
                    {
                        attacked.Add(planetName);

                    }
                    else
                    {
                        destroyed.Add(planetName);
                    }

                }

            }
            Console.WriteLine($"Attacked planets: {attacked.Count}");

            foreach (var planet in attacked.OrderBy(x=>x))
            {
                Console.WriteLine("-> " + planet);
            }

            Console.WriteLine($"Destroyed planets: {destroyed.Count}");

            foreach (var planet in destroyed.OrderBy(x => x))
            {
                Console.WriteLine("-> "+ planet);
            }
        }
    }
}