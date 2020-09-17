using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Students
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> currentStudent = new List<Student>();//първо създава празен лист  на нов студент, който съдържа празни пропъртита ;
            int n = int.Parse(Console.ReadLine()); //брой пъти, в които ще се въвеждат нови данни (брой студенти)

            for (int i = 0; i < n; i++)
            {
                string[] data = Console.ReadLine().Split(" ");
                
                //данните се въвеждат по формата на масив;
                currentStudent.Add(new Student(data)); // и се добавят към текущия студент
            }
            currentStudent = currentStudent.OrderByDescending(x => x.Grade).ToList();//подреждам студентите низходящо;
            currentStudent.ForEach(x => Console.WriteLine(x.ToString()));
        }
    }
    class Student
    {
        //1. дефинирам пропъртита, по които ще се регистрира всеки студент;
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public double Grade { get; set; }

        //2. попълвам пропъртитата с информацията получена от "data";
        public Student(string[] data)
        {
            FirstName = data[0];
            SecondName = data[1];
            Grade = double.Parse(data[2]);
        }

        // 3. създавам метод, чрез който ще се отпечатва масива currentStudent;
        public override string ToString()
        {
            return $"{FirstName} {SecondName}: {Grade:F2}";
        }
    }
}