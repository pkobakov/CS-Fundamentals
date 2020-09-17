using System;

namespace Care_of_Puppy
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalKgFood = int.Parse(Console.ReadLine());
            int totalGrFood = totalKgFood * 1000;
            int foodEaten = 0;
            string command = Console.ReadLine();

            while (command != "Adopted")
            {
                int grFood = int.Parse(command);

                foodEaten += grFood;

                command = Console.ReadLine();
            }
            if (totalGrFood >= foodEaten)
            {
                Console.WriteLine($"Food is enough! Leftovers: {totalGrFood - foodEaten} grams.");
            }
            else
            {
                Console.WriteLine($"Food is not enough. You need {foodEaten - totalGrFood} grams more.");
            }
        }
    }
}
