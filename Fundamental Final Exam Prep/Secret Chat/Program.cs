using System;
using System.Linq;
using System.Text;

namespace Secret_Chat
{
    class Program
    {
        static void Main(string[] args)
        {
            string  concealedMessage = Console.ReadLine();
            StringBuilder result = new StringBuilder(concealedMessage);
            string command = Console.ReadLine();

            while (command != "Reveal")
            {
                string [] elements = command.Split(":|:").ToArray();
                string operation = elements[0];

                switch (operation)
                {
                    case "InsertSpace":
                        int index = int.Parse(elements[1]);

                        result = result.Insert(index, " ");
                        Console.WriteLine(result);

                        break;

                    case "Reverse":
                        
                        string substring = elements[1];
                        string reversed = string.Empty;
                        index = result.ToString().IndexOf(substring);
                        int indexToInsert = result.Length - substring.Length;

                        for (int i = substring.Length-1; i >= 0; i--)
                        {
                           reversed+=substring[i];
                        }

                        if (result.ToString().Contains(substring))
                        {
                            result.Remove(index, substring.Length);
                            result.Insert(indexToInsert, reversed);
                            Console.WriteLine(result);
                        }

                        else
                        {
                            Console.WriteLine("error");
                        }

                        break;
                        

                    case "ChangeAll":
                        substring = elements[1];
                        string replacement = elements[2];

                        result = result.Replace(substring, replacement);
                        Console.WriteLine(result);
                        break;

                    
                }
                command = Console.ReadLine();
            }

            Console.WriteLine($"You have a new text message: {result}");
        }


    }
}
