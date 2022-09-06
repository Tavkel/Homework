// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

//using Shared.UserInputs;

using System.Text.RegularExpressions;

namespace HomeworkSep06
{
    class Program
    {
        //private static UserInputs _userInputs = new UserInputs();

        static void Main(string[] args)
        {
            string input;
            do
            {
                input = Console.ReadLine();
            }
            while(input == null || input.Length == 0);

            if(Int32.TryParse(input, out int a))
            {
                input = Math.Abs(a).ToString();
            }
            else
            {
                input = Regex.Replace(input, "[^a-zA-Zа-яА-Я]", "").ToLower();
            }

            bool check = true;
            for(int i = 0; i + 1 <= input.Length / 2; i++)
            {
                if (input[i] == input[^(i+1)]) continue;
                else
                {
                    check = false;
                    break;
                }
            }
            if(check) System.Console.WriteLine("Введенная строка - палиндром");
            else System.Console.WriteLine("Введенная строка - не палиндром");
        }
    }
}