// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6


using Shared.UserInputs;

namespace HomeworkSep02
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = UserInputs.TryParseIntUserInput();
            if (Math.Abs(number / 100) < 1)
            {
                System.Console.WriteLine("Третьей цифры нет");

            }
            else
            {
                string numberAsString = Math.Abs(number).ToString();
                System.Console.WriteLine($"Третья цифра числа {number} - {numberAsString[2]}");
            }
        }
    }
}