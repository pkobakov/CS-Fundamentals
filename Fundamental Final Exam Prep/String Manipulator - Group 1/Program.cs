
using System;
using System.Text;

namespace String_Manipulator___Group_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string theString = Console.ReadLine();

            while (true)
            {
                string[] commands = Console.ReadLine().Split();

                if (commands[0] == "End")
                {
                    break;
                }

                else if (commands[0] == "Translate")
                {
                    char toReplace = char.Parse(commands[1]);
                    char replacement =char.Parse(commands[2]);

                    if (theString.Contains(toReplace))
                    {
                        theString = theString.Replace(toReplace,replacement);

                        Console.WriteLine(theString);
                    }
                }

                else if (commands[0] == "Includes")
                {
                    string toCheck = commands[1];
                    bool contains = true;

                    if (theString.Contains(toCheck))
                    {
                        Console.WriteLine(contains);
                    }

                    else
                    {
                        Console.WriteLine(!contains);
                    }
                }

                else if (commands[0] == "Start")
                {
                    string toCheck = commands[1];
                    StringBuilder test = new StringBuilder();

                    for (int i = 0; i < toCheck.Length; i++)
                    {
                        test.Append(theString[i]);
                    }

                    if (test.Equals(toCheck))
                    {
                        Console.WriteLine("True");
                    }

                    else
                    {
                        Console.WriteLine("False");
                    }
                    
                }

                else if (commands[0] == "Lowercase")
                {
                    theString = theString.ToLower();

                    Console.WriteLine(theString);
                }

                else if (commands[0] == "FindIndex")
                {
                    char index = char.Parse(commands[1]);

                    if (theString.Contains(index))
                    {
                        for (int i = theString.Length-1; i >= 0; i--)
                        {
                            char test = theString[i];
                            if (test.Equals(index))
                            {
                                Console.WriteLine(i);
                                break;
                            }
                        }
                    }
                    
                }

                else if (commands[0] == "Remove")
                {
                    int startIndex = int.Parse(commands[1]);
                    int count = int.Parse(commands[2]);

                    theString = theString.Remove(startIndex, count);

                    Console.WriteLine(theString);
                }
            }
        }
    }
}
