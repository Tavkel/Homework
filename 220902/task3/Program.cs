// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

using Shared.UserInputs;

namespace HomeworkSep02
{
    class Program
    {
        private static UserInputs _userInputs = new UserInputs();

        static void Main(string[] args)
        {
            int number = _userInputs.TryParseIntUserInput();
            if (number > 0 && number < 8)
            {
                if (number < 6) System.Console.WriteLine("нет");
                else System.Console.WriteLine("да");

                string[] answers = { "нет", "нет", "нет", "нет", "нет", "да", "да" };
                System.Console.WriteLine(answers[number - 1]);

                switch (number)
                {
                    case < 6:
                        System.Console.WriteLine("нет");
                        break;
                    default:
                        System.Console.WriteLine("да");
                        break;
                }
            }
            else
            {
                System.Console.WriteLine("Out of range");
            }
        }
    }
}