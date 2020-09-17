using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._List_Manipulation_Basics
{
    class Program
    {
        public static object PrintEvenNums { get; private set; }

        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            bool isChanged = false;

            while (true)
            {
                string line = Console.ReadLine();

                if (line == "end")
                {
                    break;
                }
                string[] tokens = line.Split();

                if (tokens[0] == "Add")
                {
                    int numberToAdd = int.Parse(tokens[1]);
                    numbers.Add(numberToAdd); //функция за добавяне на елемент;
                    isChanged = true;
                }
                if (tokens[0] == "Remove")
                {
                    int numberToRemove = int.Parse(tokens[1]);
                    numbers.Remove(numberToRemove); //функция за премахване на елемент;
                    isChanged = true;
                }
                if (tokens[0] == "RemoveAt")
                {
                    int numberToRemoveAt = int.Parse(tokens[1]);
                    numbers.RemoveAt(numberToRemoveAt); //функция за премахване на елемент от определен индекс;
                    // използва се, когато имаме няколко елемента с повтарящи се стойности;
                    isChanged = true;
                }
                if (tokens[0] == "Insert")
                {
                    int numberToInsert = int.Parse(tokens[1]);
                    int indexToBeInsered = int.Parse(tokens[2]);
                    numbers.Insert(indexToBeInsered, numberToInsert); //функция за вмъкване на елемент на определен индекс;
                    isChanged = true;
                }
                if (tokens[0] == "Contains")
                {
                    int numberContained = int.Parse(tokens[1]);
                    bool check = numbers.Contains(numberContained); // финкция за проверка за наличност на определено цисло;
                    if (check)
                    {
                        Console.WriteLine("Yes");
                    }
                    else
                    {
                        Console.WriteLine("No such number");
                    }
                }
                if (tokens[0] == "PrintEven")
                {
                    PrintEvenNumbers(numbers);
                    Console.WriteLine();
                }
                if (tokens[0] == "PrintOdd")
                {
                    PrintOddNumbers(numbers);
                    Console.WriteLine();
                }
                if (tokens[0] == "GetSum")
                {
                    Console.WriteLine(numbers.Sum());
                }
                if (tokens[0] == "Filter")
                {
                    string symbol = tokens[1];
                    int number = int.Parse(tokens[2]);

                    if (tokens[1] == "<")
                    {
                        Console.WriteLine(string.Join(" ", numbers.Where(x => x < number)));
                    }
                    else if (tokens[1] == ">")
                    {
                        Console.WriteLine(string.Join(" ", numbers.Where(x => x > number)));
                    }
                    else if (tokens[1] == ">=")
                    {
                        Console.WriteLine(string.Join(" ", numbers.Where(x => x >= number)));
                    }
                    else if (tokens[1] == "<=")
                    {
                        Console.WriteLine(string.Join(" ", numbers.Where(x => x <= number)));
                    }
                }
            }
            if (isChanged == true)
            {
                Console.WriteLine(string.Join(" ", numbers));
            }
        }
        public static void PrintEvenNumbers(List<int> numbers)
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                int currentNumber = numbers[i];
                if (currentNumber % 2 == 0)
                {
                    Console.Write(currentNumber + " ");
                }
            }
        }
        public static void PrintOddNumbers(List<int> numbers)
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                int currentNumberOdd = numbers[i];
                if (currentNumberOdd % 2 == 1)
                {
                    Console.Write(currentNumberOdd + " ");
                }
                // mylist.AddRange(mylist2) - функция за добавяне на елементи на един лист в друг 
                // mylist2 е листът, който се добавя;

                // RemoveRange(index, index) - функция за премахване на елемент от индекс до индекс;

                //mylist.Reverse(); - функция за обръщане на листа;
            }
        }

    }
}