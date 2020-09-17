using System;

namespace Spaceship
{
    class Program
    {
        static void Main(string[] args)
        {
            double w = double.Parse(Console.ReadLine());
            double l = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());
            double averageAustronautLenght = double.Parse(Console.ReadLine());
           

            double spaceNeededInMetres = 2 * 2 * (0.40 + averageAustronautLenght);

            double spaceShipValue = w * l * h;
            double enoughSpacePer = spaceShipValue / spaceNeededInMetres;

            if (enoughSpacePer >=3&&enoughSpacePer<=10)
            {
                Console.WriteLine($"The spacecraft holds {Math.Floor(enoughSpacePer)} astronauts.");

            }
            else if (enoughSpacePer <3)
            {
                Console.WriteLine("The spacecraft is too small.");
            }

            else if (enoughSpacePer >10)
            {
                Console.WriteLine("The spacecraft is too big.");
            }

        }
    }
}
