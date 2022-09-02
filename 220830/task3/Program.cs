// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

using Shared.UserInputs;

namespace HomeworkAug30
{
    class Program
    {
        private static UserInputs _userInputs = new UserInputs();

        static void Main(string[] args)
        {
            int number;
            do
            {
                number = _userInputs.TryParseIntUserInput();
                if (number < 2) System.Console.WriteLine("Out of range");
            }
            while(number < 2);
            for (int i = 2; i<= number; i+=2)
            {
                System.Console.WriteLine($"{i}");
            }
        }
    }
}