// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

using Shared.UserInputs;
using Shared.Cycles;


int[] size1;
int[,] matrix1;
int[] size2;
int[,] matrix2;

bool check = false;
do
{
    System.Console.WriteLine("Введите два числа определяющих размеры первой матрицы:");
    do
    {
        size1 = UserInputs.TryParseArrayUserInput<int>(2);
    }
    while (size1.Length != 2);
    matrix1 = Cycles.CreateAndFill2DArray<int>(size1[0], size1[1], 1, 10);

    System.Console.WriteLine("Введите два числа определяющих размеры второй матрицы:");
    do
    {
        size2 = UserInputs.TryParseArrayUserInput<int>(2);
    }
    while (size2.Length != 2);
    matrix2 = Cycles.CreateAndFill2DArray<int>(size2[0], size2[1], 1, 10);

    if (size1[1] != size2[0])
    {
        System.Console.WriteLine("Количество столбцов первой матрицы должно быть равно количеству строк второй!");
    }
    else check = true;
}
while (!check);

System.Console.WriteLine("_______________\n");
Cycles.Print2DArray(matrix1);
System.Console.WriteLine("_______________\n");
Cycles.Print2DArray(matrix2);
System.Console.WriteLine("_______________\n");



Cycles.Print2DArray(MultiplyMatrices(matrix1, matrix2));

int[,] MultiplyMatrices(int[,] matrix1, int[,] matrix2)
{
    int[,] result = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            result[i, j] = Multiply(matrix1, matrix2, i, j);
        }
    }
    return result;
}

int Multiply(int[,] matrix1, int[,] matrix2, int row, int col)
{
    int result = 0;
    for (int i = 0; i < matrix1.GetLength(1); i++)
    {
        result += matrix1[row, i] * matrix2[i, col];
    }
    return result;
}