// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

using Shared.UserInputs;
using Shared.Cycles;
internal class Program
{
    private static void Main(string[] args)
    {
        System.Console.WriteLine("Введите два целых числа, определяющих размеры матрицы:");
        var output = CreateMatrix();
        for (int i = 0; i < output.GetLength(0); i++)
        {
            for (int j = 0; j < output.GetLength(1); j++)
            {
                System.Console.Write($"{output[i,j]}\t");
            }
            System.Console.WriteLine();
        }
    }

    private static double[,] CreateMatrix()
    {
        var tmp = UserInputs.TryParseArrayUserInput<int>();
        if (tmp.Length != 2)
        {
            System.Console.WriteLine("Ошибка ввода. Необходимо указать два параметра: Количество строк и столбцов массива\nВведите количество строк и столбцов массива: ");
            return CreateMatrix();
        }
        else
        {
            double[,] result = new double[tmp[0], tmp[1]];
            for (int i = 0; i < tmp[0]; i++)
            {
                for (int j = 0; j < tmp[1]; j++)
                {
                    result[i,j] = Math.Round(new Random().Next(-10,10) + new Random().NextDouble(), 2);
                }
            }
            return result;
        }
    }
}