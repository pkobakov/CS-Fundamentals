using System;

namespace Coffee_Machine
{
    class Program
    {
        static void Main(string[] args)
        {
            string drink = Console.ReadLine();
            string sugar = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());
            double sum = 0.0;



            if (sugar == "Without")
            {
                switch (drink)
                {
                    case "Espresso": sum = n*0.90;break;
                    case "Cappuccino":sum = n * 1.00;break;
                    case "Tea":sum = n * 0.50;break;
                       
                }     
            }
            else if (sugar == "Normal")
            {
                switch (drink)
                {
                    case "Espresso": sum = n * 1.00;break;
                    case "Cappuccino":sum = n * 1.20;break;
                    case "Tea":sum = n * 0.60;break;
                }
            }
            else if (sugar == "Extra")
            {
                switch (drink)
                {
                    case "Espresso":sum = n * 1.20;break;
                    case "Cappuccino":sum = n * 1.60;break;
                    case "Tea":sum = n * 0.70;break;
                }
            }
            if (sugar == "Without")
            {
                sum -= sum * 0.35;
            }
            if (drink == "Espresso" && n>=5)
            {
                sum -= sum * 0.25;
            }
            if (sum>15)
            {
                sum -= sum * 0.20;
            }

            Console.WriteLine($"You bought {n} cups of {drink} for {sum:f2} lv.");
        }
    }
}
