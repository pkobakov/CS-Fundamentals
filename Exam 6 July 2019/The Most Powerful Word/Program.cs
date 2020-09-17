using System;

namespace The_Most_Powerful_Word
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            string mostpowefulword = "";
            double power = double.MinValue;
            while (word!="End of words")
            {
                double sum = 0;
                for (int i = 0; i < word.Length; i++)
                {
                    int letter = word[i];
                    sum += letter;
                    
                }
                if (word[0] == 97 ||
                    word[0] == 101 ||
                    word[0] == 105 ||
                    word[0] == 111 ||
                    word[0] == 117 ||
                    word[0] == 121 ||
                    
                    word[0] == 65 ||
                    word[0] == 69 ||
                    word[0] == 73 ||
                    word[0] == 79 ||
                    word[0] == 85 ||
                    word[0] == 89 )
                {
                    sum *= word.Length;
                }
                else
                {
                    sum = Math.Floor(sum / word.Length);
                }
                if (sum>power)
                {
                    mostpowefulword = word;
                    power = sum;
                }

                word = Console.ReadLine();
                
            }

            Console.WriteLine($"The most powerful word is {mostpowefulword} - {power}");
        }
    }
}
