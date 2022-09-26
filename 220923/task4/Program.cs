// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

using Shared.UserInputs;
using Shared.Cycles;

System.Console.WriteLine("Введите нижнюю границу значений:");
int floor = UserInputs.TryParseIntUserInput();
System.Console.WriteLine("Введите верхнюю границу значений:");
int ceiling = UserInputs.TryParseIntUserInput() + 1;

int[] size;
bool check = false;
do
{
    System.Console.WriteLine("Введите размеры трехмерного массива:");
    size = UserInputs.TryParseArrayUserInput<int>(3);
    if (size.Length != 3)
    {
        System.Console.WriteLine("Необходимо три числа!");
        continue;
    }
    if (Math.Abs(ceiling - floor) < size[0] * size[1] * size[2])
    {
        System.Console.WriteLine("Диапозон значений для заполнения массива меньше размера массива!\nЗаполнение массива неповторяющимися значениями невозможен!");
        continue;
    }
    check = true;
}
while (!check);
// по-хорошему нужны проверки на значения больше нуля для размеров массива и проверка floor < ceiling


int[] sourceArray = GenerateSourceArray(floor, ceiling);
int[,,] result = new int[size[0], size[1], size[2]];
result = FillArray(result, sourceArray);
Print3DArray(result);


int[] GenerateSourceArray(int floor, int ceiling)
{
    int[] result = new int[Math.Abs(ceiling - floor)];
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = i + floor;
    }
    return result;
}
int[,,] FillArray(int[,,] array, int[] sourceArray)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[i, j, k] = GetNumber(sourceArray, Random.Shared.Next(sourceArray.Length - 1));
            }
        }
    }
    return result;
}
int GetNumber(int[] arr, int index)
{
    if (arr[index] != -1)
    {
        int tmp = arr[index];
        arr[index] = -1;
        return tmp;
    }
    else
    {
        for (int i = index; i < arr.Length; i++)
        {
            if (arr[i] != -1)
            {
                int tmp = arr[i];
                arr[i] = -1;
                return tmp;
            }
        }
        for (int i = index; i >= 0; i--)
        {
            if (arr[i] != -1)
            {
                int tmp = arr[i];
                arr[i] = -1;
                return tmp;
            }
        }
        System.Console.WriteLine("Что-то пошло не так");
        return -1;
    }
}
void Print3DArray(int[,,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(2); k++)
            {
                System.Console.WriteLine(arr[i, j, k] + $"\t({i}, {j}, {k})");
            }
        }
    }
}
