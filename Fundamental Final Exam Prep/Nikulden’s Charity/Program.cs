using System;
using System.Text;

namespace Nikulden_s_Charity
{
    class Program
    {
        static void Main(string[] args)
        {

            string result = Console.ReadLine();
            int sum = 0;

            while (true)
            {
                string [] commands = Console.ReadLine().Split();
                string currentCommand = commands[0];
                

                if (currentCommand == "Finish")
                {
                    break;
                }

                else if (currentCommand == "Replace")
                {
                    char oldValue = char.Parse(commands[1]);
                    char newValue = char.Parse(commands[2]);

                    result = result.Replace(oldValue, newValue);

                    Console.WriteLine(result);
                }

                else if (currentCommand == "Cut")
                {
                   
                    int startIndex = int.Parse(commands[1]);
                    int endIndex = int.Parse(commands[2]);

                    if (startIndex>=0 && endIndex<= result.Length)
                    {
                        int range = endIndex - startIndex;
                        result = result.Remove(startIndex, range+1);

                        Console.WriteLine(result);
                    }

                    else
                    {
                        Console.WriteLine("Invalid indexes!");
                    }
                }

                else if (currentCommand == "Make")
                {
                    string upOrDown = commands[1];

                    if (upOrDown == "Upper")
                    {
                        result = result.ToUpper();

                        Console.WriteLine(result);
                    }

                    else if (upOrDown == "Lower")
                    {
                        result = result.ToLower();

                        Console.WriteLine(result);
                    }
                }

                else if (currentCommand == "Check")
                {
                    
                    string substring = commands[1];

                    if (result.Contains(substring))
                    {
                        Console.WriteLine($"Message contains {substring}"); 
                    }

                    else
                    {
                        Console.WriteLine($"Message doesn't contain {substring}");
                    }

                }

                else if (currentCommand == "Sum")
                {
                    int startIndex = int.Parse(commands[1]);
                    int endIndex = int.Parse(commands[2]);

                    if (startIndex >= 0 && endIndex <= result.Length)
                    {
                        for (int i = startIndex; i <= endIndex; i++)
                        {
                            sum += result[i];
                        }

                        Console.WriteLine(sum);
                    }

                    else
                    {
                        Console.WriteLine("Invalid indexes!");
                    }
                }
            }
        }
    }
}
