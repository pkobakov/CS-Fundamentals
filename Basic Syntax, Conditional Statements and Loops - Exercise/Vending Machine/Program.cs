using System;

namespace Vending_Machine
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            double sum = 0;
           

            while (command!="Start")
            {
                double coin = double.Parse(command);
                if (coin == 0.1||coin == 0.2 ||coin==0.5||coin == 1 || coin == 2)
                {
                    sum += coin;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {coin}");
                }
                command = Console.ReadLine();
            }

            string product = Console.ReadLine();

            while (product!="End")
            {
                double price = 0;

                
                switch (product)
                {
                    case "Nuts":price = 2.0;break;
                    case "Water":price = 0.7;break;
                    case "Crisps":price = 1.5;break;                                           
                    case "Soda":price = 0.8;break;
                    case "Coke":price = 1.0;break;
                    default:
                        Console.WriteLine("Invalid product");
                        product = Console.ReadLine();
                    continue;
                }
                if (sum>=price)
                {
                    sum -= price;
                    Console.WriteLine($"Purchased {product.ToLower()}");
                }
                else
                {
                    Console.WriteLine("Sorry, not enough money");
                }
                product = Console.ReadLine();
            }
            Console.WriteLine($"Change: {sum:f2}");
        }
    }
}
