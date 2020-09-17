using System;
using System.Collections.Generic;
using System.Linq;


namespace The_Pianist
{
    class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            List<Composer> pieces = new List<Composer>();
            

            for (int i = 0; i < lines; i++)
            {
                string[] information = Console.ReadLine().Split('|').ToArray();
                string piece = information[0];
                string name = information[1];
                string key = information[2];

                Composer currentPiece = new Composer(piece, name, key);

                pieces.Add(currentPiece);
            }

            string command = Console.ReadLine();

            while (command!= "Stop")
            {
                string[] intructions = command.Split('|');
                string operation = intructions[0];

                switch (operation)
                {
                    case "Add": 
                        string composition = intructions[1];
                        string name = intructions[2];
                        string key = intructions[3];
                        int match = 0;
                        foreach (var item in pieces)
                        {
                            if (item.Piece == composition)
                            {
                                match++;

                                Console.WriteLine($"{composition} is already in the collection!");
                                break;
                            }
                           
                        }

                        if (match<1)
                        {
                            Composer newPiece = new Composer(composition, name, key);
                            pieces.Add(newPiece);

                            Console.WriteLine($"{composition} by {name} in {key} added to the collection!");
                        }

                        break;


                    case "Remove":
                        string piece = intructions[1];
                        match = 0;

                        foreach (var item in pieces)
                        {
                            if (item.Piece == piece)
                            {
                                pieces.Remove(item);
                                match++;
                                Console.WriteLine($"Successfully removed {piece}!");

                                break;
                            }
                        }

                        if (match<1)
                        {
                            Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
                        }

                        break;


                    case "ChangeKey":
                        piece = intructions[1];
                        string newKey = intructions[2];
                        match = 0;
                        foreach (var item in pieces)
                        {
                            if (item.Piece == piece)
                            {
                                item.Key = newKey;

                                Console.WriteLine($"Changed the key of {piece} to {newKey}!");
                                break;
                            }
                        }

                        if (match<0)
                        {
                            Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
                        }

                        break;
                }

                command = Console.ReadLine();
            }

            foreach (var item in pieces.OrderBy(x=>x.Piece).ThenBy(x=>x.Name))
            {
                Console.WriteLine($"{item.Piece} -> Composer: {item.Name}, Key: {item.Key}");
            }

        }
    }

    public class Composer
    {
        public string Piece { get; set; }
        public string Name { get; set; }
        public string Key { get; set; }

        public Composer(string piece, string name, string key)
        {
            Piece = piece;
            Name = name;
            Key = key;
        }
    }
}

