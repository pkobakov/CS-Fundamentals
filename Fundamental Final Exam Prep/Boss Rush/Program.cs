using System;
using System.Reflection.PortableExecutable;
using System.Text.RegularExpressions;

namespace Boss_Rush
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputs = int.Parse(Console.ReadLine());
            Regex pattern = new Regex(@"^(\|)(?<Boss>[A-Z]{4,})(\1):([#])(?<Title>[A-Za-z]+\s[A-Za-z]+)([#])$");
            
            for(int i = 0; i < inputs; i++)
            {
                string theMessage = Console.ReadLine();
                Match valid = pattern.Match(theMessage);

                if (!valid.Success)
                {
                    Console.WriteLine("Access denied!");

                }

                else
                { 
                    
                    Console.WriteLine($"{valid.Groups["Boss"].Value}, The {valid.Groups["Title"].Value} ");
                    Console.WriteLine($">> Strength: {(valid.Groups["Boss"].Value).Length}");
                    Console.WriteLine($">> Armour: {(valid.Groups["Title"].Value).Length}");
                }

            }
        }
    }
}
