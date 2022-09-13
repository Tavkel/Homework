// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

using Shared.UserInputs;

namespace HomeworkSep06
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Введите координаты первой точки: ");
            var pointA = CreateNewPoint();
            System.Console.WriteLine("Введите координаты второй точки: ");
            var pointB = CreateNewPoint();

            System.Console.WriteLine("Расстояние между точками равно " + pointA.GetDistance(pointB));
        }



        static Point CreateNewPoint()
        {
            Point point;
            var tmp = UserInputs.TryParseIntArrayUserInput();
            if (tmp.Length != 3)
            {
                System.Console.WriteLine("Ошибка ввода. Необходимо указать 3 координаты\nВведите координаты точки: ");
                return CreateNewPoint();
            }
            else
            {
                point = new Point(tmp[0], tmp[1], tmp[2]);
                return point;
            }
        }
    }
}