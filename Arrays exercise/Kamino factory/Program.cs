using System;
using System.Linq;

namespace Kamino_factory
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string command = Console.ReadLine();

           
            int bestStartIndex = 0;
            int bestSequenceIdex = 0;

           
            int bestSequenceSum = 0;

            int sequenceCounter = 0;
         

            int[] bestSequence = new int[n];


            while (command!="Clone them!")
            {
                int[] sequence = command.Split('!', StringSplitOptions.RemoveEmptyEntries).
                    Select(int.Parse).
                    ToArray();

                int length = 1;
                int currentMaxLength = 1;
                int maxLength = 1;
                int sequenceSum = 0;
                int startIndex = 0;

                sequenceCounter++;
               

                for (int i = 0; i <= sequence.Length-2; i++)
                {
                    if (sequence[i]==sequence[i+1])
                    {
                        length++;
                        
                    }
                    else
                    {
                        length = 1;
                    }
                    if (length > currentMaxLength)
                    {
                        currentMaxLength = length;
                        startIndex = i;
                    }
                    sequenceSum += sequence[i];
                }

                sequenceSum += sequence[sequence.Length-1];

                if (currentMaxLength>maxLength)
                {

                    maxLength = currentMaxLength;
                    bestStartIndex = startIndex;
                    bestSequenceSum = sequenceSum;
                    bestSequenceIdex = sequenceCounter;
                    bestSequence = sequence.ToArray();
                }
                else if (currentMaxLength == maxLength)
                {
                    if (bestStartIndex<startIndex)
                    {

                        maxLength = currentMaxLength;
                        bestStartIndex = startIndex;
                        bestSequenceSum = sequenceSum;
                        bestSequenceIdex = sequenceCounter;
                        bestSequence = sequence.ToArray();
                    }
                    else if (bestStartIndex==startIndex)
                    {
                        maxLength = currentMaxLength;
                        bestStartIndex = startIndex;
                        bestSequenceSum = sequenceSum;
                        bestSequenceIdex = sequenceCounter;
                        bestSequence = sequence.ToArray();

                    }
                }


               command = Console.ReadLine();

            }
            Console.WriteLine($"Best DNA sample {sequenceCounter} with sum: {bestSequenceSum}.");
            Console.WriteLine(string.Join(' ', bestSequence));
        }
    }
}
