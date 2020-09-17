using System;
using System.Security.Cryptography;

namespace Trekking_Mania
{
    class Program
    {
        static void Main(string[] args)
        {
            int groups = int.Parse(Console.ReadLine());
            int Musala = 0;
            int Montblanc = 0;
            int Kilimanjaro = 0;
            int K2 = 0;
            int Everest = 0;

            for (int i = 1; i <= groups; i++)
            {
                int alpinists = int.Parse(Console.ReadLine());

                if (alpinists <= 5)
                {
                    Musala += alpinists;
                }
                else if (alpinists>=6 && alpinists <= 12)
                {
                    Montblanc += alpinists;
                }
                else if (alpinists >= 13 && alpinists <= 25)
                {
                    Kilimanjaro += alpinists;
                }
                else if (alpinists >= 26 && alpinists <= 40)
                {
                    K2 += alpinists;
                }
                else if (alpinists >= 41)
                {
                    Everest += alpinists;
                }
            }
            double allalpinists = Musala + Montblanc + Kilimanjaro + K2 + Everest;
            double percentMusala = Musala / allalpinists * 100;
            double percentMontblanc = Montblanc / allalpinists * 100;
            double percentKilimanjaro = Kilimanjaro / allalpinists * 100;
            double percentK2 = K2 / allalpinists * 100;
            double percentEverest = Everest / allalpinists * 100;  

            Console.WriteLine($"{percentMusala:f2}%");
            Console.WriteLine($"{percentMontblanc:f2}%");
            Console.WriteLine($"{percentKilimanjaro:f2}%");
            Console.WriteLine($"{percentK2:f2}%");
            Console.WriteLine($"{percentEverest:f2}%");
        }
    }
}
