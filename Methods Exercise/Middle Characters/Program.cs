using System;

namespace Middle_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            if (text.Length %2 != 0)
            {

                MiddleCharacterOddText(text);
            }
            else
            {

                MiddleCharactersEvenText(text);
            }
        }
        static void MiddleCharacterOddText(string text)
        {

            Console.Write(text[text.Length / 2]); 
        }
        static void MiddleCharactersEvenText(string text)
        {
            
                for (int i = text.Length / 2 - 1; i < text.Length / 2; i++)
                {
                    Console.Write(text[i]+""+text[i+1]);
                }
        }
    }
}
