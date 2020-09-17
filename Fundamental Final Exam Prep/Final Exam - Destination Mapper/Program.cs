using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Linq.Expressions;

namespace Final_Exam___Destination_Mapper
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Regex pattern = new Regex(@"(?<opentab>[=]|[\/]{1})(?<destination>[A-Z]{1}[A-z]{2,})(?<closetab>\1)");
            MatchCollection destinations = pattern.Matches(input);
            List<string> destinationsList = new List<string>();
            int travelPoints = 0;
            foreach  (Match country in destinations)
            {
                travelPoints += country.Groups["destination"].Length;
                destinationsList.Add(country.Groups["destination"].Value);
            }

            Console.WriteLine($"Destinations: {string.Join(", ", destinationsList)}");
            Console.WriteLine($"Travel Points: {travelPoints}");
        } 
    }
}

