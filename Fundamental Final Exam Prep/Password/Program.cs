using System;
using System.Text.RegularExpressions;

namespace Password
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputsCount = int.Parse(Console.ReadLine());

            Regex pattern = new Regex(@"^(.+)([>])(?<group1>[0-9]{3})[|](?<group2>[a-z]{3})[|](?<group3>[A-Z]{3})[|](?<group4>[\d\D\w\W\s\S]{3})[<](\1)$");

            for (int i = 0; i < inputsCount; i++)
            {
                string input = Console.ReadLine();
                Match valid = pattern.Match(input);
                
                if (!valid.Success)
                {
                    Console.WriteLine("Try another password!");
                }

                else
                {
                    
                    Console.WriteLine($"Password: {valid.Groups["group1"].Value}" +
                        $"{valid.Groups["group2"].Value}" +
                        $"{valid.Groups["group3"].Value}" +
                        $"{valid.Groups["group4"].Value}");
                }

            }
        }
    }
}
