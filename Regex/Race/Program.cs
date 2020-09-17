using System;
using System.Text.RegularExpressions;
using System.Linq;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace Race
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> participants = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToList();
            Dictionary<string, int> eachParticipantData = new Dictionary<string, int>();
            string input = Console.ReadLine();

            while (input!="end of race")
            {

                string namePattern = @"(?<name>[A-Za-z])";
                string distancePattern = @"\d";

                MatchCollection nameChars = Regex.Matches(input, namePattern);
                MatchCollection distanceParts = Regex.Matches(input, distancePattern);

                string name = String.Concat(nameChars);
                int distance = distanceParts.Select(x => int.Parse(x.Value)).Sum();

                if (participants.Contains(name))
                {
                    if (eachParticipantData.ContainsKey(name))
                    {
                        eachParticipantData[name] += distance;
                    }
                    else
                    {
                        eachParticipantData.Add(name, distance);
                    }
                }
                input = Console.ReadLine();
            }

            var sorted = eachParticipantData.OrderByDescending(y =>y.Value).ToList();
            

            Console.WriteLine($"1st place: {sorted[0].Key}");
            Console.WriteLine($"2nd place: {sorted[1].Key}");
            Console.WriteLine($"3rd place: {sorted[2].Key}");
        }
    }
}
