// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2
using Shared.UserInputs;
using Shared.Cycles;

System.Console.WriteLine("Введите два числа определяющих размеры матрицы:");
int[] size = UserInputs.TryParseArrayUserInput<int>(2);
int[,] matrix = Cycles.CreateAndFill2DArray<int>(size[0], size[1], 0, 100);
Cycles.Print2DArray(matrix);
System.Console.WriteLine("________________\n");
for (int i = 0; i < size[0]; i++)
{
    SortRow(matrix, i);
    Cycles.Print2DArray(matrix);
    System.Console.WriteLine("________________\n");
}

void SortRow(int[,] matrix, int row)
{
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        for (int j = 0; j < matrix.GetLength(1) - i - 1; j++)
        {
            if (matrix[row, j] < matrix[row, j + 1])
            {
                int tmp = matrix[row, j];
                matrix[row, j] = matrix[row, j + 1];
                matrix[row, j + 1] = tmp;
            }
        }
    }
}