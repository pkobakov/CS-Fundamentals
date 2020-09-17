using System;

namespace Preparation_for_exam
{
    class Program
    {
        static void Main(string[] args)
        {
            double income = double.Parse(Console.ReadLine());
            int months = int.Parse(Console.ReadLine());
            double expenses = double.Parse(Console.ReadLine());

            double casual = income -(income * 0.7);
            double savingsPerMonth = income - (expenses + casual);

            double savedMoney = months * savingsPerMonth;
            double percent = (savingsPerMonth / income) * 100;

            Console.WriteLine($"She can save {percent:f2}%");
            Console.WriteLine($"{savedMoney:f2}");


        }
    }
}
