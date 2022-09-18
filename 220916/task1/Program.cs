// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int count = 0;
int num;
string input;

do
{
    input = Console.ReadLine();
    if (Int32.TryParse(input, out num) && num > 0)
    {
        count++;
    }
}while (input != string.Empty);

System.Console.WriteLine(count);