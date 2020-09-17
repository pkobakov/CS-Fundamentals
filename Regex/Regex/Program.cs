using System;
using System.Text.RegularExpressions;


namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"[A-Z][a-z]+ [A-Z][a-z]"; // описвам шаблона като string;

            Regex regex = new Regex(pattern); //създаваме нов шаблон, по който ще се търси съвпадение;
            string input = Console.ReadLine();

            Console.WriteLine(regex.IsMatch(input));//дали вообще имаме съвпадение (true/false);
            Console.WriteLine(regex.Match(input).Value);//дава стойността на първото съвпадение (изписва input);
            Console.WriteLine(regex.Matches(input).Count);// колко пъти има съвпадения;

            var matches = regex.Matches(input); // лист, който събира всички съвпадения;
            foreach (Match match in matches) // обикаля се листа и се изписва всяко съвпадение;
            {
                Console.WriteLine(match.Value);
            }
        }
    }
}
