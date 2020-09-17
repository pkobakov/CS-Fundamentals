using System;

namespace HappyCat_Parking
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());

            
            double parkingFee = 0;
            double sumParking = 0;
                 


            for (int currentDay = 1; currentDay <= days; currentDay++)
            {
                for (int currentHour = 1; currentHour <= hours; currentHour++)
                {
                   
                    if (currentDay%2==0 && currentHour%2!=0)
                    {
                        parkingFee +=2.50;
                        sumParking += 2.50;
                       
                    }
                    else if (currentDay % 2 != 0 && currentHour % 2 == 0)
                    {
                        parkingFee += 1.25;
                        sumParking += 1.25;

                    }
                    else
                    {
                        parkingFee += 1;
                        sumParking += 1;
                    }

                   
                }

                Console.WriteLine($"Day: {currentDay} - {parkingFee:f2} leva");
                parkingFee = 0;

            }
          

            Console.WriteLine($"Total: {sumParking:f2} leva");
        }
                
    }
}
