using System;

namespace Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            int capacity = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();
            int seatsSold = 0;
            double totalIncome = 0;
            int seatsLeft = capacity;

            while(command != "Movie time!") 
            {
                int people = int.Parse(command);
                seatsSold += people;
                seatsLeft -= people;
                if (seatsLeft < 0)
                {
                    Console.WriteLine($"The cinema is full.");
                    
                    break;
                }
                double income = people * 5.0;
                if (people % 3 == 0)
                {
                    totalIncome -= 5;
                }
                totalIncome += income;
                command = Console.ReadLine();
            }
            if (command=="Movie time!")
            {
                Console.WriteLine($"There are {capacity - seatsSold} seats left in the cinema.");
            }
            
            Console.WriteLine($"Cinema income - {totalIncome} lv.");
            
            
        }

    }
}
