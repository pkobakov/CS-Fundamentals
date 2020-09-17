using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Inbox_Manager
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List <string>> usersAndEmails = new Dictionary<string, List<string>>();

            while (true)
            {
                string [] command = Console.ReadLine().Split("->");
                string operation = command[0];

                if (operation == "Statistics")
                {
                    break;
                }

                else if (operation == "Add")
                {
                    string user = command[1];

                    if (!usersAndEmails.ContainsKey(user))
                    {
                        usersAndEmails.Add(user, new List<string>());
                    }

                    else
                    {
                        Console.WriteLine($"{user} is already registered");
                    }

                }

                else if (operation == "Send")
                {
                    string user = command[1];
                    string email = command[2];

                    usersAndEmails[user].Add(email);

                }

                else if (operation == "Delete")
                {
                    string user = command[1];

                    if (usersAndEmails.ContainsKey(user))
                    {
                        usersAndEmails.Remove(user);
                    }

                    else
                    {
                        Console.WriteLine($"{user} not found!");
                    }
                }
            }

            Console.WriteLine($"Users count: {usersAndEmails.Count}");


            var sorted = usersAndEmails.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key);

            foreach (var user in sorted)
            {
                
                Console.WriteLine(user.Key);

                for (int i = 0; i < user.Value.Count; i++)
                {
                    Console.WriteLine($"- {user.Value[i]}");
                }
                

            }
        }
    }
}
