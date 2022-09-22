namespace Shared.Cycles
{
    public class Cycles
    {
        ///<summary>
        ///Creates an array of numbers and fills with random values.
        ///</summary>
        ///<param name="length">
        ///Length of the array.
        ///</param>
        ///<param name="floor">
        ///Optional. Min value for Random.Next() method. Default - 0.
        ///</param>
        ///<param name="ceiling">
        ///Optional. Max value for Random.Next() method. Default - 10.
        ///</param>
        ///<param name="digits">
        ///Optional. Amount of digits after decimal point. Default - 2;
        ///</param>
        ///<returns>
        ///Array of numbers.
        ///</returns>
        static public T[] CreateAndFillArray<T>(int length, int floor = 0, int ceiling = 10, int digits = 2)
        {
            var _random = new Random();
            var result = new T[length];
            if (typeof(T) == typeof(int))
            {
                for (int i = 0; i < length; i++)
                {
                    result[i] = (T)(object)_random.Next(floor, ceiling);
                }
            }
            if (typeof(T) == typeof(double))
            {
                for (int i = 0; i < length; i++)
                {
                    result[i] = (T)(object)Math.Round(_random.Next(floor, ceiling) + _random.NextDouble(), digits);
                }
            }
            return result;
        }

        static public T[,] CreateAndFill2DArray<T>(int rows, int columns, int floor = 0, int ceiling = 10, int digits = 2)
        {
            T[,] array = new T[rows, columns];
            var tmp = CreateAndFillArray<T>(columns, floor, ceiling, digits); //Лишний вызов =(
            var count = Buffer.ByteLength(tmp);
            for (int i = 0; i < rows; i++)
            {
                tmp = CreateAndFillArray<T>(columns, floor, ceiling, digits);
                Buffer.BlockCopy(tmp, 0, array, i*count, count);
            }
            return array;
        }


        static public void PrintArray<T>(IList<T> array)
        {
            System.Console.Write($"[{array[0]}");
            for (int i = 1; i < array.Count; i++)
            {
                System.Console.Write($", {array[i]}");
            }
            System.Console.WriteLine("]");
        }
        static public void Print2DArray<T>(T[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    System.Console.Write($"{array[i, j]}\t");
                }
                System.Console.WriteLine();
            }
        }
    }
}