using System;
using System.Collections.Generic;
using System.Linq;

namespace Warrior_s_Quest
{
    class Program
    {
        static void Main(string[] args)
        {
            string ciphere = Console.ReadLine();

            string command = Console.ReadLine();

            while (command!= "For Azeroth")
            {
                var elements = command.Split();

                if (elements[0] == "GladiatorStance")
                {
                    ciphere = ciphere.ToUpper();
                    Console.WriteLine(ciphere);
                }
                else if (elements[0] == "DefensiveStance")
                {
                    ciphere = ciphere.ToLower();
                    Console.WriteLine(ciphere);

                }
                else if (elements[0] == "Dispel")
                {
                    var index = int.Parse(elements[1]);
                    char letter = char.Parse(elements[2]);
                   

                    if (index >= 0 && index < ciphere.Length)
                    {
                        char[] ciphereChars = ciphere.ToCharArray();
                        ciphereChars[index] = letter;
                        ciphere = new string(ciphereChars);
                        
                        Console.WriteLine("Success!");

                    }
                    else
                    {
                        Console.WriteLine("Dispel too weak.");
                    }

                }
                else if (elements[0] == "Target")
                {
                    var substring1 = elements[2];

                    if (elements[1] == "Change")
                    {
                        var substring2 = elements[3];

                        if (ciphere.Contains(substring1))
                        {
                            ciphere = ciphere.Replace(substring1, substring2);
                            Console.WriteLine(ciphere);
                        }
                    }

                    else if (elements[1] == "Remove")
                    {
                        if (ciphere.Contains(substring1))
                        {
                           var indexOf = ciphere.IndexOf(substring1);
                            ciphere = ciphere.Remove(indexOf,substring1.Length);
                            Console.WriteLine(ciphere);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Command doesn't exist!");
                    }
                }
                else
                {
                    Console.WriteLine("Command doesn't exist!");
                }


                command = Console.ReadLine();
            }
        }
    }
}
