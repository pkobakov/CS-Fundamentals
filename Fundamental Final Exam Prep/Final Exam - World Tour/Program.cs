using System;
using System.Text;

namespace Final_Exam___World_Tour
{
    class Program
    {
        static void Main(string[] args)
        {
            string stops = Console.ReadLine();
            string command = Console.ReadLine();
            StringBuilder travel = new StringBuilder(stops);
            while (command != "Travel")
            {
                string[]commandArgs = command.Split(':');
                string operation = commandArgs[0];
               

                if (operation == "Add Stop")
                {
                    
                    int index = int.Parse(commandArgs[1]);
                        string newStop = commandArgs[2];

                        if (index>=0&&index<=stops.Length-1)
                        {
                            travel = travel.Insert(index,newStop);
                        }

                    Console.WriteLine(travel);
                }

                else if (operation == "Remove Stop")
                {
                    
                    int startIndex = int.Parse(commandArgs[1]);
                    int endIndex = int.Parse(commandArgs[2]);
                    int range = endIndex - startIndex;

                    if (startIndex >= 0 && endIndex <= travel.Length-1)
                    {
                        travel = travel.Remove(startIndex, range + 1);
                       
                    }

                    Console.WriteLine(travel);
                }

                

                else if (operation == "Switch")
                {
                    
                    string currentTravel  = travel.ToString();
                    string destinationToSwitch = commandArgs[1];
                    string newDestination = commandArgs[2];

                    if (currentTravel.Contains(destinationToSwitch))
                    {
                        travel.Replace(destinationToSwitch, newDestination);
                    }

                    Console.WriteLine(travel);

                }



                command = Console.ReadLine();
            }

            Console.WriteLine($"Ready for world tour! Planned stops: {travel}");
        }
    }
}
