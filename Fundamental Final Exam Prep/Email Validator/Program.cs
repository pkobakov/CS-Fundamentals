using System;
using System.Linq;
using System.Text;

namespace Email_Validator
{
    class Program
    {
        static void Main(string[] args)
        {
            string email = Console.ReadLine();

            
            while (true)
            {
                string [] input = Console.ReadLine().Split();
                string command = input[0];
                

                if (command == "Complete")
                {
                    break;
                }

                else if (command == "Make")
                {
                    if (input[1] == "Upper")
                    {
                        email = email.ToUpper();
                        Console.WriteLine(email);
                    }

                    else if (input[1] == "Lower")
                    {
                        email = email.ToLower();
                        Console.WriteLine(email);
                    }

                }

                else if (command == "GetDomain")
                {
                    int count = int.Parse(input[1]);

                    foreach (var letter in email.TakeLast(3))
                    {
                        Console.Write(letter);
                    }

                    Console.WriteLine();
                    
                }

                else if (command == "GetUsername")
                {

                    if (!email.Contains('@'))
                    {
                        Console.WriteLine($"The email {email} doesn't contain the @ symbol.");
                        continue;
                    }

                    StringBuilder user = new StringBuilder();

                    for (int i = 0; i < email.Length; i++)
                    {

                        if (email[i] == '@')
                        {
                            break;
                        }
                        user.Append(email[i]);
                    }

                    Console.WriteLine(user);
                }

                else if (command == "Replace")
                {
                    string replacedEmail = string.Empty;

                    replacedEmail = email.Replace(input[1], "-");

                    Console.WriteLine(replacedEmail);
                }

                else if (command == "Encrypt")
                {
                    foreach (var symbol in email)
                    {
                        int number = symbol;

                        Console.Write(number+" ");
                    }

                    Console.WriteLine();
                }

            }
        }
    }
}
