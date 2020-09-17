using System;

namespace String_Explosion
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string [] splittedInput = input.Split(">"); // разделям редицата на части както се разделя масив;
            string result = splittedInput[0]; // взима се нулевия елемент от разделената редица;
            int remainingPower = 0;

            for (int i = 1; i < splittedInput.Length; i++)
            {
                result += ">"; // към нулевия елемент ("abv") от разделената редица добавяме '>';

                string currentString = splittedInput[i]; //разглеждам текущия елемент от разделената редица; 
                char digitSymbol = currentString[0]; // нулевият елемент от текущата редица е число, което показва силата;

                int power = int.Parse(digitSymbol.ToString()) + remainingPower; //пребразуваме към стринг и парсвам, тк чар не може да се парсне;

                if (power>currentString.Length)
                {
                    remainingPower = power - splittedInput[i].Length;
                }

                else
                {
                    result += currentString.Substring(power); // към резултата добавям подредицата започваща от индекса в стринга = power
                }

            }

            Console.WriteLine(result);

        }
    }
}
