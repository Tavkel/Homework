// * Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:


//  1  2  3  4
// 12 13 14  5
// 11 16 15  6
// 10  9  8  7
using Shared.Cycles;

int rows = 20;
int columns = 4;

int[,] matrix = new int[rows, columns];
bool[,] map = new bool[rows, columns];
int[] vector = { 0, 1 };
int[] position = { 0, 0 };
int iterator = 1;


FillMatrixSpiral(matrix, map, position, vector, iterator);
System.Console.WriteLine("_______________________________\n");
Cycles.Print2DArray(matrix);

void FillMatrixSpiral(int[,] matrix, bool[,] map, int[] position, int[] vector, int iterator)
{
    for (int i = 0; i < matrix.GetLength(0) * matrix.GetLength(1); i++)
    {
        iterator = FillOnPosition(matrix, map, position, iterator);
        Move(map, position, vector);
    }
}


int FillOnPosition(int[,] matrix, bool[,] map, int[] position, int value)
{
    matrix[position[0], position[1]] = value;
    map[position[0], position[1]] = true;
    return value + 1;
}

void Move(bool[,] map, int[] position, int[] vector)
{
    try
    {
        if (!map[position[0] + vector[0], position[1] + vector[1]])
        {
            System.Console.WriteLine("Moving forward to next position!");
            position[0] += vector[0];
            position[1] += vector[1];
        }
        else
        {
            System.Console.WriteLine("Tried to move to occupied space, turning right!");
            vector = TurnRight(vector);
            Cycles.Print2DArray<int>(matrix);
            position[0] += vector[0];
            position[1] += vector[1];
        }
    }
    catch (IndexOutOfRangeException)
    {
        System.Console.WriteLine("Tried to move out of bounds, turning right!");
        vector = TurnRight(vector);
        Move(map, position, vector);
    }
}

int[] TurnRight(int[] vector)
{
    double angle;

    if (vector[0] >= 0)
    {
        angle = Math.Acos(vector[1] / Math.Sqrt(vector[1] * vector[1] + vector[0] * vector[0]));
    }
    else
    {
        angle = -1 * Math.Acos(vector[1] / Math.Sqrt(vector[1] * vector[1] + vector[0] * vector[0]));
    }


    angle = angle + Math.PI / 2;

    vector[0] = (int)Math.Sin(angle); // * Length (Длина вектора изначально)
    vector[1] = (int)Math.Cos(angle); // * Length (Длина вектора изначально)

    return vector;
}


