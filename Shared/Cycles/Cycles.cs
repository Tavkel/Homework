namespace Shared.Cycles
{
    public class Cycles
    {
        // static public void PrintArray(int[] array)
        // {
        //     System.Console.Write($"[{array[0]}");
        //     for (int i = 1; i < array.Length; i++)
        //     {
        //         System.Console.Write($", {array[i]}");
        //     }
        //     System.Console.WriteLine("]");
        // }
        // static public void PrintArray(double[] array)
        // {
        //     System.Console.Write($"[{array[0]}");
        //     for (int i = 1; i < array.Length; i++)
        //     {
        //         System.Console.Write($", {array[i]}");
        //     }
        //     System.Console.WriteLine("]");
        // }
        static public void PrintArray<T>(IList<T> array)
        {
            System.Console.Write($"[{array[0]}");
            for (int i = 1; i < array.Count; i++)
            {
                System.Console.Write($", {array[i]}");
            }
            System.Console.WriteLine("]");
        }
    }
}