using System;

namespace Clever_Lilly
{
    class Program
    {
        static void Main(string[] args)
        {
            int currentBirthday = int.Parse(Console.ReadLine());
            double mashinePrice = double.Parse(Console.ReadLine());
            int toyPrice = int.Parse(Console.ReadLine());
            int toysCounter = 0;
            int savedMoney = 0;
            int stolenMoney = 0;
            int oldValue = 0;

            for (int firstBirthday = 1; firstBirthday <= currentBirthday; firstBirthday++)
            {
                if (firstBirthday % 2 == 0)
                {

                    savedMoney += 10;
                    oldValue +=savedMoney;
                    stolenMoney++;
                }
                else
                {
                    toysCounter++;
                }
                
            }
           
            int totalToyprice = toysCounter * toyPrice;
            int totalSavedMoney = oldValue + totalToyprice - stolenMoney;

            if (totalSavedMoney>=mashinePrice)
            {
                Console.WriteLine($"Yes! {Math.Abs(mashinePrice-totalSavedMoney):f2}");

            }
            else
            {
                Console.WriteLine($"No! {Math.Abs(totalSavedMoney - mashinePrice):f2}");
            }
           
            






        }
    }
}
