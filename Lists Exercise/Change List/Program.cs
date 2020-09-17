using System;
using System.Collections.Generic;
using System.Linq;
using System.Transactions;

namespace Change_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] elements = command.Split();

                if (elements[0] == "Delete")
                {
                    int numberToDelete = int.Parse(elements[1]);
                    numbers.Remove(numberToDelete);
                   
                }
                else if (elements[0] == "Insert")
                {
                    int numerToInsert = int.Parse(elements[1]);
                    int indexToInsert = int.Parse(elements[2]);
                    numbers.Insert(indexToInsert,numerToInsert);
                   
                }

                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(' ', numbers));
        }
    }
}
