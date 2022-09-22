// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


using Shared.Cycles;
int[,] array = Cycles.CreateAndFill2DArray<int>(4,5);
Cycles.Print2DArray(array);
System.Console.WriteLine();

for (int i = 0; i < array.GetLength(1); i++)
{
    int sum = 0;
    for (int j = 0; j < array.GetLength(0); j++)
    {
        sum += array [j,i];
    }
    System.Console.WriteLine($"Сумма чисел в столбце {i} = {sum}" + " Среднее арифметическое в столбце = " + (double)sum/array.GetLength(0) + "\t");
}