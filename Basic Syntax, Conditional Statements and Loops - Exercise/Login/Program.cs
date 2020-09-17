using System;

namespace Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string user = Console.ReadLine();
            string password = "";
           
            

            for (int i = user.Length-1; i >= 0; i--)
            {
                password+=user[i];
                
            }
            int attempt = 1;
            string login = Console.ReadLine();

            while (login!=password)
            {
                if (attempt==4)
                {
                    Console.WriteLine($"User {user} blocked!");
                    break;
                }
                Console.WriteLine($"Incorrect password. Try again.");
                login = Console.ReadLine();
                attempt++;
            }
            if (login == password)
            {
                Console.WriteLine($"User {user} logged in.");
            }
            
          
        }
    }
}
