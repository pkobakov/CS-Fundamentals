using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Linq;
using System.Dynamic;
using System.Reflection.Metadata;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {


            int lines = int.Parse(Console.ReadLine());
            Dictionary<string, List<string>> repertoar = new Dictionary<string, List<string>>();


            for (int i = 0; i < lines; i++)
            {
                string[] information = Console.ReadLine().Split('|').ToArray();
                string piece = information[0];
                string name = information[1];
                string key = information[2];

                repertoar.Add(piece, new List<string> { name, key });
                
            }

            string command = Console.ReadLine();
            while (command!="Stop")
            {
                string[] intructions = command.Split('|');
                string operation = intructions[0];

                switch (operation)
                {
                    case "Add":
                        string piece = intructions[1];
                        string composer = intructions[2];
                        string key = intructions[3];

                        if (repertoar.ContainsKey(piece))
                        {
                            Console.WriteLine($"{piece} is already in the collection!");
                        }

                        else
                        {
                            repertoar.Add(piece, new List<string> { composer, key });

                            Console.WriteLine($"{piece} by {composer} in {key} added to the collection!");
                        }

                        break;

                    case "Remove":
                        piece = intructions[1];

                        if (repertoar.ContainsKey(piece))
                        {
                            repertoar.Remove(piece);

                            Console.WriteLine($"Successfully removed {piece}!");
                        }

                        else
                        {
                            Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
                        }

                        break;

                    case "ChangeKey":
                        piece = intructions[1];
                        string newKey = intructions[2];

                        if (repertoar.ContainsKey(piece))
                        {
                            repertoar[piece][1]=newKey;
                            Console.WriteLine($"Changed the key of {piece} to {newKey}!");
                        }

                        else
                        {
                            Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
                        }

                        break;
                }


                command = Console.ReadLine();
            }


            foreach (var item in repertoar.OrderBy(X => X.Key).ThenBy(X => X.Value[0])) 
            {
                Console.WriteLine($"{item.Key} -> Composer: {item.Value[0]}, Key: {item.Value[1]}");
            }



        }
    }
}
