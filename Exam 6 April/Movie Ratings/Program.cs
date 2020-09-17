using System;

namespace Movie_Ratings
{
    class Program
    {
        static void Main(string[] args)
        {
            int movieCount = int.Parse(Console.ReadLine());
            double maxrate = double.MinValue;
            double minrate = double.MaxValue;
            string maxmovie = "";
            string minmovie = "";
            double sumofrates = 0;
            for (int i = 1; i <= movieCount; i++)
            {
                string movieName = Console.ReadLine();
                double rate = double.Parse(Console.ReadLine());

                if (rate > maxrate)
                {
                    maxrate = rate;
                    sumofrates += rate;
                    maxmovie = movieName;
                }
                else if (rate < minrate)
                {
                    minrate = rate;
                    sumofrates += rate;
                    minmovie = movieName;
                }
                else
                {
                    sumofrates += rate;
                }
                
            }

            double average = sumofrates / movieCount;
            Console.WriteLine($"{maxmovie} is with highest rating: {maxrate:f1}");
            Console.WriteLine($"{minmovie} is with lowest rating: {minrate:f1}");
            Console.WriteLine($"Average rating: {average:f1}");
        }
    }
}
