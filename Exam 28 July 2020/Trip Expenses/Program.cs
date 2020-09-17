using System;

namespace Trip_Expenses
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            double moneyLeft = 0;

           
            for (int day = 1; day <= days; day++)
            {
                double daylimit = 60+moneyLeft;
                moneyLeft = 0;
                string command = Console.ReadLine();
                int item = 0;
                while (command!="Day over")
                {
                    double price = double.Parse(command);

                    if (daylimit>0)
                    {
                        item++;
                        daylimit -= price;
                    }
                   
                    if (daylimit == 0)
                    {
                        break;
                    }
                    command = Console.ReadLine();
                }
               
                if (command == "Day over")
                {
                    moneyLeft = daylimit;
                    Console.WriteLine($"Money left from today: {moneyLeft:f2}. You've bought {item} products.");
                }
                else
                {
                    Console.WriteLine($"Daily limit exceeded! You've bought {item} products.");
                }

            }


        }
    }
}
