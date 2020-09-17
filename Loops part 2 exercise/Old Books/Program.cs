using System;

namespace Old_Books
{
    class Program
    {
        static void Main(string[] args)
        {
            string lyubimaKniga = Console.ReadLine();
            int brojknigi = int.Parse(Console.ReadLine());

            string knigaProverka = Console.ReadLine();
            int broyach = 0;

            while (lyubimaKniga!=knigaProverka )
            {
                broyach++;
                if (broyach == brojknigi)
                {
                    break;
                }
                knigaProverka = Console.ReadLine();
            }
            if (knigaProverka==lyubimaKniga)
            {
                Console.WriteLine($"You checked {broyach} books and found it.");
            }
            else
            {
                Console.WriteLine("The book you search is not here!");
                Console.WriteLine($"You checked {broyach} books.");
            }
        }
    }
}
