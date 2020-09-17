using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text.RegularExpressions;

namespace Message_Translator
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            Regex pattern = new Regex (@"(!)(?<command>[A-Z][a-z]{2,})(\1).([[])(?<message>[A-Za-z]{8,})([]])");

            for (int i = 0; i < count; i++)
            {
                string message = Console.ReadLine();
                Match valid = pattern.Match(message);

                if (valid.Success)
                {
                    string line = valid.Groups["message"].Value;

                    Console.Write($"{valid.Groups["command"]}: ");

                    foreach (var ch in line)
                    {
                        int number = ch;

                        Console.Write($"{number} ");
                    }

                    Console.WriteLine();
                }

                else
                {
                    Console.WriteLine("The message is invalid");
                }
                
            }
        }
    }
}
