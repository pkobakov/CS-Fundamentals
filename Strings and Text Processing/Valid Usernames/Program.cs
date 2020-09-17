using System;
using System.Collections.Generic;

namespace Valid_Usernames
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
            var validUserName = new List<string>();

            for (int i = 0; i < input.Length; i++)
            {
                string current = input[i];

                if (current.Length>=3 && current.Length<=16)
                {
                    bool valid = true;

                    for (int k = 0; k < current.Length; k++)
                    {
                        if (!(char.IsLetterOrDigit(current[k]) || current[k] == '-' || current[k] == '_'))
                        {
                            valid = false;
                        }
                    }

                    if (valid)
                    {
                        validUserName.Add(current);
                    }
                }
               
            }

            Console.WriteLine(String.Join(Environment.NewLine, validUserName));
        }
    }
}
