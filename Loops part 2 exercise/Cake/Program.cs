using System;

namespace Cake
{
    class Program
    {
        static void Main(string[] args)
        {
            int w = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());
            int torta = w * l;
            int parche = 1 * 1;
            int vsichko_broj_parcheta = torta / parche;

            string komanda = Console.ReadLine();
          
            while(komanda!= "STOP")
            {
                int parcheta = int.Parse(komanda);
                vsichko_broj_parcheta -= parcheta;

                if (vsichko_broj_parcheta < 0 )
                {
                    break;
                }

                komanda = Console.ReadLine();
            }
            if (vsichko_broj_parcheta < 0)
            {
                Console.WriteLine($"No more cake left! You need {Math.Abs(vsichko_broj_parcheta)} pieces more.");
            }
            else
            {
                Console.WriteLine($"{Math.Abs(vsichko_broj_parcheta)} pieces are left.");
            }
        }
    }
}
