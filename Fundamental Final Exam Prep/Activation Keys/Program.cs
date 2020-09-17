using System;
using System.Text;

namespace Activation_Keys
{
    class Program
    {
        static void Main(string[] args)
        {
            string activationKey = Console.ReadLine();
            StringBuilder sb = new StringBuilder(activationKey);
            string instructions = Console.ReadLine();

            while (instructions!="Generate")
            {
                string[] command = instructions.Split(">>>", StringSplitOptions.RemoveEmptyEntries);
                string operation = command[0];

                if (operation.Contains("Contains"))
                {
                    string substring = command[1];

                    if (activationKey.Contains(substring))
                    {
                        Console.WriteLine($"{activationKey} contains {substring}");
                    }

                    else
                    {
                        Console.WriteLine("Substring not found!");
                    }

                }

                else if (operation.Contains("Flip"))
                {
                    string direction = command[1];
                    int starIndex = int.Parse(command[2]);
                    int endIndex = int.Parse(command[3]);

                    
                    switch (direction)
                    {
                        case "Upper":
                            for (int i = starIndex; i < endIndex; i++)
                            {
                                sb[i] = char.Parse(sb[i].ToString().ToUpper());
                            }
                            break;

                        case "Lower":
                            for (int i = starIndex; i < endIndex; i++)
                            {
                                sb[i] = char.Parse(sb[i].ToString().ToLower());
                            }
                            break;
                    }
                    activationKey = sb.ToString();
                    Console.WriteLine(activationKey);
                }

                else if (operation.Contains("Slice"))
                {
                    int startIndex = int.Parse(command[1]);
                    int endIndex = int.Parse(command[2]);
                    
                    int range = endIndex - startIndex;
                    sb = sb.Remove(startIndex, range);
                    activationKey = sb.ToString();

                    Console.WriteLine(activationKey);
                   
                }
                instructions = Console.ReadLine();
            }

            Console.WriteLine($"Your activation key is: {activationKey}");
        }
    }
}
