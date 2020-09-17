using System;
using System.Collections.Generic;
using System.Linq;

namespace School_Library
{
    class Program
    {
        static void Main(string[] ags)
        {
            List<string> bookShelf = Console.ReadLine()
                                    .Split('&', StringSplitOptions.RemoveEmptyEntries)
                                    .ToList();
            string input = Console.ReadLine();
            
            while (input!="Done")
            {
                string[] command = input.Split(" | ", StringSplitOptions.RemoveEmptyEntries);
                string action = command[0];
                string bookName = command[1];
                

                if (action == "Add Book")
                    if (bookShelf.Contains(bookName))
                    {
                        continue;
                    }
                    else
                    {
                        bookShelf.Insert(0, bookName);
                    }
                    
                else if (action == "Take Book")
                {
                    if (bookShelf.Contains(bookName))
                    {
                        bookShelf.Remove(bookName);
                    }
                    else
                    {
                        continue;
                    }
                   
                }
                else if (action == "Swap Books")
                {
                    string bookName2 = command[2];

                    if (bookShelf.Contains(bookName)&&bookShelf.Contains(bookName2))
                    {

                        int indexBook1 = bookShelf.IndexOf(bookName);
                        int indexBook2 = bookShelf.IndexOf(bookName2);

                        string temp = bookShelf[indexBook2];
                        bookShelf[indexBook2] = bookName;
                        bookShelf[indexBook1] = temp;

                    }
                  
                }
                else if (action == "Insert Book")
                {
                    bookShelf.Add(bookName);

                }
                else if (action == "Check Book")
                {
                    int index = int.Parse(command[1]);

                    if (index>=0 && index <= bookShelf.Count)
                    {

                        Console.WriteLine(bookShelf[index]);
                    }
                    else
                    {
                        input = Console.ReadLine();
                        continue;    
                    }

                                  
                }

                    input = Console.ReadLine();
            }
            Console.WriteLine(string.Join(", ", bookShelf));
        }
    }
}
