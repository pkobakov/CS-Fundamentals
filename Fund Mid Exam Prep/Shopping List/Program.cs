using System;
using System.Linq;
using System.Collections.Generic;
using System.Data;

namespace Shopping_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> listOfProducts = Console.ReadLine().Split('!', StringSplitOptions.RemoveEmptyEntries).ToList();
            string command = Console.ReadLine();

            while (command != "Go Shopping!")
            {
                string[] elements = command.Split().ToArray();

                if (elements[0] == "Urgent")
                {
                    if (listOfProducts.Contains(elements[1]))
                    {

                        command = Console.ReadLine();
                        continue;
                    }
                    else
                    {
                        listOfProducts.Insert(0, elements[1]);
                    }
                }
                else if (elements[0] == "Unnecessary")
                {
                    if (listOfProducts.Contains(elements[1]))
                    {
                        listOfProducts.Remove(elements[1]);

                    }
                    else
                    {
                        command = Console.ReadLine();
                        continue;

                    }
                }
                else if (elements[0] == "Correct")
                {
                    
                    if (listOfProducts.Contains(elements[1]))
                    {
                        string item = elements[2];
                        int index = listOfProducts.IndexOf(elements[1]);
                        listOfProducts.Remove(elements[1]);
                        listOfProducts.Insert(index,item);
                    }
                    else
                    {
                        command = Console.ReadLine();
                        continue;
                    }
                }
                else if (elements[0] == "Rearrange")
                {
                    if (listOfProducts.Contains(elements[1]))
                    {

                        listOfProducts.Remove(elements[1]);
                        listOfProducts.Add(elements[1]);
                    }
                }


                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(", ", listOfProducts));


        }
    }
}
