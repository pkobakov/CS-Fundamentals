using System;

namespace Cinema_Tickets
{
    class Program
    {
        static void Main(string[] args)
        {
            string movie = Console.ReadLine();
            
            double percent = 0;
            int ticketcounter = 0;
            int student = 0;
            int standard = 0;
            int kid = 0;

            while (movie != "Finish")
            {
                int seats = int.Parse(Console.ReadLine());
                int soldseats = 0;

                for (int i = 1; i <= seats; i++)
                {
                    string ticketType = Console.ReadLine();

                    if (ticketType == "End")
                    {
                        break;
                    }
                    else if (ticketType == "student")
                    {
                        soldseats ++ ;
                        student++;
                    }
                    else if (ticketType == "standard")
                    {
                        soldseats ++ ;
                        standard++;
                    }
                    else if (ticketType == "kid")
                    {
                        soldseats ++ ;
                        kid++;
                    }

                    ticketcounter++;
                }
                percent =(double) soldseats / seats * 100;
                Console.WriteLine($"{movie} - {percent:f2}% full.");
                movie = Console.ReadLine();
            }

            Console.WriteLine($"Total tickets: {ticketcounter}");
            Console.WriteLine($"{((double)student/ticketcounter*100):f2}% student tickets.");
            Console.WriteLine($"{((double)standard/ticketcounter*100):f2}% standard tickets.");
            Console.WriteLine($"{((double)kid/ticketcounter*100):f2}% kids tickets.");
        }                          
    }
}
