using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace Order_by_Age
{ 
    class  Student
    {
        public string Name { get; set; }
        public string ID { get; set; }
        public int Age { get; set; }
       public  Student(string name, string code, int age)
       {
            this.Name = name;
            this.ID = code;
            this.Age = age;

        
       }
        public override string ToString()
        {
            return $"{Name} with ID: {ID} is {Age} years old.";
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> people = new List<Student>();

            string input = Console.ReadLine();

            while (input != "End")
            {
                string[] tokens = input.Split(' ');
                string Name = tokens[0];
                string ID = tokens[1];
                int Age = int.Parse(tokens[2]);

                Student student = new Student(Name,ID,Age);
                people.Add(student);

                input = Console.ReadLine();
            }

            people = people.OrderBy(x => x.Age).ToList();

            Console.WriteLine(String.Join(Environment.NewLine, people));


        }
    }

}
