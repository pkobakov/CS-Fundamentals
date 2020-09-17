using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace Student_Academy
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, List<double>> students = new Dictionary<string, List<double>>();

            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());

                if (!students.ContainsKey(name))
                {
                    students.Add(name, new List<double>());
                    students[name].Add(grade);

                }
                else
                {
                    students[name].Add(grade);
                }
            }

            Dictionary<string, double> averageGrade = new Dictionary<string, double>();

            foreach (var pair in students)
            {
                averageGrade.Add(pair.Key, pair.Value.Average());
            }

            foreach (var pair in averageGrade.Where(student=>student.Value>=4.50).OrderByDescending(student=>student.Value))
            {
                Console.WriteLine($"{pair.Key} -> {pair.Value:f2} ");
            }
        }
    }
}
