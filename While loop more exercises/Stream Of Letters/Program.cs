using System;

namespace Stream_Of_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = "";

            char letter = '+';
            string text = "";
            string newWord = "";
            string codeWord = "";

            while (command != "End")
            {
                command = Console.ReadLine();
                if (command != "End")
                {
                    letter = char.Parse(command);

                    if ((letter >= 65 && letter <= 90) || (letter >= 97 && letter <= 122))
                    {
                        if (letter == 'c' && !(codeWord.Contains("c")))
                        {
                            codeWord += char.ToString(letter);
                        }
                        else if (letter == 'o' && !(codeWord.Contains("o")))
                        {
                            codeWord += char.ToString(letter);
                        }
                        else if (letter == 'n' && !(codeWord.Contains("n")))
                        {
                            codeWord += char.ToString(letter);
                        }
                        else
                        {
                            text += char.ToString(letter);
                        }
                        if (codeWord == "con" || codeWord == "cno" || codeWord == "ocn" || codeWord == "onc" || codeWord == "nco" || codeWord == "noc")
                        {
                            text += " ";
                            newWord = text;
                            codeWord = "";
                        }
                    }
                }
                else
                {
                    break;
                }
            }
            if (command == "End")
            {
                Console.WriteLine(newWord);
            }
        }
    }
}
            
