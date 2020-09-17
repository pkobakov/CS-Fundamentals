using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;

namespace Followers
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<int>> record = new Dictionary<string, List<int>>();
            int like = 0;
            int comment = 0;

            string command = Console.ReadLine();
            while (command!= "Log out")
            {
                string[] elements = command.Split(": ", StringSplitOptions.RemoveEmptyEntries);
                string operation = elements[0];
                string username = elements[1];
                switch (operation)
                {

                    case "New follower":

                        if (!record.ContainsKey(username))
                        {
                            record.Add(username, new List<int> {like, comment });
                        }
                    
                        break;

                    case "Like":
                        int newLike = int.Parse(elements[2]);

                        if (!record.ContainsKey(username))
                        {
                            record.Add(username, new List<int> {like,comment});
                            record[username][like] += newLike;
                            break;
                        }

                        record[username][0] += newLike;
                            break;

                    case "Comment":

                        if (!record.ContainsKey(username))
                        {
                            record.Add(username, new List<int> { like, comment});
                            record[username][1]++;
                            break;
                        }

                        record[username][1]++;
                        break;

                    case "Blocked":

                        if (record.ContainsKey(username))
                        {
                            record.Remove(username);
                            break;
                        }

                        Console.WriteLine($"{username} doesn't exist.");

                        break;
                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"{record.Count} followers");

            foreach (var pair in record.OrderByDescending(v=>v.Value[like]).ThenBy(v=>v.Key))
            {
                Console.WriteLine($"{pair.Key}: {pair.Value[0]+pair.Value[1]}");
            }

        }
    }
}
