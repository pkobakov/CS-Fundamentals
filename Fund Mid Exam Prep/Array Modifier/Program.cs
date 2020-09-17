using System;
using System.Linq;

namespace Array_Modifier
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] line = Console.ReadLine().Split().Select(int.Parse).ToArray();

            string command = Console.ReadLine();

            while (command!="end")
            {
                string[] input = command.Split();
                string operation = input[0];

                if (operation == "swap")
                {
                    int index1 = int.Parse(input[1]);
                    int index2 = int.Parse(input[2]);

                    int indexTemp = line[index1];
                    line[index1] = line[index2];
                    line[index2] = indexTemp;


                }
                else if (operation == "multiply")
                {
                    int index1 = int.Parse(input[1]);
                    int index2 = int.Parse(input[2]);

                    int a = line[index1];
                    int b = line[index2];
                    line[index1] = a * b;



                }
                else if (operation == "decrease")
                {
                    for (int i = 0; i < line.Length; i++)
                    {
                        line[i] = line[i] - 1;
                    }
                }


                command = Console.ReadLine();

            }
            Console.WriteLine(string.Join(", ", line));
        }
    }
}
