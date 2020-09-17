using System;

namespace Change_Bureau
{
    class Program
    {
        static void Main(string[] args)
        {
            int bitcoins = int.Parse(Console.ReadLine());
            double yuans = double.Parse(Console.ReadLine());
            double comission = double.Parse(Console.ReadLine());

            double bitcoin = 1168;
            double euroBgn = 1.95;

            double sumofbitcoins = bitcoins * bitcoin;
            double sumyuansindollars = yuans * 0.15;
            double dollarsinleva = sumyuansindollars * 1.76;

            double sumineuro = (dollarsinleva + sumofbitcoins) / euroBgn;
            double sumcomission = comission * sumineuro/100;

            double total = sumineuro - sumcomission;
            
            Console.WriteLine($"{ total:f2}");
            

        }
    }
}
