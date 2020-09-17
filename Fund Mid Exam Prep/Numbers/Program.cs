using System;
using System.Linq;
using System.Collections.Generic;

namespace Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> line = Console.ReadLine().Split().Select(int.Parse).ToList();
            double averageSum = 0;
            double average = 0;
            int lineIndex = line.Count;

            for (int i = 0; i < line.Count; i++)
            {
                averageSum += line[i];
                average = averageSum / line.Count;

            }
          
            for (int i = 0; i < line.Count; i++)
            {
                if (line[i]<=average)
                {
                   line.Remove(line[i]);
                   i = i - 1;
                   lineIndex--;
                }
            }
            if (lineIndex == 0)
            {
                Console.WriteLine("No");return;
            }
            


            line = line.OrderByDescending(x=>x).ToList();

            if (line.Count<=5)
            {
                Console.WriteLine(string.Join(' ', line));
            }
            else if(line.Count>5)
            {
                for (int i = 0; i < 5; i++)
                {
                    Console.Write(line[i] + " ");
                } 
            }

                   
            
        }
    }
}
