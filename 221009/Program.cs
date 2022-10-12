using Shared.Cycles;

#region input data
string[] input = new string[] { "sad", "adsad", "Kazakhstan", "-2aa", "324", "^&aa" };
int limit = 3;
#endregion

#region initial solution
int[] indexes = new int[input.Length];
int lessThanThreeAmount = 0;

for (int i = 0; i < input.Length; i++)
{
    if (input[i].Length <= limit)
    {
        indexes[lessThanThreeAmount] = i;
        lessThanThreeAmount++;
    }
}

string[] result = new string[lessThanThreeAmount];

for (int i = 0; i < result.Length; i++)
{
    result[i] = input[indexes[i]];
}
Cycles.PrintArray(result);
#endregion

#region refactored
int[] indexes2 = GetIndexesOfElementsShorterThanLimit(input, limit);
string[] result2 = GetElementsByIndexes(input, indexes2);
Cycles.PrintArray(result2);

int[] GetIndexesOfElementsShorterThanLimit(string[] array, int limit)
{
    int[] result = new int[CountElementsShorterThanLimit(array, limit)];
    int counter = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= limit)
        {
            result[counter] = i;
            counter++;
        }
    }
    return result;
}

int CountElementsShorterThanLimit(string[] array, int limit)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= limit)
        {
            result++;
        }
    }
    return result;
}

string[] GetElementsByIndexes(string[] array, int[] indexes)
{
    string[] result = new string[indexes.Length];
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = array[indexes[i]];
    }
    return result;
}
#endregion

#region linq
var result3 = input.Where(_ => _.Length < 4).ToArray();
Cycles.PrintArray(result3);
#endregion


