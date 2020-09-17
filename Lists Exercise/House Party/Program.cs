using System;
using System.Collections.Generic;
using System.Linq;

namespace House_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            // ще следим гости;
            // брой команди, които ще получим
            // 1 ред - брой команди;
            // следващи команди - "{name} is going!", "{name} is not going!";

            //Ако получите първото съобщение "{name} is going!", 
            //трябва да добавите човека, ако той не е в списъка
            //и ако той / тя е в списъка, отпечатайте на конзолата: "{name} вече е в списъка!"

            //Ако получите "{name} is not going!", трябва да премахнете човека, ако той е в списъка,
            //а ако не отпечата: "{name} не е в списъка!".
            //В края отпечатайте всички гости.;

            int commandsCount = int.Parse(Console.ReadLine());
            List<string> guests = new List<string>();

            for (int i = 0; i < commandsCount; i++)
            {
                string[] command = (Console.ReadLine().Split());
                string name = command[0];
                if (command.Length == 3)
                {

                    if (guests.Contains(name))
                    {
                        Console.WriteLine($"{name} is already in the list!");
                        
                    }
                    else
                    {
                        guests.Add(name);
                    }
                }
                else 
                {
                    if (guests.Contains(name))
                    {
                        guests.Remove(name);
                    }
                    else
                    {
                        Console.WriteLine($"{name} is not in the list!");
                    }
                    
                }
            }
            for (int i = 0; i < guests.Count; i++)
            {
                Console.WriteLine(guests[i]);
            }
        }

    }
}
