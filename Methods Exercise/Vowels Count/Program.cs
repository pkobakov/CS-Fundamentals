using System;

namespace Vowels_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();

            VowelsCounter(word);
            
        }
        static void VowelsCounter(string word)
        {

            int vowelsCounter = 0;

            for (int i = 0; i < word.Length; i++)
            {
                switch (word[i])
                {
                    case 'a': vowelsCounter++; break;
                    case 'e': vowelsCounter++; break;
                    case 'o': vowelsCounter++; break;
                    case 'u': vowelsCounter++; break;
                    case 'i': vowelsCounter++; break;
                    case 'A': vowelsCounter++; break;
                    case 'E': vowelsCounter++; break;
                    case 'O': vowelsCounter++; break;
                    case 'U': vowelsCounter++; break;
                    case 'I': vowelsCounter++; break;
                }
            }
            Console.WriteLine(vowelsCounter);


        }
        

    }
}
