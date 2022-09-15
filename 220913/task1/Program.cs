// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


using Shared.UserInputs;
using Shared.Cycles;

internal class Program
{
    private static void Main(string[] args)
    {
        System.Console.WriteLine("Введите размер генерируемого массива: ");
        int size = UserInputs.TryParseIntUserInput();

        int[] array = new int[size];
        for (int i = 0; i < size; i++)
        {
            array[i] = new Random().Next(100, 1000);
        }
        System.Console.WriteLine("Generated array:");
        Cycles.PrintArray(array);

        int evenCount = 0;
        for (int i = 0; i < size; i++)
        {
            if (array[i] % 2 == 0)
            {
                evenCount++;
            }
        }
        System.Console.WriteLine($"\nКоличество четных чисел в массиве: {evenCount}");
    }
}