using System;

namespace Shopping
{
    class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            double towelPrice = double.Parse(Console.ReadLine());
            double percentDiscount = int.Parse(Console.ReadLine());

            double umbrellaPrice = towelPrice * 2 / 3;
            double flipflopPrice = umbrellaPrice * 0.75;
            double bag = (towelPrice + flipflopPrice) * 1 / 3;

            double totalPrice = towelPrice + flipflopPrice + umbrellaPrice + bag;

            double sumAfterdiscount = totalPrice - (totalPrice * percentDiscount / 100);// когато стойността на процента се изчислява по време на задачата, а не зададена в условието 

            if (budget>=sumAfterdiscount)
            {
                Console.WriteLine($"Annie's sum is {} lv. She has {budget-} lv. left.");
            }
            else
            {
                Console.WriteLine();
            }
        }
    }
}
