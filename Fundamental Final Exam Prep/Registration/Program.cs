using System;
using System.Text.RegularExpressions;

namespace Registration
{
    class Program
    {
        static void Main(string[] args)
        {
            int registrations = int.Parse(Console.ReadLine());
            Regex pattern = new Regex(@"(U\$)(?<username>[A-Z]{1}[a-z]{2,})(\1)(P\@\$)(?<password>[A-Za-z]{5,}[0-9]+)(\3)");
            

            int successfulRegistrationsCount = 0;

            for (int i = 0; i < registrations; i++)
            {
                string input = Console.ReadLine();
                Match valid = pattern.Match(input);

                if (valid.Success)
                {
                    successfulRegistrationsCount++;

                    Console.WriteLine("Registration was successful");
                    Console.WriteLine($"Username: {valid.Groups["username"].Value}, Password: {valid.Groups["password"].Value}");
                    
                }

                else
                {
                    Console.WriteLine($"Invalid username or password");
                    
                }
            }

            Console.WriteLine($"Successful registrations: {successfulRegistrationsCount}");
        }
    }
}
