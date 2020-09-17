using System;

namespace Padawan_Equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            double lightsabersPrice = double.Parse(Console.ReadLine());
            double robesPrice = double.Parse(Console.ReadLine());
            double beltPrice = double.Parse(Console.ReadLine());

            double tenPercentMore = (double)students * 0.1;

            double sumForLightsabers = Math.Ceiling(students+tenPercentMore) *lightsabersPrice;
            double sumForRobes= students *robesPrice;
            double sumForBelts = students* beltPrice;

            for (int i = 1; i <= students; i++)
            {
                if ((i%6)==0)
                {
                    sumForBelts -= beltPrice;
                }
            }

            double totalSum = sumForLightsabers + sumForRobes + sumForBelts;
            if (money>=totalSum)
            {
                Console.WriteLine($"The money is enough - it would cost {totalSum:f2}lv.");
            }
            else
            {
                Console.WriteLine($"Ivan Cho will need {(totalSum-money):f2}lv more.");
            }
            

        }
    }
    
}
