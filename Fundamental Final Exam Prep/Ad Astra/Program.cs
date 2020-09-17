using System;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection.Metadata;
using System.Text.RegularExpressions;

namespace Ad_Astra
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            Regex pattern = new Regex(@"((?<separator>[#]|[\|]){1})(?<item>[A-Za-z\s]+)(\1)(?<expiration>[0-9]{2}\/[0-9]{2}\/[0-9]{2})(\1)(?<calories>[0-9]+)(\1)");

            int calPerDay = 2000;

            MatchCollection matches = pattern.Matches(text);
            
            List<Items> itemlist = new List<Items>();
            int caloriesSum = 0;


            if (pattern.IsMatch(text))
            {
                foreach (Match match in matches)
                {
                    string item = match.Groups["item"].Value;
                    string expiration = match.Groups["expiration"].Value;
                    int calories = int.Parse(match.Groups["calories"].Value);
                    Items currentItem = new Items(item,expiration,calories);
                    itemlist.Add(currentItem);

                }
            }

            foreach (var item in itemlist)
            {
                caloriesSum += item.Calories;
            }

            int days = caloriesSum/calPerDay;

            Console.WriteLine($"You have food to last you for: {days} days!");

            foreach (var item in itemlist)
            {
                Console.WriteLine($"Item: {item.Item}, Best before: {item.Expiration}, Nutrition: {item.Calories}");
            }
        }
    }

    public class Items
    {
        public string Item { get; set; }
        public string Expiration { get; set; }
        public int Calories { get; set; }

        public Items(string item, string expiration, int calories)
        {
            Item = item;
            Expiration = expiration;
            Calories = calories;
        }
    }
}
