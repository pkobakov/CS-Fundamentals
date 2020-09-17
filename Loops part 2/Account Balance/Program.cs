using System;

namespace Account_Balance
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double balance = 0;
            int a = 0;
            

            while (a < n)
            {
                double payment = double.Parse(Console.ReadLine());
               
                if (payment < 0)
                {
               
                    Console.WriteLine("Invalid operation!");
                    
                    break;
                }

                balance += payment;
                Console.WriteLine($"Increase: {payment:f2}");
                a++;
            }
            Console.WriteLine($"Total: {balance:f2}");
        }


    }
}
