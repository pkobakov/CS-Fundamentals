using System;

namespace Sum_Prime_Non_Prime
{
    class Program
    {
        static void Main(string[] args)
        {
            string input  = Console.ReadLine();
            int sumPrime = 0;
            int sumNonPrime = 0;

            while (input!="stop")
            {
                int num = int.Parse(input);

                if (num<0)
                {

                    Console.WriteLine("Number is negative.");
                    input = Console.ReadLine();
                    continue;
                }
                bool isNonPrime = false;
                int m = num / 2;

                for (int i = 2; i <= m ; i++)
                {
                    if (num%i == 0)
                    {
                        isNonPrime = true;
                        break;
                    }

                }
                if (isNonPrime)
                {
                    sumNonPrime += num;
                }
                else 
                {
                    sumPrime += num;
                }
                input = Console.ReadLine();
            }
            Console.WriteLine($"Sum of all prime numbers is: {sumPrime}");
            Console.WriteLine($"Sum of all non prime numbers is: {sumNonPrime}");

        }
    }
}
