using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace Mirror_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Regex pattern = new Regex(@"([#|@]{1})(?<firstword>[A-z]{3,})(\1)([#|@]{1})(?<secondword>[A-z]{3,})(\1)");
            MatchCollection match = pattern.Matches(input);
            List<string> pairs = new List<string>();
            int noMirrors = 0;
            int counter = 0;

            if (!pattern.IsMatch(input))
            {
                Console.WriteLine("No word pairs found!");
            }

            else
            {  
                counter = match.Count;
                Console.WriteLine($"{counter} word pairs found!");

                foreach (Match word in match)
                {
                    string firstWord = word.Groups["firstword"].Value;
                    string secondWord = word.Groups["secondword"].Value;

                    var myArray = firstWord.ToCharArray();
                    Array.Reverse(myArray);
                    string reversedFirstWord = string.Concat(myArray);


                    if (reversedFirstWord.Equals(secondWord))
                    {

                        string combination = $"{firstWord} <=> {secondWord}";
                        pairs.Add(combination);
                        
                    }

                    else
                    {
                        noMirrors++;
                    }

                }

            }

            if (noMirrors == counter)
            {
                Console.WriteLine("No mirror words!");
            }

            else
            {
                Console.WriteLine("The mirror words are:");
                Console.WriteLine(string.Join(", ", pairs));
            }
            
        }
    }
}
