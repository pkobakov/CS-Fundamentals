using System;
using System.Text;

namespace Password_Reset
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            string [] command = Console.ReadLine().Split();
            string operation = command[0]; 

            while (operation != "Done")
            {
                if (operation == "TakeOdd")
                {
                    StringBuilder rawPassword = new StringBuilder();

                    for (int i = 1; i < password.Length; i += 2)
                    {
                        rawPassword = rawPassword.Append(password[i]);
                    }

                    password = rawPassword.ToString();
                    Console.WriteLine(password);
                }
                else if (operation == "Cut")
                {
                    int index = int.Parse(command[1]);
                    int length = int.Parse(command[2]);
                    int test = index + length;

                    if (test<=password.Length)
                    {
                        string substr = password.Substring(index, length);
                        int subIndex = password.IndexOf(substr);
                        password = password.Remove(subIndex, substr.Length);
                        Console.WriteLine(password);
                    }
                    
                }

                else if (operation == "Substitute")
                {
                    
                    string substring = command[1];
                    string substitude = command[2];

                    if (password.Contains(substring))
                    {
                        password = password.Replace(substring,substitude);

                        Console.WriteLine(password);
                    }
                    else
                    {
                        Console.WriteLine("Nothing to replace!");
                      
                    }
                    
                }

                command = Console.ReadLine().Split();
                operation = command[0];
            }

            Console.WriteLine("Your password is: " + password);

            
        }
    }
}
