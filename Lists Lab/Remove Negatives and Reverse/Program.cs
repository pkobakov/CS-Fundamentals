using System;
using System.Collections.Generic;
using System.Linq;

namespace Remove_Negatives_and_Reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();

            List<int> positives = new List<int>();

            for (int i = 0; i < nums.Count; i++)
            {
                if (nums[i]<0)
                {
                    nums.RemoveAt(i--); //връщаме индекса, за да не се прескочи, ако след remove at числото отново е отрицателно; 
                }
            }

            if (nums.Count == 0) //листът ще се изпразни (няма да има елементи), ако всички числа са отрицателни
            {
                Console.WriteLine("empty");
                return;
            }

            nums.Reverse(); //обръшаме елементите в листа;

            for (int i = 0; i < nums.Count; i++)
            {
                positives.Add(nums[i]);
            }
            Console.WriteLine(string.Join(" ", positives));
        }
    }
}
