using System;

namespace Text_Filter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] bannedWords = Console.ReadLine().Split(", ");
            string text = Console.ReadLine();

            foreach (var bannword in bannedWords)
            {

                if (text.Contains(bannword))
                {
                    text = text.Replace(bannword, new string('*', bannword.Length));
                }
            
            }
            Console.WriteLine(text);

        }
    }
}
