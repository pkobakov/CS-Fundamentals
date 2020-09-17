using System;
using System.Collections.Specialized;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Channels;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Validator(input);
        }

        public static void Validator (string password)
        {
            
         

            if (password.Length >=6 && password.Length<=10 && password.Count(char.IsDigit)>=2 && password.All(char.IsLetterOrDigit))
            {
                Console.WriteLine("Password is valid");
            }

            else
            {
                if (!(password.Length >= 6 && password.Length <= 10))
                {
                    Console.WriteLine("Password must be between 6 and 10 characters");
                }

                if (!password.All(char.IsLetterOrDigit))
                {
                    Console.WriteLine("Password must consist only of letters and digits");
                }

                if (!(password.Count(char.IsDigit) >= 2))
                {
                    Console.WriteLine("Password must have at least 2 digits");
                }

                
                
            }

          
        }
    }
}
