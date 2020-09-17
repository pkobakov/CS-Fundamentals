using System;

namespace Characters_in_Range
{
    class Program
    {
        static void Main(string[] args)
        {
            char a = char.Parse(Console.ReadLine());
            char b = char.Parse(Console.ReadLine());
            RangeOfCharacters(a,b);
            
        }
        static void RangeOfCharacters(char a,char b)
        {
            if (a<b)
            {
                for (int i = a + 1; i < b; i++)
                {

                    Console.Write((char)i + " ");
                }
            }
            else
            {
                for (int i = b + 1; i < a; i++)
                {

                    Console.Write((char)i + " ");
                }
            }
            
        }
    }
}
