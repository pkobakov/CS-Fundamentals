using System;
using System.Collections.Generic;
using System.Linq;

namespace Bomb_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> line = Console.ReadLine().Split().Select(int.Parse).ToList();

            string[] command = Console.ReadLine().Split();
            int bombNum = int.Parse(command[0]);
            int power = int.Parse(command[1]);

            int bombIndex = line.IndexOf(bombNum);

            while (bombIndex !=-1)
            {
                int mostLeftIndex = bombIndex - power;
                int mostRightIndex = bombIndex + power;

                if (mostLeftIndex<0)
                {
                    mostLeftIndex = 0;
                }

               if (mostRightIndex>line.Count-1)
               {
                    mostRightIndex = line.Count - 1;
               }

                line.RemoveRange(mostLeftIndex, mostRightIndex - mostLeftIndex + 1);

                bombIndex = line.IndexOf(bombNum);
            }

            int sum = line.Sum();
            Console.WriteLine(sum);

        }
    }
}
