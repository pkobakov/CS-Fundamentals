using System;

namespace Bachelor_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            int honorar = int.Parse(Console.ReadLine());
            int sumGuests = 0;
            double sumOfReseravtions = 0;
            double reservationPrice = 0;
            int groupCounter = 0;
           

            string command = Console.ReadLine();

            while (command != "The restaurant is full")
            {
                int peopleCount = int.Parse(command);
                
                sumGuests += peopleCount;

                int people = peopleCount;

                for (int group = 1; group <= people; group++)
                {
                    groupCounter++;
                    people -= peopleCount;

                    if (peopleCount < 5)
                    {
                        reservationPrice = peopleCount * 100;
                        sumOfReseravtions += reservationPrice;
                    }
                    else if (peopleCount >= 5)
                    {
                        reservationPrice = peopleCount * 70;
                        sumOfReseravtions += reservationPrice;
                    }
                }

                command = Console.ReadLine();
            }

            double budget = sumOfReseravtions-honorar;

            if (sumOfReseravtions >= honorar)
            {
                Console.WriteLine($"You have {sumGuests} guests and {budget} leva left.");
            }
            else
            {
                Console.WriteLine($"You have {sumGuests} and {sumOfReseravtions} leva income,  but no singer."); 
            }
        }
    }
}
