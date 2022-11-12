// Задача 64: Задайте значение N. Напишите программу, которая выведет все
// натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
string ReverseGetPrint(int start, int end)
{
    if (start == end)
    {
        return start.ToString();
    }
    return end + " " + ReverseGetPrint(start, end - 1);
}

Console.Write("Введите натуральное число N: ");
int number = int.Parse(Console.ReadLine()!);
int m = 1;
Console.WriteLine(ReverseGetPrint(m, number));