using System;

namespace Movie_Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string name = Console.ReadLine();

            double budgetleft = budget;

            while (name != "ACTION")
            {
                int lettersCount = name.Length;

                if (lettersCount<=15)
                {
                    double salary = double.Parse(Console.ReadLine());
                    budgetleft -= salary;
                }
                else
                {
                    double salary2 = budgetleft * 0.20;
                    budgetleft -= salary2;
                }

                if (budgetleft < 0)
                {
                    Console.WriteLine($"We need {Math.Abs(budgetleft):f2} leva for our actors.");
                    return;
                }
                name = Console.ReadLine();
            }

            Console.WriteLine($"We are left with {Math.Abs(budgetleft):f2} leva.");
        }
    }
}
