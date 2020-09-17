using System;

namespace Travelling
{
    class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                string destination = Console.ReadLine();

                if (destination == "End")
                {
                    break;
                }

                double budget = double.Parse(Console.ReadLine());
                double sum = 0;

                while (sum < budget)
                {
                 double vnoska = double.Parse(Console.ReadLine());
                   sum += vnoska;
                }

                    Console.WriteLine($"Going to {destination}!");
                
              
            }

        }    
    }
}
