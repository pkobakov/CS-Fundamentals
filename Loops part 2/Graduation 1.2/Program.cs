using System;

namespace Graduation_1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
          
            double sum = 0;
            double grades = 1;

            while (grades <= 12)
            {
                double grade = double.Parse(Console.ReadLine());
                if (grade < 4.00)
                {
                    grades -- ;
                    
                }
                if (grade >= 4.00)
                {
                    sum = sum + grade;
                    grades++;
                }
            }
            if (grades == 13)
            {
                Console.WriteLine($"{name} graduated. Average grade: {sum / 12:f2}");
            }
            
            }
        }
    }
}
