using System;

namespace Operations_Between_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int N1 = int.Parse(Console.ReadLine());
            int N2 = int.Parse(Console.ReadLine());
            string operSymbol = (Console.ReadLine());
            double result = 0;
            string evenOrodd = "";


            if (operSymbol == "+" || operSymbol == "-" || operSymbol == "*")
            {
                if (operSymbol == "+")
                {
                    result = N1 + N2;
                }
                else if (operSymbol == "-")
                {
                    result = N1 - N2;
                }
                else if (operSymbol == "*")
                {
                    result = N1 * N2;
                }
                    if (result % 2 == 0)
                    {
                        evenOrodd = "even";
                    }
                    else
                    {
                        evenOrodd = "odd";
                    }
                    Console.WriteLine($"{N1} {operSymbol} {N2} = {result} - {evenOrodd}");
            }
            else if (operSymbol == "/")
            {
                    if (N2 == 0)
                    {
                        Console.WriteLine($"Cannot divide {N1} by zero");
                    }
                    else
                    {
                        Console.WriteLine($"{N1} / {N2} = {N1*1.0 / N2:f2}");
                    }
            }
            else if (operSymbol == "%")
            {
                if (N2 == 0)
                {
                    Console.WriteLine($"Cannot divide {N1} by zero");
                }
                else
                {
                    Console.WriteLine($"{N1} % {N2} = {N1%N2}");
                }
            }
            
        }
    }
}