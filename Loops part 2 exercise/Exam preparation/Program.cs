using System;

namespace Exam_preparation
{
    class Program
    {
        static void Main(string[] args)
        {
            int pozvoleni_kofti_ocenki = int.Parse(Console.ReadLine());

            string imeNaZadacha = Console.ReadLine();

            int broyach_ocenki = 0;
            int suma_ocenki = 0;
            int broyach_loshi_ocenki = 0;
            string ime_posledna_zadacha = imeNaZadacha;




            while (imeNaZadacha != "Enough")
            {
                int ocenka = int.Parse(Console.ReadLine());
                suma_ocenki += ocenka;
                broyach_ocenki++;
                if (ocenka<=4)
                {
                    broyach_loshi_ocenki++;
                }
               
                if (broyach_loshi_ocenki == pozvoleni_kofti_ocenki)
                {
                    break;
                }
                ime_posledna_zadacha = imeNaZadacha;
                imeNaZadacha = Console.ReadLine();

            }
            if (broyach_loshi_ocenki == pozvoleni_kofti_ocenki)
            {
                Console.WriteLine($"You need a break, {broyach_loshi_ocenki} poor grades.");
            }
            else
            {
                double sredna_ocenka = suma_ocenki*1.0 / broyach_ocenki;
                Console.WriteLine($"Average score: {sredna_ocenka:f2}");
                Console.WriteLine($"Number of problems: {broyach_ocenki}");
                Console.WriteLine($"Last problem: {ime_posledna_zadacha}");
            }
            
        }   
    }
}
