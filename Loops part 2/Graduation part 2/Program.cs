using System;

namespace Graduation_part_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            double sumOfScores = 0;
            int grade = 1;
            
            double sumOfFailures = 0;
            

            while (grade <=12)
            {
                double score = double.Parse(Console.ReadLine()); 

                if (score >= 4.00)
                {
                    sumOfScores += score;
                    score++;
                }
                else
                {
                    score = double.Parse(Console.ReadLine());
                }
                if (score < 4.00)
                {
                    sumOfFailures += score;

                    if (sumOfFailures>1)
                    {
                        break;
                    }
                }
                if (grade < 12)
                {
                    Console.WriteLine("Uuuhh");
                }
                else
                {
                    Console.WriteLine("Bravo");


                }
            }
        }
    }

}
