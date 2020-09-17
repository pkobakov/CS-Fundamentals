using System;

namespace Gift_Box_Coverage
{
    class Program
    {
        static void Main(string[] args)
        {
            double sideSize = double.Parse(Console.ReadLine());
            double sheetsOfPaper = double.Parse(Console.ReadLine());
            double sheetsArea= double.Parse(Console.ReadLine());

            double percentage = 0;
            double boxArea = sideSize * sideSize * 6;
            int sheetArea25 = 0;
            double totalSheetArea = 0;

            for (int i = 1; i <= sheetsOfPaper; i++)
            {
                if ((i%3)==0)
                {
                    totalSheetArea += sheetsArea * 0.25;
                    sheetArea25++;
                }
                else
                {
                    totalSheetArea += sheetsArea;
                }
            }
            percentage = totalSheetArea/boxArea*100;
            Console.WriteLine($"You can cover { percentage:f2}% of the box.");

        
        }
    }
}
