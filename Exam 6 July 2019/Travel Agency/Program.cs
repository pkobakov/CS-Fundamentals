using System;

namespace Travel_Agency
{
    class Program
    {
        static void Main(string[] args)
        {
            string city = Console.ReadLine();
            string pack = Console.ReadLine();
            string vip = Console.ReadLine();
            int days = int.Parse(Console.ReadLine());
            double sum = 0;

            if (days>7)
            {
                days-= 1;
            }
            else if (days<= 0)
            {
                Console.WriteLine("Days must be positive number!");
                return;
            }
            if (city == "Bansko" || city == "Borovets")
            {
                if(pack == "noEquipment")
                {
                    sum = days * 80;
                        if (vip == "yes")
                        {
                            sum -= sum * 0.05;
                        }
                }
                else if (pack == "withEquipment")
                {
                    sum = days * 100;
                    if (vip == "yes")
                    {
                        sum -= sum * 0.10;
                    }
                }
            }
            else if (city == "Varna" || city == "Burgas")
            {
                if (pack == "noBreakfast")
                {
                    sum = days * 100;
                   
                        if (vip == "yes")
                        {
                            sum -= sum * 0.07;
                        }
                    
                }
                else if (pack == "withBreakfast")
                {
                    sum = days * 130;

                        if (vip == "yes")
                        {
                            sum -= sum * 0.12;
                        }
                }
            }
            else
            {
                Console.WriteLine("Invalid input!");
                return;
            }

            Console.WriteLine($"The price is {sum:f2}lv! Have a nice time!");
        }
    }
}
