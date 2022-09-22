// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

using Shared.UserInputs;
using Shared.Cycles;
internal class Program
{
    private static void Main(string[] args)
    {
        int rows = 5;
        int columns = 5;
        int[,] matrix = Cycles.CreateAndFill2DArray<int>(rows, columns);
        Cycles.Print2DArray<int>(matrix);

        System.Console.WriteLine("Введите координаты элемента матрицы, два числа через разделитель (',', '|', ' '), либо одно число для поиска его координат в матрице:");
        int[] userInput = UserInputs.TryParseArrayUserInput<int>(2);
        if (userInput.Length == 2)
        {
            try
            {
                System.Console.WriteLine("Элемент по указанным координатам равен " + matrix[userInput[0], userInput[1]]);
            }
            catch (IndexOutOfRangeException)
            {
                System.Console.WriteLine("Координаты за пределами массива");
            }
        }
        else
        {
            var result = new List<int[]>();
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (matrix[i, j] == userInput[0])
                    {
                        int[] a = new int[] { i, j };
                        result.Add(a);
                    }
                }
            }
            if (result.Count != 0)
            {
                System.Console.WriteLine($"Элемменты, равные {userInput[0]}, обнаружены:");
                foreach (var element in result)
                {
                    System.Console.WriteLine($"({element[0]}, {element[1]})");
                }
            }
            else System.Console.WriteLine($"Элемменты, равные {userInput[0]}, не обнаружены");
        }
    }
}