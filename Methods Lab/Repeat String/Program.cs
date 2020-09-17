using System;
using System.Threading;

namespace Repeat_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string letter = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());
            
            Console.WriteLine(RepeatString(letter,count));
        }
        static string RepeatString (string letter, int count)
        {
            string result = string.Empty;
            for (int i = 0; i < count; i++)
            {
                result += letter;
            }
            return result;
        }
    }
}
