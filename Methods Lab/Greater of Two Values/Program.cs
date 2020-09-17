using System;

namespace Greater_of_Two_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        static string Print( string a, string b)
        {
            if (a.CompareTo(b)>=0)
            {
                return a;
            }
            else
            {
                return b;
            }
        }

    }
}
