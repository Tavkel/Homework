// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
using Shared.UserInputs;
using Shared.Cycles;

namespace HomeworkSep16
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            System.Console.WriteLine("Формат ввода:\nРазделители: ',', '|', ' ' (пробел)\nДля дробных чисел в качестве разделителя целой и дробной частей используется '.'");
            System.Console.WriteLine("Введите коэффициент и офсет первой прямой: ");
            var line1 = CreateNewLine();
            System.Console.WriteLine("Введите коэффициент и офсет второй прямой: ");
            var line2 = CreateNewLine();

            bool? result = line1.IsParallel(line2);
            if(result == null)
            {
                System.Console.WriteLine("Одинаковые прямые");
                return;
            }
            if(result == true)
            {
                System.Console.WriteLine("Прямые параллельны");
                return;
            }
            if(result == false)
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