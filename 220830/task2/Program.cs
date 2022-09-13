// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

using Shared.UserInputs;

namespace HomeworkAug30
{
    class Program
    {
        static void Main(string[] args)
        {
           int number = UserInputs.TryParseIntUserInput();
           if (number % 2 == 0)
           {
                Console.WriteLine($"Число {number} - четное.");
           }
           else Console.WriteLine($"Число {number} - нечетное.");
        }
    }
}