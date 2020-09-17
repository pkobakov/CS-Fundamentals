using System;

namespace Back_To_The_Past
{
    class Program
    {
        static void Main(string[] args)
        {
            double legacy = double.Parse(Console.ReadLine());
            int year = int.Parse(Console.ReadLine());
            int yearsCounter = 0;
            int age = 18;
            
          


            for (int currentyear = 1800; currentyear <= year; currentyear++)
            {
                if (currentyear % 2==0)
                {
                    int currentAge = age + yearsCounter;
                    legacy = legacy - 12000;
                    
                    
                    yearsCounter++;
                    
                }
                else
                {
                    int currentAge = age + yearsCounter;
                    legacy = legacy - (12000+(currentAge*50));
                    
                    
                    yearsCounter++;
                    
                }
            }
            if (legacy>=0)
            {
                Console.WriteLine($"Yes! He will live a carefree life and will have {legacy:f2} dollars left.");
            }
            else
            {
                Console.WriteLine($"He will need {Math.Abs(legacy):f2} dollars to survive.");
            }
           
        }
    }
}
