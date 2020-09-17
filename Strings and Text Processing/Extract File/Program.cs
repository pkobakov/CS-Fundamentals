using System;

namespace Extract_File
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split('\\', StringSplitOptions.RemoveEmptyEntries);
            var line = input[input.Length - 1].Split('.', StringSplitOptions.RemoveEmptyEntries);

            Console.WriteLine($"File name: {line[0]}");
            Console.WriteLine($"File extension: {line[1]}");  
 
        }
    }
}
