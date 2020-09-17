using System;

namespace Bus
{
    class Program
    {
        static void Main(string[] args)
        {
            int passengers = int.Parse(Console.ReadLine());
            int stops = int.Parse(Console.ReadLine());
           
            int stopsCounter = 0;
            
            int sumOfPassengers = passengers;

            for (int totalStops = 1; totalStops <= stops; totalStops++)
            {
                stopsCounter++;
                int passengersOut = int.Parse(Console.ReadLine());
                int passengersIn = int.Parse(Console.ReadLine());
                sumOfPassengers -= passengersOut;
                sumOfPassengers += passengersIn;

                if (stopsCounter %2!= 0)
                {
                    sumOfPassengers = sumOfPassengers + 2;
                }
                else if (stopsCounter%2==0)
                {
                    sumOfPassengers = sumOfPassengers - 2;
                }
                
            }
            Console.WriteLine($"The final number of passengers is : { sumOfPassengers}");
        }
    }
}
