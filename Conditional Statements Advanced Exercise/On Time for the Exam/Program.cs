using System;

namespace On_Time_for_the_Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            int examHH = int.Parse(Console.ReadLine());
            int examMM = int.Parse(Console.ReadLine());
            int arrivalHH = int.Parse(Console.ReadLine());
            int arrivalMM = int.Parse(Console.ReadLine());

            int totalExamTime = examHH * 60 + examMM;
            int totalArrivalTime = arrivalHH * 60 + arrivalMM;

            int diffEarly = totalExamTime - totalArrivalTime;
            int diffLater = totalArrivalTime - totalExamTime;

            int totalEarlyHour = diffEarly / 60;
            int totalEarlyMin = diffEarly % 60;

            int totalLaterHour = diffLater / 60;
            int totalLaterMin = diffLater % 60;

            
            if (totalExamTime < totalArrivalTime)
            {
                Console.WriteLine("Late");
                if (diffLater < 60)
                {
                    Console.WriteLine($"{totalLaterMin} minutes after the start");
                }
                else if (diffLater >= 60)
                {
                    Console.WriteLine($"{totalLaterHour}:{totalLaterMin:d2} hours after the start");
                }
            }
            else if (diffEarly <= 30)
            {
                Console.WriteLine("On time");

                Console.WriteLine($"{totalEarlyMin} minutes before the start");
            }
            else if (diffEarly > 30)
            {
                Console.WriteLine("Early");

                if (diffEarly < 60)
                {
                    Console.WriteLine($"{totalEarlyMin} minutes before the start");
                }
                else if (diffEarly >=60) 
                {
                    Console.WriteLine($"{totalEarlyHour}:{totalEarlyMin:d2} hours before the start");
                }
            }
          

        } 
     
    }
}
