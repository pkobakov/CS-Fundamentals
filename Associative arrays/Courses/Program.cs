using System;
using System.Collections.Generic;
using System.Linq;

namespace Courses
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary <string, List<string>> courses = new Dictionary<string, List<string>>();

            string input = Console.ReadLine();

            while (input!="end")
            {
                string[] commandElements = input.Split(" : ");
                string courseName = commandElements[0];
                string studentName = commandElements[1];

                if (!courses.ContainsKey(courseName))
                {
                    courses.Add(courseName, new List<string>()); // създаваме нов курс, като към него регистрираме празен списък за студенти;
                    courses[courseName].Add(studentName); // към новия списък записваме текущия студент;
                }

                else
                {
                    courses[courseName].Add(studentName);
                }



                input = Console.ReadLine();
            }
            foreach (var  kvp in courses.OrderByDescending(x=>x.Value.Count))
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value.Count}");
                kvp.Value.Sort();
                List<string> students = kvp.Value;

                foreach (var student in students)
                {
                    Console.WriteLine($"-- { student}");
                }
                
            }
           
        }
    }
}
