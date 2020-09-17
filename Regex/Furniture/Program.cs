using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Furniture
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @">>(?<name>[A-Za-z]+)<<(?<price>[\d\.\d]+)!(?<quantity>\d+)";
            
            List<string> furnitures = new List<string>();
            decimal total = 0;

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Purchase")
                {
                    break;
                }

                Match match = Regex.Match(input, pattern);

                if (match.Success)
                {
                    string name = match.Groups["name"].Value;
                    decimal price = decimal.Parse(match.Groups["price"].Value);
                    int quantity = int.Parse(match.Groups["quantity"].Value);

                    furnitures.Add(name);
                    total += price*quantity;
                }
            }

            Console.WriteLine("Bought furniture:");

            foreach (var item in furnitures)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine($"Total money spend: { total:f2}");
        }
    }
}
