using System;

namespace Report_System
{
    class Program
    {
        static void Main(string[] args)
        {
            int moneyNeeded = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();
            int transaction = 0;
            int cashTrans = 0;
            int cardTrans = 0;
            int totalCash = 0;
            int totalCard = 0;
            int sumOfdonations = 0;


            while (command != "End")
            {
                int price = int.Parse(command);
                transaction++;

                if (moneyNeeded > sumOfdonations)
                {
                    if (transaction % 2 == 0)
                    {
                        if (price >= 10)
                        {
                            cardTrans++;
                            totalCard += price;
                            sumOfdonations += price;

                            Console.WriteLine("Product sold!");
                        }
                        else
                        {
                            Console.WriteLine("Error in transaction!");
                        }

                    }
                    else
                    {
                        if (price <= 100)
                        {
                            cashTrans++;
                            totalCash += price;
                            sumOfdonations += price;

                            Console.WriteLine("Product sold!");
                        }
                        else
                        {
                            Console.WriteLine("Error in transaction!");
                        }
                    }

                    if (command == "End" || moneyNeeded <= sumOfdonations)
                    {

                        break;
                    }
                }
                command = Console.ReadLine();
            }

            if (sumOfdonations >= moneyNeeded)
            {
                double averageCS = (double)totalCash / cashTrans;
                double averageCC = (double)totalCard / cardTrans;
                
                Console.WriteLine($"Average CS: {averageCS:f2}");
                Console.WriteLine($"Average CC: {averageCC:f2}");
            }
            else
            {
                Console.WriteLine("Failed to collect required money for charity.");
            }
        }
    }
}
