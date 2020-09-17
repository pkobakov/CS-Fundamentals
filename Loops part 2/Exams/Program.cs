using System;

namespace Exams
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = int.Parse(Console.ReadLine());
            
            double sneakers = budget - (budget * 0.4);
            double equipment = sneakers - (sneakers * 0.2);
            double ball = equipment*0.25;
            double accessoaries = ball * 0.2;
            
            double totalExpenses = budget + sneakers + equipment + ball + accessoaries;

            Console.WriteLine($"{totalExpenses:f2}");
    }   }
}
