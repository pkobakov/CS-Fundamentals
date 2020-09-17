using System;

namespace Favorite_Movie
{
    class Program
    {
        static void Main(string[] args)
        {
            string movie = Console.ReadLine();
            
            int moviecounter = 0;
            int bestsum = int.MinValue;
            string bestmovie = "";

            while (movie!="STOP")
            {
                moviecounter++;
                int sum = 0;
                for (int i = 0; i < movie.Length ; i++)
                {
                    int letter = movie[i];

                    if (letter>=65 && letter<=90)
                    {
                        int lengh = movie.Length;
                        sum += letter - lengh;
                    }
                    else if (letter>=97 && letter<=122)
                    {
                        int doublelengh = movie.Length * 2;
                        sum += letter - doublelengh;
                    }
                    else
                    {
                        sum += letter;
                    }
                }
                if (moviecounter == 7)
                {
                    Console.WriteLine($"The limit is reached.");
                    break;
                }
                if (sum > bestsum)
                {
                    bestsum = sum;
                    bestmovie = movie;
                }

                movie = Console.ReadLine();
            }

            Console.WriteLine($"The best movie for you is {bestmovie} with {bestsum} ASCII sum.");
        }
    }
}
