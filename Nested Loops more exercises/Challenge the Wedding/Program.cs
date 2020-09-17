using System;

namespace Challenge_the_Wedding
{
    class Program
    {
        static void Main(string[] args)
        {
            int men = int.Parse(Console.ReadLine());
            int women = int.Parse(Console.ReadLine());
            int tables = int.Parse(Console.ReadLine());
            int tablesCounter = 0;

           

                for (int currentMan = 1; currentMan <= men; currentMan++)
                {

                    for (int currentWoman = 1; currentWoman <= women; currentWoman++)
                    {

                        Console.Write($"({currentMan} <-> {currentWoman}) ");

                        tablesCounter++;

                        if (tablesCounter == tables)
                        {
                            return;
                        }

                        
                    }

                }


            

            
                
        }
    }
}
