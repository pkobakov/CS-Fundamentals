using System;
using System.Collections.Generic;
using System.Linq;

namespace Tasks_Planner
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> tasks = Console.ReadLine().
                              Split().
                              Select(int.Parse).
                              ToList();
            string command = Console.ReadLine();
            int completed = 0;
            int incompleted = 0;
            int dropped = 0;

            while (command!="End")
            {
                string[] elements = command.Split();
                string toDo = elements[0];

                if (toDo == "Complete")
                {
                    int index = int.Parse(elements[1]);
                    if (index >= 0 && index < tasks.Count)
                    {
                        tasks[index] = 0;

                    }
                }
                else if (toDo == "Change")
                {
                    int index = int.Parse(elements[1]);
                    int value = int.Parse(elements[2]);

                    if (index >= 0 && index < tasks.Count)
                    {
                        tasks[index] = value;
                    }
                }
                else if (toDo == "Drop")
                {
                    int index = int.Parse(elements[1]);
                    if (index >= 0 && index < tasks.Count)
                    {
                        tasks[index] = -1;
                    }
                }
                else if (toDo == "Count")
                {
                    string status = elements[1];
                    if (status == "Completed")
                    {
                        for (int i = 0; i < tasks.Count; i++)
                        {
                            if (tasks[i] == 0)
                            {
                                completed++;
                            }
                        }
                        Console.WriteLine(completed);
                    }
                    else if (status == "Incomplete")
                    {
                        for (int i = 0; i < tasks.Count; i++)
                        {
                            if (tasks[i] > 0)
                            {
                                incompleted++;
                            }
                        }
                        Console.WriteLine(incompleted);
                    }
                    else if (status == "Dropped")
                    {
                        for (int i = 0; i < tasks.Count; i++)
                        {
                            if (tasks[i] < 0)
                            {
                                dropped++;
                            }
                        }
                        Console.WriteLine(dropped);
                    }

                }
                command = Console.ReadLine();
            }

            for (int i = 0; i < tasks.Count; i++)
            {
                if (tasks[i] > 0)
                {
                    Console.Write(tasks[i]+" ");
                }
            }

           
        }
    }
}

