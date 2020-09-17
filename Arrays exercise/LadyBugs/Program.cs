using System;
using System.Linq;

namespace LadyBugs
{
    class Program
    {
        static void Main(string[] args)
        {
            int fieldSize = int.Parse(Console.ReadLine());

            int[] bugsIndexes = Console.ReadLine().Split().Select(int.Parse).ToArray(); //масив от индексите, на които са разположени калинки и трябва да са със стойност 1;

            //1. Създаване на поле и определяне месоположението на калинките 

            int[] field = new int[fieldSize]; //създаваме поле с големина fieldSize

            for (int i = 0; i < bugsIndexes.Length; i++)
            {
                int fieldCurrentIndex = bugsIndexes[i];
             

                if (fieldCurrentIndex>=0 && fieldCurrentIndex < field.Length) //определяме къде има поставени калинки
                {
                    field[fieldCurrentIndex] = 1; // с 1 бележим индекса с калинка
                }
            }

            // 2. Изписване на командите,  чрез които ще лети калинката;

            string command = string.Empty;
            while ((command = Console.ReadLine())!="end")
            {
               string[] commandElements = command.Split(); //разделяме командата на елементи;
               int ladyBugIdexToMove =int.Parse (commandElements[0]); 
               string flighDirection = commandElements[1];
               int flighLenght = int.Parse(commandElements[2]);

                if (ladyBugIdexToMove < 0||ladyBugIdexToMove > field.Length-1||field[ladyBugIdexToMove] == 0) //проверяваме, дали са изпълнени всички условия, за да може калинката да се премести
                {
                    continue; //ако калинката не е в пределите на полето, или в индекса на полето няма калинка продължаваме; 
                }

                field[ladyBugIdexToMove] = 0; // от 1 става 0,защото калинката освобождава клетката

                if (flighDirection=="right") //при посока на летене надясно
                {
                    int landIndex = ladyBugIdexToMove + flighLenght; // определяме индекса, на който трябва да кацне калинката; 

                    if (landIndex>field.Length-1)
                    {
                        continue;
                    }
                    if (field[landIndex] == 1) // ако на индекса има калинка (1), трябва да продължим местенето;
                    {
                        while (field[landIndex] == 1) //местенето трябва да продължи, докато не попаднем на индекс с 0;
                        {
                            landIndex += flighLenght;

                            if (landIndex>field.Length-1) // ако калинката излиза от полето - break;
                            {
                                break;
                            }
                        }
                    }
                    
                    if (landIndex>=0 && landIndex <= field.Length-1)
                    {
                        field[landIndex] = 1;
                    }
                }

                else if (flighDirection == "left")
                {
                    int landIndex = ladyBugIdexToMove - flighLenght;

                    if (landIndex < 0 )
                    {
                        continue;
                    }
                    if (field[landIndex] == 1)
                    {
                        while (field[landIndex] == 1)
                        {
                            landIndex -= flighLenght;

                            if (landIndex < 0)
                            {
                                break;
                            }
                        }
                    }
                    if (landIndex >= 0 && landIndex <= field.Length - 1)
                    {
                        field[landIndex] = 1;
                    }
                }
            }
            Console.WriteLine(string.Join(' ', field));
        }
    }
}
