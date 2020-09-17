using System;
using System.Linq;
using System.Text;

namespace The_Imitation_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            string encryptedMessage = Console.ReadLine();
            StringBuilder result = new StringBuilder(encryptedMessage);

            string command = Console.ReadLine();

            while (command!= "Decode")
            {
                string[] instructions = command.Split('|').ToArray();
                string operation = instructions[0];

                
                switch (operation)
                {
                    case "Move":
                        int countOfLetterToMove = int.Parse(instructions[1]);
                        string substring = result.ToString().Substring(0, countOfLetterToMove);
                        result.Append(substring);

                        result.Remove(0, substring.Length);
                     

                        break;

                    case "Insert":
                        int index = int.Parse(instructions[1]);
                        string value = instructions[2];

                        result.Insert(index, value);


                        break;

                    case "ChangeAll":
                        substring = instructions[1];
                        string replacement = instructions[2];

                        result.Replace(substring, replacement);

                        break;

                }
                command = Console.ReadLine();
            }

            Console.WriteLine($"The decrypted message is: {result}");
        }
    }
}
