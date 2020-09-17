using System;
using System.Collections.Generic;

namespace Word_Synonyms
{
    class Program
    {
        static void Main(string[] args)
        {
            int pairsCount  = int.Parse(Console.ReadLine());
            Dictionary<string,List<string>>synonymsDictionary = new Dictionary<string,List<string>>();

            for (int i = 0; i < pairsCount; i++)
            {
                //ключ
                string word = Console.ReadLine();
                //value
                string synonym = Console.ReadLine();

                if (synonymsDictionary.ContainsKey(word))
                {
                    synonymsDictionary[word].Add(synonym);
                }
                else
                {
                    synonymsDictionary.Add(word,new List<string>());
                    synonymsDictionary[word].Add(synonym);
                }
            }
            foreach (var word in synonymsDictionary)
            {
                Console.WriteLine($"{word.Key} - {string.Join(", ", word.Value)}");
            }
        }
    }
}
