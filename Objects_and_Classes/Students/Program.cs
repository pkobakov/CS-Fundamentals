using System;
using System.Collections.Generic;
using System.Linq;

namespace Students
{
    class Startup
    {
        static void Main(string[] args)
        {

            List<Student> students = new List<Student>();

            string command = Console.ReadLine();
            while (command != "end")
            {
                string[] newStudent = command.Split().ToArray();
                string firstName = newStudent[0];
                string lastName = newStudent[1];
                int age = int.Parse(newStudent[2]);
                string homeTown = newStudent[3];


                Student student = new Student()
                {
                    FirstName = firstName,
                    LasName = lastName,
                    Age = age,
                    HomeTown = homeTown

                };
                students.Add(student);
                command = Console.ReadLine();
            }
            string filterCity = Console.ReadLine();

            foreach (Student currentstudent in students)
            {
                if (filterCity == currentstudent.HomeTown)
                {
                    Console.WriteLine($"{currentstudent.FirstName} {currentstudent.LasName} is {currentstudent.Age} years old.");
                }
            }
        }
    }
    public class Student
    {
     public string FirstName { get; set; }
     public string LasName { get; set; }
     public int Age { get; set; }
     public string HomeTown { get; set; }
    }
     
}
