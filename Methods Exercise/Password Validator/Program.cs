using System;

namespace Password_Validator
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            PasswordCheck(password);
        }
        static void PasswordCheck(string password)
        {
            bool valid = true;
            if (password.Length < 6 || password.Length > 10)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
                valid = false;
            }
            if (ContainsDigitsAndNums (password) == false)
            {
                Console.WriteLine("Password must consist only of letters and digits");
                valid = false;
            }
            if (DigitsCounter(password)<2)
            {
                Console.WriteLine("Password must have at least 2 digits");
                valid = false;
            }
            if (valid == true)
            {
                Console.WriteLine("Password is valid");
            }
         
        }
        static bool ContainsDigitsAndNums(string password)
        {
            for (int i = 0; i < password.Length; i++)
            { 
                if (!((password[i]>=48&&password[i]<=57)||
                    (password[i]>=65 &&password[i]<=90)||
                    (password[i]>=97 && password[i]<=122)))
                {
                    return false;
                }
            }
            return true;
        }
        static int DigitsCounter(string password) 
        {
            int digitsCounter = 0;

            for (int i = 0; i < password.Length; i++)
            {
                if (password[i]>=48&&password[i]<=57)
                {
                    digitsCounter++;
                }
            }
            return digitsCounter;
        }
	


    }
}
