// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125


using Shared.UserInputs;

namespace HomeworkSep06
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = UserInputs.TryParseIntUserInput();
            for (int i = 1; i <= number; i++)
            {
                System.Console.WriteLine(Math.Pow(i, 3));
            }            
        }
    }
}