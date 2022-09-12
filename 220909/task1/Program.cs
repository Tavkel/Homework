// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int number;
int power;
int result = 1;
do
{
    System.Console.WriteLine("Введите число:");
}
while (!Int32.TryParse(Console.ReadLine(), out number));
do
{
    System.Console.WriteLine("Введите степень:");
}
while (!Int32.TryParse(Console.ReadLine(), out power));

for (int i = power; i > 0; i--)
{
    result = result * number;
}



System.Console.WriteLine(result);



static int Power(int number, int power)
{
    if (power == 0)
    {
        return 1;
    }
    return number * Power(number, power - 1);
}

System.Console.WriteLine(Power(number, power));