using System;
using System.Linq;

namespace ConsoleApp1
{
    class Exam
    {
        static void Main(string[] args)
        {
            int[] targets = Console.ReadLine().Split().Select(int.Parse).ToArray();

            string command = "";

            int counter = 0;

            while ((command = Console.ReadLine()) != "End")
            {

                int index = int.Parse(command);

                if (index >= 0 && index < targets.Length)
                {
                    for (int i = 0; i < targets.Length; i++)
                    {
                        int valueOfCurrentIndex = targets[index];

                        if (targets[i] != -1 && i != index)
                        {
                            if (targets[i] > valueOfCurrentIndex)
                            {
                                targets[i] -= valueOfCurrentIndex;
                            }
                            else if (targets[i] <= valueOfCurrentIndex)
                            {
                                targets[i] += valueOfCurrentIndex;
                            }
                        }
                    }

                    targets[index] = -1;
                    counter++;
                }
            }

            Console.WriteLine($"Shot targets: {counter} ->" + " " + string.Join(' ', targets));
        }
    }
}