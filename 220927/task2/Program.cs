// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

System.Console.WriteLine("Введите число:");
int numberM = Int32.Parse(Console.ReadLine());
System.Console.WriteLine("Введите число больше предыдущего:");
int numberN = Int32.Parse(Console.ReadLine());
int sum = GetSumOfIntsInRange(numberN, numberM);
System.Console.WriteLine(sum);

int GetSumOfIntsInRange(int numberStart, int numberStop)
{
    if (numberStart == numberStop) return numberStop;
    else
    {
        return numberStart + GetSumOfIntsInRange(numberStart -1, numberStop);
    }
}