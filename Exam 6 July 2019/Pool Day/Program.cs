using System;

namespace Pool_Day
{
    class Program
    {
        static void Main(string[] args)
        {
            int persons = int.Parse(Console.ReadLine());
            double fee = double.Parse(Console.ReadLine());
            double priceperlounge = double.Parse(Console.ReadLine());
            double priceperumbrella = double.Parse(Console.ReadLine());

            double umbrellas = Math.Ceiling(persons / 2.0);
            double lounges = Math.Ceiling(persons * 0.75);

            double sumforfees = persons * fee;
            double sumforlounges = lounges * priceperlounge;
            double sumforumbrellas = umbrellas * priceperumbrella;

            double total = sumforfees + sumforlounges + sumforumbrellas;
            Console.WriteLine($"{total:f2} lv.");



        }
    }
}
