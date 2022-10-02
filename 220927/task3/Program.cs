// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29


System.Console.WriteLine("Введите первое число:");
int numberM = Int32.Parse(Console.ReadLine());
System.Console.WriteLine("Введите второе число:");
int numberN = Int32.Parse(Console.ReadLine());

System.Console.WriteLine(Ackerman(numberM, numberN));

int Ackerman(int m, int n)
{
    if (m == 0) return n + 1;
    else if (n == 0) return Ackerman(m-1, 1);
    else return Ackerman(m-1, Ackerman(m, n-1));
}