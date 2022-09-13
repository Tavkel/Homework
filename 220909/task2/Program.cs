// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

using Shared.UserInputs;

internal class Program
{
    private static void Main(string[] args)
    {
        int input = UserInputs.TryParseIntUserInput();
        int result = input % 10;
        for (int i = 10; input / i > 0; i *= 10)
        {
            result = result + (input / i) % 10;
        }
        System.Console.WriteLine(result);
    }
}