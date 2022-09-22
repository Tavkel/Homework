// Трехмерный массив неповторяющихся чисел

int rows = 5;
int columns = 5;
int depth = 5;

int[,,] array3 = new int[rows, columns, depth];
int size = rows * columns * depth;
int iterator = 0;
int[] arrayCheck = new int[size];

for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        for (int k = 0; k < depth; k++)
        {
            int tmp;
            do
            {
                tmp = new Random().Next(size + 1);
            }
            while (CheckIfExists(tmp, arrayCheck));

            array3[i, j, k] = tmp;
            arrayCheck[iterator] = tmp;
            iterator++;
            System.Console.WriteLine(array3[i, j, k] + $"\t({i}, {j}, {k})");
        }
    }
}

bool CheckIfExists(int number, int[] array)
{
    bool result = false;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == number)
        {
            result = true;
            return result;
        }
    }
    return result;
}

// Эффективность на уровне бого-сорта, если не хуже.

// Вариант 2

System.Console.WriteLine("_______________________");
int[] sourceArray = new int[size +1];

for (int i = 0; i < sourceArray.Length; i++)
{
    sourceArray[i] = i;
}


for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        for (int k = 0; k < depth; k++)
        {

            array3[i, j, k] = GetNumber(sourceArray, new Random().Next(sourceArray.Length -1));
            System.Console.WriteLine(array3[i, j, k] + $"\t({i}, {j}, {k})");
        }
    }
}

static int GetNumber(int[] arr, int index)
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
        for (int i = index; i > 0; i--)
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