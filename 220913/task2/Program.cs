// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

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
            array[i] = new Random().Next(-999, 1000);
        }
        System.Console.WriteLine("Generated array:");
        Cycles.PrintArray(array);

        int sumOfOddPos = 0;

        for (int i = 1; i < size; i+=2)
        {
            sumOfOddPos += array[i];
        }

        
        System.Console.WriteLine($"Сумма чисел на нечетных позициях: {sumOfOddPos}");

    }
}