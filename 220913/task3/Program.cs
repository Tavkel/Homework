// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

using Shared.UserInputs;
using Shared.Cycles;

internal class Program
{
    private static void Main(string[] args)
    {
        System.Console.WriteLine("Введите размер генерируемого массива: ");
        int size = UserInputs.TryParseIntUserInput();

        double[] array = new double[size];
        for (int i = 0; i < size; i++)
        {
            int tmp = new Random().Next(-99, 100);
            array[i] = Math.Round(new Random().NextDouble() + (double)tmp, 2);
        }
        System.Console.WriteLine("Generated array:");
        Cycles.PrintArray(array);

        double min = array[0];
        double max = array[0];

        for (int i = 0; i < size; i++)
        {
            if (array[i] < min)
            {
                min = array[i];
            }
            if (array[i] > max)
            {
                max = array[i];
            }
        }

        System.Console.WriteLine($"Разность между максимальным и минимальным элементами: {max - min}");
    }
}