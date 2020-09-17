using System;

namespace Caesar_Cipher
{
    class Program
    {
        static void Main(string[] args)
        {
            string textLine = Console.ReadLine();
            string code = "";

            for (int i = 0; i < textLine.Length; i++)
            {
                code += (char)(textLine[i] + 3);
            }

            Console.WriteLine(code);
        }
    }
}
