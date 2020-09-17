using System;
using System.Collections.Generic;
using System.Linq;


namespace Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            var productsList = new Dictionary<string, Product>();
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "buy")
                {
                    break;
                }
                string[] splitted = input.Split();
                string name = splitted[0];
                double currentPrice = double.Parse(splitted[1]);
                int currentQuantity = int.Parse(splitted[2]);

                Product current = new Product(name, currentPrice, currentQuantity);

                if (!productsList.ContainsKey(name))
                {
                    productsList.Add(name, current); // ако в списъка няма ключ с това име, добавяме името и обекта current(name,currentPrice,currentQuality)
                }

                else
                {
                    productsList[name].Price = currentPrice;
                    productsList[name].Quantity += currentQuantity;
                }

            }
            foreach (var pair in productsList)
            {
                Console.WriteLine($"{pair.Key} -> {pair.Value.Price * pair.Value.Quantity:f2}");
            }

        }
    }
    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }

        public Product(string name, double price, int quantity)
        {
            this.Name = name;
            this.Price = price;
            this.Quantity = quantity;

        }
        

    }
}


