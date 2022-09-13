// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22


using Shared.UserInputs;

namespace HomeworkAug30
{
    class Program
    {
        static void Main(string[] args)
        {

            int? result = null;

            #region Two inputs
            if (args.Length != 0 && args[0] == "sep")
            {
                System.Console.Write("Enter a number: ");
                int num1 = UserInputs.TryParseIntUserInput();

                System.Console.Write("Enter another number: ");
                int num2 = UserInputs.TryParseIntUserInput();
                result = CompareTwo(num1, num2);
            }
            #endregion

            #region Single input (array)
            if (args.Length == 0 || args[0] == "single")
            {
                System.Console.Write("Enter numbers to compare: ");
                int[] numbersToCompare = UserInputs.TryParseIntArrayUserInput(); //Pass an integer to limit the amount of numbers to parse and return
                result = GetMaxFromArray(numbersToCompare);
            }
            #endregion

            System.Console.WriteLine($"Max = {result}");
        }
        static int CompareTwo(int num1, int num2)
        {
            if (num1 >= num2) return num1;
            else return num2;
        }
        static int GetMaxFromArray(int[] array)
        {
            int max = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (max < array[i])
                {
                    max = array[i];
                }
            }
            return max;
        }
    }
}