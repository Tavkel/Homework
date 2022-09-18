// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
using Shared.UserInputs;
using Shared.Cycles;
using System.Globalization;

namespace HomeworkSep16
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            System.Console.WriteLine("Введите коэффициент и офсет первой прямой: ");
            var line1 = CreateNewLine();
            System.Console.WriteLine("Введите коэффициент и офсет второй прямой: ");
            var line2 = CreateNewLine();
            if(line1.IsParallel(line2) == null)
            {
                System.Console.WriteLine("Одинаковые прямые");
                return;
            }
            if(line1.IsParallel(line2) == true)
            {
                System.Console.WriteLine("Прямые параллельны");
                return;
            }
            if(line1.IsParallel(line2) == false)
            {
                var intersection = line1.Intersection(line2);
                Cycles.PrintArray<double>(intersection);
            }

        }


        static Line CreateNewLine()
        {
            Line line;
            var tmp = UserInputs.TryParseArrayUserInput<double>();
            if (tmp.Length != 2)
            {
                System.Console.WriteLine("Ошибка ввода. Необходимо указать два параметра: коэффициент и офсет\nВведите коэффициент и офсет: ");
                return CreateNewLine();
            }
            else
            {
                line = new Line(tmp[0], tmp[1]);
                return line;
            }
        }
    }
}