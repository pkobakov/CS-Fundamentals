using System;

namespace Cat_Walking
{
    class Program
    {
        static void Main(string[] args)
        {
            int mm = int.Parse(Console.ReadLine());
            int walks = int.Parse(Console.ReadLine());
            int cal = int.Parse(Console.ReadLine());

            int totalmm = mm * walks;
            int totalcal = totalmm * 5;

            double enoughcal = (double)cal * 0.50;

            if (totalcal >= enoughcal)
            {
                Console.WriteLine($"Yes, the walk for your cat is enough. Burned calories per day: {totalcal}.");
            }
            else
            {
                Console.WriteLine($"No, the walk for your cat is not enough. Burned calories per day: {totalcal}.");
            }
        }
    }
}
