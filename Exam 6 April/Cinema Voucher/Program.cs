using System;

namespace Cinema_Voucher
{
    class Program
    {
        static void Main(string[] args)
        {
            int vaucher = int.Parse(Console.ReadLine());
            string purchase = Console.ReadLine();
            double price = 0;
            int ticketcounter = 0;
            int othercounter = 0;
            double currentmoney = vaucher;

            while (purchase!="End")
            {
                int symbolCount = purchase.Length;

                if (symbolCount > 8)
                {
                    
                    price = purchase[0] + purchase[1];

                    if (price>currentmoney)
                    {
                        break;
                    }
                    else
                    {
                        ticketcounter++;
                        currentmoney -= price;
                    }
                    
                }
                else if (symbolCount <= 8)
                {
                   
                    price = purchase[0];

                    if (price > currentmoney)
                    {
                        break;
                    }
                    else
                    {
                        othercounter++;
                        currentmoney -= price;
                    }
                   
                }
               

                purchase = Console.ReadLine();
            }
            Console.WriteLine(ticketcounter);
            Console.WriteLine(othercounter);

        }
    }
}
