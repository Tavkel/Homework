// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

using Shared.UserInputs;
using Shared.Cycles;

System.Console.WriteLine("Введите два числа определяющих размеры матрицы:");
int[] size = UserInputs.TryParseArrayUserInput<int>(2);
int[,] matrix = Cycles.CreateAndFill2DArray<int>(size[0], size[1], 0, 10);
Cycles.Print2DArray(matrix);
int[] result = GetBiggestRowSum(matrix);
System.Console.WriteLine($"Row with biggest sum is {result[0] + 1}, ({result[1]})");




int[] GetRowSum(int[,] matrix, int row)
{
    int[] sum = new int[2] { row, 0 };
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        sum[1] += matrix[row, i];
    }
    return sum;
}

int[] GetBiggestRowSum(int[,] matrix)
{
    int[] maxSum = { 0, 0 };
    for (int i = 0; i < matrix.GetLongLength(0); i++)
    {
        int[] sum = GetRowSum(matrix, i);
        if (maxSum[1] < sum[1])
        {
            maxSum = sum;
        }
    }
    return maxSum;
}