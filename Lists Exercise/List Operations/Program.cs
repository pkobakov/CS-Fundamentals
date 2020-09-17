using System;
using System.Linq;
using System.Collections.Generic;

namespace List_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            string command = Console.ReadLine();

            while (command != "End")
            {
                string[] elements = command.Split();

                if (elements[0] == "Add")
                {
                    int number = int.Parse(elements[1]);
                    numbers.Add(number);
                }
                               
                else if (elements[0] == "Insert")
                {
                    int number = int.Parse(elements[1]);
                    int index = int.Parse(elements[2]);

                    if (index >= 0 &&index < numbers.Count)
                    {
                        numbers.Insert(index, number); 
                    }
                    else
                    {
                        Console.WriteLine("Invalid index");
                    }
                }
                else if (elements[0] == "Remove")
                {
                    int index = int.Parse(elements[1]);

                    if (index >= 0 && index < numbers.Count)
                    {
                        numbers.RemoveAt(index); 
                    }
                    else
                    {
                        Console.WriteLine("Invalid index");
                    }
                }
                else if (elements[1] == "left")
                {
                    int count = int.Parse(elements[2]);
                    for (int i = 0; i < count; i++)
                    {

                        int first = numbers[0];
                        numbers.Add(first);
                        numbers.RemoveAt(0);
                    }
                }
                else if (elements[1] == "right")
                {
                    int count = int.Parse(elements[2]);
                    for (int i = 0; i < count; i++)
                    {

                        int last = numbers[numbers.Count - 1];
                        numbers.Insert(0, last);
                        numbers.RemoveAt(numbers.Count - 1);

                    }
                }

                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(' ', numbers));
        }
    }
}
