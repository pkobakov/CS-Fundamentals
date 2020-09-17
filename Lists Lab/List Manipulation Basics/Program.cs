using System;
using System.Collections.Generic;
using System.Linq;

namespace List_Manipulation_Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> line = Console.ReadLine().Split().Select(int.Parse).ToList(); //четем лист от вход

            string command = string.Empty; // променлива за командата

            while ((command = Console.ReadLine()) != "end")
            {
                if (command == "end")
                {
                    break;
                }

                string[] commandParts = command.Split(); //масив от елементите на командата

                switch (commandParts[0])
                {
                    case "Add":
                        int numberToAdd = int.Parse(commandParts[1]);
                        line.Add(numberToAdd);break;
                    case "Remove":
                        int numberToRemove = int.Parse(commandParts[1]);
                        line.Remove(numberToRemove);break;
                    case "RemoveAt":
                        int indexToRemove = int.Parse(commandParts[1]);
                        line.RemoveAt(indexToRemove); break;
                    case "Insert":
                        int numberToInsert = int.Parse(commandParts[1]);
                        int indexToInsert = int.Parse(commandParts[2]);
                        line.Insert(indexToInsert,numberToInsert);break;
                }
            }

            Console.WriteLine(string.Join(' ', line));
        }
    }
}
