// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

using Shared.UserInputs;

namespace HomeworkSep02
{
    class Program
    {
        private static UserInputs _userInputs = new UserInputs();

        static void Main(string[] args)
        {
            int number;
            bool check = false;
            do
            {
                number = _userInputs.TryParseIntUserInput();
                if (Math.Abs(number / 100) < 1 || Math.Abs(number / 100) > 10)
                {
                    System.Console.WriteLine("Не трехзначное число");
                    continue;
                }
                else check = true;
            }
            while (!check);
            int secondDigit = Math.Abs((number - (number / 100) * 100) / 10);
            System.Console.WriteLine($"вторая цифра числа {number} - {secondDigit}");
        }
    }
}