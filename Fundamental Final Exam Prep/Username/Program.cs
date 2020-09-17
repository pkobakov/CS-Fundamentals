using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Username
{
    class Program
    {
        static void Main(string[] args)
        {

            string input  = Console.ReadLine();
            string command = Console.ReadLine();
            
            
            while (command!= "Sign up")
            {
                string[] element = command.Split();
                string operation = element[0];
                
                
                switch (operation)
                {
                    case "Case":
                        if (element[1] == "lower")
                        {
                            input = input.ToLower();
                            Console.WriteLine(input);
                        }
                        else if (element[1] == "upper")
                        {
                            input = input.ToUpper();
                            Console.WriteLine(input);
                        }
                        break;

                    case "Reverse":
                        int startIndex = int.Parse(element[1]);
                        int endIndex = int.Parse(element[2]);
                        StringBuilder test = new StringBuilder();

                        if (startIndex>=0 && endIndex<=input.Length)
                        {
                            for (int i = startIndex; i <= endIndex; i++)
                            {
                                test.Append(input[i]);
                            }

                            List<char> result = test.ToString().ToCharArray().Reverse().ToList();

                            Console.WriteLine(string.Join( "", result));
                        }
                        break;

                    case "Cut":
                        string substring = element[1];

                        if (!input.Contains(substring))
                        {
                            Console.WriteLine($"The word {input} doesn't contain {substring}.");
                        }

                        else
                        {
                            int index = input.IndexOf(substring);
                            input = input.Remove(index, substring.Length);
                            Console.WriteLine(input);

                        }
                        break;

                    case "Replace":
                        char symbol = char.Parse(element[1]);

                        if (input.Contains(symbol))
                        {
                            input = input.Replace(symbol, '*');
                            Console.WriteLine(input);
                        }
                            break;

                    case "Check":

                        char validation = char.Parse(element[1]);

                        if (input.Contains(validation))
                        {
                            Console.WriteLine("Valid");
                        }

                        else
                        {
                            Console.WriteLine($"Your username must contain {validation}.");
                        }
                        break;
                }


                command = Console.ReadLine();
            }
        }
    }
}
