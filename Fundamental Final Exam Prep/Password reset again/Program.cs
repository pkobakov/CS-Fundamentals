using System;
using System.Linq;
using System.Text;

namespace Password_reset_again
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string command = Console.ReadLine();
            StringBuilder rawPassword = new StringBuilder();

            while (command!="Done")
            {
                string[] commandElements = command.Split();
                string edit = commandElements[0];

                if (edit == "TakeOdd")
                {
                    
                    for (int i = 1; i <= input.Length-1; i+=2)
                    {
                        rawPassword.Append(input[i]);
                    }
                    input = rawPassword.ToString();
                    Console.WriteLine(input);
                }

                else if (edit == "Cut")
                {
                    int index = int.Parse(commandElements[1]);
                    int length = int.Parse(commandElements[2]);

                    string substring = input.Substring(index, length);
                    int indexOf = input.IndexOf(substring);

                    
                        input = input.Remove(indexOf, substring.Length);
                    
                    

                    Console.WriteLine(input);

                }

                else if (edit == "Substitute")
                {
                    string substring = commandElements[1];
                    string substitude = commandElements[2];

                    if (input.Contains(substring))
                    {
                        input = input.Replace(substring, substitude);

                        Console.WriteLine(input);
                    }

                    else
                    {
                        Console.WriteLine("Nothing to replace!");
                    }
                }

                command = Console.ReadLine();
            }

            
            Console.WriteLine($"Your password is: {input}");
        }
    }
}
