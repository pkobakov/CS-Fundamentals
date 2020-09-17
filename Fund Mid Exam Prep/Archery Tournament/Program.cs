using System;
using System.Linq;
using System.Transactions;

namespace Archery_Tournament
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] line = Console.ReadLine().Split('|', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

           
           
            int IskrenPoints = 0;

            string command = Console.ReadLine();

            while (command != "Game over")
            {
                if (command == "Reverse")
                {
                    Array.Reverse(line);
                    command = Console.ReadLine();
                    continue;

                }
                string[] elements = command.Split('@', StringSplitOptions.RemoveEmptyEntries).ToArray();
                string direction = elements[0];
                int startIndex = int.Parse(elements[1]);
                int lenght = int.Parse(elements[2]);


                if (startIndex>=0 && startIndex<= line.Length-1)
                {
                    if (direction == "Shoot Left")
                    {
                        while (lenght != 0)
                        {
                            if (startIndex>0)
                            {
                                startIndex--;
                                lenght--;
                            }
                            else if(startIndex==0)
                            {
                                startIndex = line.Length - 1;
                                lenght--;
                            }
                            
                        }
                        if (line[startIndex] >= 5)
                        {
                            line[startIndex] -= 5;
                            IskrenPoints += 5;
                        }
                        else
                        {
                            IskrenPoints += line[startIndex];
                            line[startIndex] = 0;
                        }

                    }
                    else if (direction == "Shoot Right")
                    {
                        while (lenght != 0)
                        {
                            if (startIndex < line.Length-1)
                            {
                                startIndex++;
                                lenght--;
                            }
                            else if (startIndex == line.Length-1)
                            {
                                startIndex = 0;
                                lenght--;
                            }
                        }
                        if (line[startIndex] >= 5)
                        {
                            line[startIndex] -= 5;
                            IskrenPoints += 5;
                        }
                        else
                        {
                            IskrenPoints += line[startIndex];
                            line[startIndex] = 0;
                        }

                    }
                }

                command = Console.ReadLine();
            }
            
            Console.WriteLine(string.Join(" - ",line));
            Console.WriteLine($"Iskren finished the archery tournament with {IskrenPoints} points!");
        }
      
    }
}
