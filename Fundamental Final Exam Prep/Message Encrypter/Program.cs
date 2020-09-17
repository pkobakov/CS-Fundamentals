using System;
using System.Text.RegularExpressions;

namespace Message_Encrypter
{
    class Program
    {
        static void Main(string[] args)
        {
            int messages = int.Parse(Console.ReadLine());
            Regex pattern = new Regex(@"(\*|@)(?<tag>[A-Z][a-z]{2,})(\1).\s(?<code>[[][A-Za-z][]][|][[][A-Za-z][]][|][[][A-Za-z][]][|]$)");

            for (int i = 0; i < messages; i++)
            {
                string input = Console.ReadLine();
                Match valid = pattern.Match(input);

                if (valid.Success)
                {
                    Console.Write($"{ valid.Groups["tag"].Value}: ");

                    string codeToEnrypt = valid.Groups["code"].Value;
                    codeToEnrypt = codeToEnrypt.Replace("[","").Replace("]", "").Replace("|", "");
                    

                    foreach (var ch in codeToEnrypt)
                    {
                        Console.Write($"{(int)(ch)} ");
                    }

                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("Valid message not found!");
                }
            }
           
        }
    }
}
