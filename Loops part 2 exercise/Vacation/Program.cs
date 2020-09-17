using System;

namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double nujni_pari = double.Parse(Console.ReadLine());
            double nalicni_pari = double.Parse(Console.ReadLine());


            int broj_dni = 0;
            int broj_dni_harchene = 0;

            while (nalicni_pari < nujni_pari)
            {
                string komanda = Console.ReadLine();
                double pari = double.Parse(Console.ReadLine());
                broj_dni++;

                if (komanda == "save")
                {
                    nalicni_pari += pari;
                    broj_dni_harchene = 0;
                }
                else
                {
                    nalicni_pari -= pari;
                    broj_dni_harchene++;

                    if (nalicni_pari < 0)
                    {
                        nalicni_pari = 0;
                    }

                }
                if (broj_dni_harchene == 5)
                {
                    break;
                }
               
            }
            if (nalicni_pari >= nujni_pari)
            {

                Console.WriteLine($"You saved the money for { broj_dni} days.");

            }
            if (broj_dni_harchene == 5)
            {
                Console.WriteLine("You can't save the money.");
                Console.WriteLine(broj_dni);
            }
        }
            
                    
    }
}
