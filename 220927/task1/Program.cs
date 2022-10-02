// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

System.Console.WriteLine("Введите число:");
int number = Int32.Parse(Console.ReadLine());
PrintNaturalNumbersFromNToOne(number);

void PrintNaturalNumbersFromNToOne(int number)
{
    if (number == 1) System.Console.WriteLine(1);
    else
    {
        System.Console.Write(number + ", ");
        PrintNaturalNumbersFromNToOne(number - 1);
    }
}