using System;

namespace Movie_Day
{
    class Program
    {
        static void Main(string[] args)
        {
            int timeforfilming = int.Parse(Console.ReadLine());
            int numofscenes = int.Parse(Console.ReadLine());
            int scenetiming = int.Parse(Console.ReadLine());

            double preparationtiming = (double)timeforfilming * 0.15;
            double timeforscenefilming = (double)numofscenes * scenetiming;

            double totaltimingneeded = timeforscenefilming + preparationtiming;

            if (totaltimingneeded<=timeforfilming)
            {
                double timeleft = timeforfilming - totaltimingneeded;

                Console.WriteLine($"You managed to finish the movie on time! You have {Math.Ceiling(timeleft)} minutes left!");
            }
            else
            {
                double needed = totaltimingneeded - timeforfilming;
                Console.WriteLine($"Time is up! To complete the movie you need {Math.Ceiling(needed)} minutes.");
            }
        }
    }
}
